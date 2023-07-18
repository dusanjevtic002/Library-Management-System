using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignUpStage : Form
    {
        private static string fileName = "accounts.txt";
        public SignUpStage()
        {
            InitializeComponent();
        }

        private void SignUpStage_Load(object sender, EventArgs e)
        {
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
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
                    StreamWriter accountsFile = File.AppendText(fileName);
                    accountsFile.WriteLine(firstName + "," + lastName + "," + gender + ","  + email + "," + password);
                    accountsFile.Close();

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

        private void SignUpStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
