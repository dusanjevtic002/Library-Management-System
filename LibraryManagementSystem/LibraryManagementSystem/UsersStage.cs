using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UsersStage : Form
    {
        private static UsersStage instance;
        private static String fileName = "accounts.txt";
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
            this.comboBoxGenderU.Items.Add("Male");
            this.comboBoxGenderU.Items.Add("Female");
        }

        private void loadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String line = lines[i];
                    String[] elements = line.Split(',');

                    DataRow rowToAdd = dataTable.NewRow();

                    rowToAdd["First name"] = elements[0];
                    rowToAdd["Last name"] = elements[1];
                    rowToAdd["Gender"] = elements[2];
                    rowToAdd["Email"] = elements[3];
                    rowToAdd["Password"] = elements[4];

                    dataTable.Rows.Add(rowToAdd);
                }

                this.dgvUsers.DataSource = dataTable;
                this.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnBackU_Click(object sender, EventArgs e)
        {
            txtBoxFirstNameU.Text = "";
            txtBoxLastNameU.Text = "";
            comboBoxGenderU.Text = "";
            txtBoxPasswordU.Text = "";
            txtBoxEmailU.Text = "";

            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
            String email = selectedRow.Cells["Email"].Value.ToString();
            String password = selectedRow.Cells["Password"].Value.ToString();

            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String line = lines[i];

                    String[] elements = line.Split(',');
                    String emailToCheck = elements[3];
                    String passwordToCheck = elements[4];

                    if(emailToCheck.Equals(email) && passwordToCheck.Equals(password))
                    {
                        lines[i] = txtBoxFirstNameU.Text + "," + txtBoxLastNameU.Text + "," + comboBoxGenderU.Text + "," + txtBoxEmailU.Text + "," + txtBoxPasswordU.Text;
                        File.WriteAllLines(fileName, lines);
                        break;
                    }
                        
                }

                MessageBox.Show("You have updated this account successfully");
                loadUsers();
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            this.txtBoxFirstNameU.Text = "";
            this.txtBoxLastNameU.Text = "";
            this.comboBoxGenderU.SelectedIndex = 0;
            this.txtBoxEmailU.Text = "";
            this.txtBoxPasswordU.Text = "";
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvUsers.Rows[e.RowIndex];
                this.txtBoxFirstNameU.Text = row.Cells["First name"].Value.ToString();
                this.txtBoxLastNameU.Text = row.Cells["Last name"].Value.ToString();
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

        private void UsersStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
