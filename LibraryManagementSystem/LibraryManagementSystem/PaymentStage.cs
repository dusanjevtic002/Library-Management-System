using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class PaymentStage : Form
    {
        private static int priceSum = 0;
        private static String txt = null;
        private static int bookCounter = 1;
        private static int choice = 1;
        private static List<String> bookNames = new List<String>(); 
        public PaymentStage()
        {
            InitializeComponent();
            adjustRTBox();
        }

        private void adjustRTBox()
        {
            this.rTBoxBill.ReadOnly = true;
            this.rTBoxBill.Enabled = false;
            this.rTBoxBill.Text += "************************************************************************************************\n";
            this.rTBoxBill.Text += "********************************              Bill                *************************************\n";
            this.rTBoxBill.Text += "************************************************************************************************\n\n";
        }

        public void fillRTBox(String bookName, String author, String price)
        {
            txt += bookCounter + ". Book name: " + bookName + ", author: " + author + ", price = " + price + "$" + "\n";
            bookCounter++;

            priceSum += int.Parse(price);
            bookNames.Add(bookName);
        }

        public void fillRTBoxWithPrice()
        {
            this.rTBoxBill.Text += txt;
            this.rTBoxBill.Text += "\n\nFinal price: " + priceSum + "$";
        }

        private void resetValues()
        {
            bookNames = new List<String>();
            priceSum = 0;
            txt = null;
            bookCounter = 1;
            choice = 1;
            this.rTBoxBill.Text = "";
        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            if(bookNames.Count == 0)
                MessageBox.Show("No bill has been made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                foreach(String bookName in bookNames)
                {
                    string query = "SELECT * FROM LBAllBooks WHERE Name = '" + bookName + "'";
                    String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString;

                    TransactionsStage transactionsStage = TransactionsStage.getInstance();
                    transactionsStage.increaseQuantityDataBaseBooks(bookName, choice++); 
                    transactionsStage.adjustLabelCount('-'); 
                    
                    /*choice povecavam iz razloga sto u increaseQuantity metodi ako je choice = 1 ispisace se poruka da smo ponistili racun,
                     * posto se ta metoda poziva po svakoj knjizi iz liste to bi se desavalo za svako knjigu, time sto povecavamo choice
                     *ovo ce se desiti samo jedanput*/ 
                }
            }

            resetValues();
            this.Hide();
        }

        private void btnChargeCustomer_Click(object sender, EventArgs e)
        {
            TransactionsStage transactionsStage = TransactionsStage.getInstance();

            foreach (String bookName in bookNames)
                transactionsStage.adjustLabelCount('-');

            MessageBox.Show("You have charged the customer succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetValues();
            this.Hide();
        }
    }
}
