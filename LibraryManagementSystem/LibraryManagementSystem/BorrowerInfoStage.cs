using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowerInfoStage : Form
    {
        private static String fileName = "borrowedBooks.txt";

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

        public void btnBorrowBook_Click(object sender, EventArgs e)
        {
            String contact = this.txtBoxContact.Text;
            String borrowDate = this.dtpBorrowDate.Value.ToString("dd/MM/yyyy");
            String returnDate = this.dtpReturnDate.Value.ToString("dd/MM/yyyy");

            try
            {
                StreamWriter borrowedBooksFile = File.AppendText(fileName);

                borrowedBooksFile.WriteLine(contact + "," + this.bookName + "," + this.author + "," + borrowDate + "," + returnDate);
                borrowedBooksFile.Close();

                MessageBox.Show("You have borrowed book successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TransactionsStage transactionsStage = TransactionsStage.getInstance();
                transactionsStage.loadTxtFileBorrowedBooks();
                transactionsStage.reduceQuantityDataBaseBooks(this.bookName, this.quantity);
                this.Hide();

            }

            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
