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
    public partial class UsersStage : Form
    {
        private static UsersStage instance;
        public UsersStage()
        {
            InitializeComponent();
        }

        private void UsersStage_Load(object sender, EventArgs e)
        {
            loadUsers();
            adjustTextBoxes();
        }

        private void adjustTextBoxes()
        {
            this.txtBoxEmployeeID.ReadOnly = true;
            this.txtBoxEmployeeID.Enabled = false;
            this.comboBoxGenderU.Items.Add("Male");
            this.comboBoxGenderU.Items.Add("Female");
        }

        private void loadUsers()
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDatabaseAllAccountsConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT Id as 'Employee ID' ,FirstName as 'First Name' ,LastName as 'Last Name', Gender as 'Gender', Email as 'Email', Password as 'Password' FROM LBAllAccountsTable", connection);

                connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dgvUsers.DataSource = dbDataSet;
                sda.Update(dbDataSet);
                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static UsersStage getInstance()
        {
            if (instance == null)
                instance = new UsersStage();

            return instance;
        }

        private void btnBackU_Click(object sender, EventArgs e)
        {
            txtBoxEmployeeID.Text = "";
            txtBoxFirstNameU.Text = "";
            txtBoxLastNameU.Text = "";
            comboBoxGenderU.Text = "";
            txtBoxPasswordU.Text = "";
            txtBoxEmailU.Text = "";

            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];
                txtBoxEmployeeID.Text = row.Cells["Employee ID"].Value.ToString();
                txtBoxFirstNameU.Text = row.Cells["First Name"].Value.ToString();
                txtBoxLastNameU.Text = row.Cells["Last Name"].Value.ToString();
                comboBoxGenderU.Text = row.Cells["Gender"].Value.ToString();
                txtBoxEmailU.Text = row.Cells["Email"].Value.ToString();
                txtBoxPasswordU.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void UsersStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDatabaseAllAccountsConnectionString"].ConnectionString;
            String query = "UPDATE LBAllAccountsTable SET FirstName=@FirstName, LastName=@LastName, Gender=@Gender, Email=@Email, Password=@Password WHERE Id=@Id";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                cmd.Parameters.AddWithValue("@FirstName", this.txtBoxFirstNameU.Text);
                cmd.Parameters.AddWithValue("@LastName", this.txtBoxLastNameU.Text);
                cmd.Parameters.AddWithValue("@Gender", this.comboBoxGenderU.Text);
                cmd.Parameters.AddWithValue("@Email", this.txtBoxEmailU.Text);
                cmd.Parameters.AddWithValue("@Password", this.txtBoxPasswordU.Text);
                cmd.Parameters.AddWithValue("@Id", this.txtBoxEmployeeID.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("You have updated this account successfully");
                loadUsers();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
