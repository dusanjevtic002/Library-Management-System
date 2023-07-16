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
    public partial class BorrowerInfoStage : Form
    {
        private static int counter = 1;

        private String bookName;
        private String author;
        private String genre;
        private String quantity;
        public BorrowerInfoStage(String bookName, String author, String genre, String quantity)
        {
            this.bookName = bookName;
            this.author = author;
            this.genre = genre;
            this.quantity = quantity;
            InitializeComponent();
        }

        private void adjustCounter()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBorrowedBooksConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT MAX(Id) FROM LBAllBorrowedBooks";
            SqlCommand command = new SqlCommand(query, con);

            object result = command.ExecuteScalar();

            if (result != DBNull.Value)
                counter = Convert.ToInt32(result) + 1;

            else
                counter = 1;
        }

        public void btnBorrowBook_Click(object sender, EventArgs e)
        {
            String contact = this.txtBoxContact.Text;
            String borrowDate = this.dtpBorrowDate.Value.ToString();
            String returnDate = this.dtpReturnDate.Value.ToString();

            adjustCounter();

            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBorrowedBooksConnectionString"].ConnectionString; ;
                String insertSQL = "INSERT INTO LBAllBorrowedBooks (Id, [Borrower contact], [Book name], Author, Genre, [Borrow date], [Return date]) VALUES (@Id, @BorrowerContact, @BookName, @Author, @Genre, @BorrowDate, @ReturnDate)";
                                                        //[ ] omogucuju da se ne stvara error pri gledanju kolona koje imaju white space u sebi

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(insertSQL, con);
                con.Open();

                cmd.Parameters.AddWithValue("@Id", counter++);
                cmd.Parameters.AddWithValue("@BorrowerContact", contact);
                cmd.Parameters.AddWithValue("@BookName", this.bookName);
                cmd.Parameters.AddWithValue("@Author", this.author);
                cmd.Parameters.AddWithValue("@Genre", this.genre);
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                cmd.ExecuteNonQuery();

                MessageBox.Show("You have borrowed book successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TransactionsStage transactionsStage = TransactionsStage.getInstance();
                transactionsStage.loadDataBaseBorrowedBooks();
                transactionsStage.reduceQuantityDataBaseBooks(this.bookName, this.quantity);
                this.Hide();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
