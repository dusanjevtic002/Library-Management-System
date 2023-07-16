using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UsersStage : Form
    {
        private static UsersStage instance;
        private UsersStage()
        {
            InitializeComponent();
        }

        private void UsersStage_Load(object sender, EventArgs e)
        {
            loadUsers();
            adjustTextBoxes();
            adjustDataGrid();
            adjustComboBoxGender();
        }

        private void adjustComboBoxGender()
        {
            this.comboBoxGenderU.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxGenderU.SelectedIndex = 0;
        }

        private void adjustDataGrid()
        {
            this.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        public void setTheme1UsersStage()
        {
            this.panelHeaderUsers.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblUsers.ForeColor = Color.Black;
            this.lblFirstNameU.ForeColor = Color.Black;
            this.lblLastNameU.ForeColor = Color.Black;
            this.lblGenderU.ForeColor = Color.Black;
            this.lblInformation.ForeColor = Color.Black;
            this.lblEmailU.ForeColor = Color.Black;
            this.lblPassword.ForeColor = Color.Black;
            this.lblEmployeeID.ForeColor = Color.Black;
        }

        public void setTheme2UsersStage()
        {
            this.panelHeaderUsers.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblUsers.ForeColor = Color.White;
            this.lblFirstNameU.ForeColor = Color.White;
            this.lblLastNameU.ForeColor = Color.White;
            this.lblGenderU.ForeColor = Color.White;
            this.lblInformation.ForeColor = Color.White;
            this.lblEmailU.ForeColor = Color.White;
            this.lblPassword.ForeColor = Color.White;
            this.lblEmployeeID.ForeColor = Color.White;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];
                this.txtBoxEmployeeID.Text = row.Cells["Employee ID"].Value.ToString();
                this.txtBoxFirstNameU.Text = row.Cells["First Name"].Value.ToString();
                this.txtBoxLastNameU.Text = row.Cells["Last Name"].Value.ToString();
                this.comboBoxGenderU.Text = row.Cells["Gender"].Value.ToString();
                this.txtBoxEmailU.Text = row.Cells["Email"].Value.ToString();
                this.txtBoxPasswordU.Text = row.Cells["Password"].Value.ToString();
            }
        }

        public static UsersStage getInstance()
        {
            if (instance == null)
                instance = new UsersStage();

            return instance;
        }
    }
}
