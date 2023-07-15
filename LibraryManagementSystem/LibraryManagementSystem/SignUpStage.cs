using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignUpStage : Form
    {
        private static int counter = 1;
        public SignUpStage()
        {
            InitializeComponent();
        }

        private void SignUpStage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localDatabaseAllAccountsDataSet.LBAllAccountsTable' table. You can move, or remove it, as needed.
            this.lBAllAccountsTableTableAdapter.Fill(this.localDatabaseAllAccountsDataSet.LBAllAccountsTable);
            adjustPasswordBoxes();
            loadComboBoxGenders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInStage signInStage = SignInStage.getInstance();
            signInStage.Show();
        }

        private void loadComboBoxGenders()
        {
            this.comboBoxGender.Items.Add("Male");
            this.comboBoxGender.Items.Add("Female");
            this.comboBoxGender.SelectedIndex = 0;

            //Omogucava mi da comboBox bude readonly
            this.comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void adjustPasswordBoxes()
        {
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxConfirmPassword.PasswordChar = '*';
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPassword.Checked)
                this.txtBoxPassword.PasswordChar = '\0';

            else
                this.txtBoxPassword.PasswordChar = '*';
        }

        private void SignUpStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Resava problem sa jedinstvenim Id-jem
        private void adjustCounter()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDatabaseAllAccountsConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT COUNT(*) FROM LBAllAccountsTable";
            SqlCommand command = new SqlCommand(query, con);

            int count = (int)command.ExecuteScalar();

            if (count > 0)
                counter = count + 1;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            adjustCounter();

            String firstName = txtBoxFirstName.Text;
            String lastName = txtBoxLastName.Text;
            String gender = comboBoxGender.Text;
            String email = txtBoxEmail.Text;
            String password = txtBoxPassword.Text;
            String confirmPassword = txtBoxConfirmPassword.Text;

            if(checkPasswords(password, confirmPassword))
            {
                try
                {
                   String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDatabaseAllAccountsConnectionString"].ConnectionString; ;
                   String insertSQL = "INSERT INTO LBAllAccountsTable (Id, FirstName, LastName, Gender, Email, Password) VALUES (@Id, @FirstName, @LastName, @Gender, @Email, @Password)";
                  // String deleteSQL = "DELETE FROM LBAllAccountsTable WHERE Id = @Id";

                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(insertSQL, con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@Id", counter++);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    //cmd.Parameters.AddWithValue("@Id", 1);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have been signed up successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            else
               MessageBox.Show("Please enter the same password in both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private Boolean checkPasswords(String password, String confirmPassword)
        {
            if (!password.Equals(confirmPassword))
                return false;

            return true;
        }

        private void lBAllAccountsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lBAllAccountsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localDatabaseAllAccountsDataSet);

        }
    }
}
