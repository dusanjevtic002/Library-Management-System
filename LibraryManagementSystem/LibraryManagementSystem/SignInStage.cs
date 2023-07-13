using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace LibraryManagementSystem
{
    public partial class SignInStage : Form
    {
        private static SignInStage instance;
        public SignInStage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adjustLblLibrarySystem();
            adjustTxtBoxPassword();
            adjustLinkLblSignUp();
        }

        private void searchDataBase(String email, String password)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDatabaseAllAccountsConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new  SqlCommand("SELECT * FROM LBAllAccountsTable WHERE Email='" + email + "' AND Password='" + password + "'", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                    count++;

                if(count == 1)
                {
                    MessageBox.Show("You have been signed in successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainStage mainStage = new MainStage();
                    this.Hide();
                    mainStage.Show();
                }

                else
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void adjustLblLibrarySystem()
        {
            this.lblLibrarySystem.Parent = pBoxBackgroundSignIn;
            this.lblLibrarySystem.BackColor = Color.Transparent;
        }

        private void adjustTxtBoxPassword()
        {
            this.txtBoxPassword.PasswordChar = '*';
        }

        private void adjustLinkLblSignUp()
        {
            this.linkLblSignUp.LinkBehavior = LinkBehavior.NeverUnderline;
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cBoxShowPassword.Checked)
                this.txtBoxPassword.PasswordChar = '\0';

            else
                this.txtBoxPassword.PasswordChar = '*';
        }

        private void linkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpStage signUpStage = new SignUpStage();
            this.Hide();
            signUpStage.Show();
        }

        public static SignInStage getInstance()
        {
            if (instance == null)
                instance = new SignInStage();

            return instance;
        }

        private void SignInStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String email = txtBoxEmail.Text;
            String password = txtBoxPassword.Text;
            searchDataBase(email, password);

        }
    }
}
