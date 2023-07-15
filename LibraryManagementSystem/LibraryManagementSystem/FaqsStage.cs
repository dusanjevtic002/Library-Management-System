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
    public partial class FaqsStage : Form
    {
        private static FaqsStage instance;
        private static int counter = 1;
        private FaqsStage()
        {
            InitializeComponent();
            loadDataBase();
            adjustTxtBoxQuestionSerialNo();
            adjustDataGrid();
        }

        private void adjustDataGrid()
        {
            this.dgvAllQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void adjustTxtBoxQuestionSerialNo()
        {
            this.txtBoxQuestionSerialNo.ReadOnly = true;
            this.txtBoxQuestionSerialNo.Enabled = false;
        }

        public void setTheme1FaqsStage()
        {
            this.panelHeaderFaqs.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblInfo.ForeColor = Color.Black;
            this.lblAddQuestion.ForeColor = Color.Black;
            this.lblAnswer.ForeColor = Color.Black;
            this.lblFaqs.ForeColor = Color.Black;
            this.lblQuestionSerialNo.ForeColor = Color.Black;
            this.lblTitleOfQuestion.ForeColor = Color.Black;
        }

        public void setTheme2FaqsStage()
        {
            this.panelHeaderFaqs.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblInfo.ForeColor = Color.White;
            this.lblAddQuestion.ForeColor = Color.White;
            this.lblAnswer.ForeColor = Color.White;
            this.lblFaqs.ForeColor = Color.White;
            this.lblQuestionSerialNo.ForeColor = Color.White;
            this.lblTitleOfQuestion.ForeColor = Color.White;
        }

        private void loadDataBase()
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllQuestionsConnectionString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SELECT Id as 'Serial No.',  TitleOfQuestion as 'Title of question', Answer as 'Answer' FROM LBAllQuestions", connection);

                connection.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;

                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                dgvAllQuestions.DataSource = dbDataSet;
                sda.Update(dbDataSet);
                dgvAllQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        //Resava problem sa jedinstvenim Id-jem
        private void adjustCounter()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllQuestionsConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT COUNT(*) FROM LBAllQuestions";
            SqlCommand command = new SqlCommand(query, con);

            int count = (int)command.ExecuteScalar();

            //Ukoliko je baza prazna, znaci broj redova je 0, odnosno count = 0, samim tim nema svrhe povecavati counter
            if (count > 0)
                counter = count + 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            adjustCounter();

            if(String.IsNullOrWhiteSpace(txtBoxTitleOfQuestion.Text) || (String.IsNullOrWhiteSpace(rTBoxAnswer.Text)))
                MessageBox.Show("Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                try
                {
                    String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllQuestionsConnectionString"].ConnectionString; ;
                    String insertSQL = "INSERT INTO LBAllQuestions (Id, TitleOfQuestion, Answer) VALUES (@Id, @TitleOfQuestion, @Answer)";
                    // String deleteSQL = "DELETE FROM LBAllAccountsTable WHERE Id = @Id";

                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(insertSQL, con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@Id", counter++);
                    cmd.Parameters.AddWithValue("@TitleOfQuestion", this.txtBoxTitleOfQuestion.Text);
                    cmd.Parameters.AddWithValue("@Answer", this.rTBoxAnswer.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have added question successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataBase();
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllQuestionsConnectionString"].ConnectionString;
                String query = "UPDATE LBAllQuestions SET TitleOfQuestion=@TitleOfQuestion, Answer=@Answer WHERE Id=@Id";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                cmd.Parameters.AddWithValue("@TitleOfQuestion", this.txtBoxTitleOfQuestion.Text);
                cmd.Parameters.AddWithValue("@Answer", this.rTBoxAnswer.Text);
                cmd.Parameters.AddWithValue("@Id", this.txtBoxQuestionSerialNo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("You have updated this question successfully");
                loadDataBase();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllQuestionsConnectionString"].ConnectionString;
                string deleteQuery = "DELETE FROM LBAllQuestions WHERE Id = @Id";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@Id", this.txtBoxQuestionSerialNo.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("You have deleted this question successfully");
                loadDataBase();

                this.txtBoxQuestionSerialNo.Text = "";
                this.txtBoxTitleOfQuestion.Text = "";
                this.rTBoxAnswer.Text = "";
            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgvAllQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAllQuestions.Rows[e.RowIndex];
                this.txtBoxQuestionSerialNo.Text = row.Cells["Serial No."].Value.ToString();
                this.txtBoxTitleOfQuestion.Text = row.Cells["Title of question"].Value.ToString();
                this.rTBoxAnswer.Text = row.Cells["Answer"].Value.ToString();
            }
        }

        private void FaqsStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static FaqsStage getInstance()
        {
            if (instance == null)
                instance = new FaqsStage();

            return instance;
        }
    }
}
