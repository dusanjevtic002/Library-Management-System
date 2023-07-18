using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class TransactionsStage : Form
    {
        private static TransactionsStage instance;
        private static int counter = 0; //Brojac koji broji broj stvari u kolicima

        private static String fileName = "books.txt";
        private static String fileName2 = "filteredBooks.txt";
        private static String fileName3 = "borrowedBooks.txt";

        private TransactionsStage()
        {
            InitializeComponent();
            loadTxtFileBooks(fileName);
            loadTxtFileBorrowedBooks();
            adjustComboBoxes();
            adjustDataGrid();
        }

        public void setTheme1TransactionsStage()
        {
            this.panelHeaderTransactions.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblAuthor.ForeColor = Color.Black;
            this.lblAvailability.ForeColor = Color.Black;
            this.lblBorrowedBooks.ForeColor = Color.Black;
            this.lblCounter.ForeColor = Color.Black;
            this.lblGenre.ForeColor = Color.Black;
            this.lblName.ForeColor = Color.Black;
            this.lblSearch.ForeColor = Color.Black;
            this.lblTransactions.ForeColor = Color.Black;
        }

        public void setTheme2TransactionsStage()
        {
            this.panelHeaderTransactions.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblAuthor.ForeColor = Color.White;
            this.lblAvailability.ForeColor = Color.White;
            this.lblBorrowedBooks.ForeColor = Color.White;
            this.lblCounter.ForeColor = Color.White;
            this.lblGenre.ForeColor = Color.White;
            this.lblName.ForeColor = Color.White;
            this.lblSearch.ForeColor = Color.White;
            this.lblTransactions.ForeColor = Color.White;
        }

        //Metoda kao parametar ima fileName, iz razloga sto cu uvek prosledjivati ono sto zelim da prikazem, dakle ili sve knjige ili filtrirane knjige
        private void loadTxtFileBooks(String fileToAdd)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Publisher");
            dataTable.Columns.Add("Genre");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Availability");
            dataTable.Columns.Add("Price ($)");

            try
            {
                String[] lines = File.ReadAllLines(fileToAdd);

                for(int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    DataRow rowToAdd = dataTable.NewRow();
                    rowToAdd["Name"] = elements[0];
                    rowToAdd["Author"] = elements[1];
                    rowToAdd["Publisher"] = elements[2];
                    rowToAdd["Genre"] = elements[3];
                    rowToAdd["Quantity"] = elements[4];
                    rowToAdd["Availability"] = elements[5];
                    rowToAdd["Price ($)"] = elements[6];

                    dataTable.Rows.Add(rowToAdd);
                }

                this.dgvBooks.DataSource = dataTable;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Metoda kojom smanjujem kolicinu neke knjige kada je nekom iznajmim
        public void reduceQuantityDataBaseBooks(String bookName, String quantity)
        {
            int quantityValue = int.Parse(quantity) - 1;

            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if(elements[0].Equals(bookName))
                    {
                        lines[i] = elements[0] + "," + elements[1] + "," + elements[2] + "," + elements[3] + "," + quantityValue + "," + elements[5] + "," + elements[6];
                        File.WriteAllLines(fileName, lines);
                        break;
                    }
                }

                loadTxtFileBooks(fileName);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Metoda kojom povecavam kolicinu neke knjige kada je neko vrati, ili kada ponistavam racun i u zavisnosti od onoga sta radim ispisujem poruku u messageBoxu
        public void increaseQuantityDataBaseBooks(String bookName, int choice)
        {//Trazim knjigu na osnovu njenog naziva, nakon toga uzimam kolicinu te knjige u biblioteci na osnovu njenog naziva, zatim inkrementiram kolicinu za 1
            try
            {
                String[] lines = File.ReadAllLines(fileName);

                for(int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    int quantityValue = int.Parse(elements[4]) + 1;

                    if(elements[0].Equals(bookName))
                    {
                        lines[i] = elements[0] + "," + elements[1] + "," + elements[2] + "," + elements[3] + "," + quantityValue + "," + elements[5] + "," + elements[6];
                        File.WriteAllLines(fileName, lines);
                        break;
                    }
                }

                if(choice == 0)
                    MessageBox.Show("You have returned this book to the library successfully");

                else if(choice == 1)
                    MessageBox.Show("You have cancelled the bill succesfully");

                loadTxtFileBooks(fileName);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //Metoda kojom ucitavam bazu podataka u kojoj su podaci o pozajmljenim knjigama
        public void loadTxtFileBorrowedBooks()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Borrower contact");
            dataTable.Columns.Add("Book name");
            dataTable.Columns.Add("Author");
            dataTable.Columns.Add("Borrow date");
            dataTable.Columns.Add("Return date");

            try
            {
                String[] lines = File.ReadAllLines(fileName3);

                for (int i = 1; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    DataRow rowToAdd = dataTable.NewRow();
                    rowToAdd["Borrower contact"] = elements[0];
                    rowToAdd["Book name"] = elements[1];
                    rowToAdd["Author"] = elements[2];
                    rowToAdd["Borrow date"] = elements[3];
                    rowToAdd["Return date"] = elements[4];

                    dataTable.Rows.Add(rowToAdd);
                }

                this.dgvBorrowedBooks.DataSource = dataTable;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void adjustLabelCount(char operation)
        {
            if (operation == '+')
                counter++;

            else
                counter--;

            this.lblCounter.Text = counter.ToString();
        }

        private void adjustComboBoxes()
        {
            String[] itemsGenre = {"Psychology", "Philosophy", "Business / Entrepreneurship", "Science", "History",
                                   "Self-help", "Biography", "Horror", "Thriller / Suspense", "Romance", "Fantasy",
                                   "Science Fiction", "Mystery", "Non-fiction", "Fiction", "All genres"};

            String[] itemsAvailability = { "Available", "Not available" };

            this.cBoxGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cBoxAvailability.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cBoxGenres.Items.AddRange(itemsGenre);

            this.cBoxAvailability.Items.AddRange(itemsAvailability);

            this.cBoxGenres.SelectedIndex = 0;
            this.cBoxAvailability.SelectedIndex = 0;

        }

        private void adjustDataGrid()
        {
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.MultiSelect = false;
            this.dgvBorrowedBooks.MultiSelect = false;
        }

        private void searchOption1(String genreToFind, String availabilityToFind)
        {
            String[] lines = File.ReadAllLines(fileName);
            List<String> newLines = new List<String>();

            if (genreToFind.Equals("All genres"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    //ukljucujem i == 0 zato sto uvek hocu da kopiram patern liniju koja se nalazi u fajlu, njena pozicija je 0
                    if (i == 0 || elements[5].Equals(availabilityToFind))
                        newLines.Add(lines[i]);
                }

            }

            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (i == 0 || (elements[3].Equals(genreToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(fileName2, newLines);
            loadTxtFileBooks(fileName2);
        }

        private void searchOption2(String nameToFind, String genreToFind, String availabilityToFind)
        {
            String[] lines = File.ReadAllLines(fileName);
            List<String> newLines = new List<String>();

            if (genreToFind.Equals("All genres"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    //ukljucujem i == 0 zato sto uvek hocu da kopiram patern liniju koja se nalazi u fajlu, njena pozicija je 0
                    if (i == 0 || (elements[0].Contains(nameToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (i == 0 || (elements[0].Contains(nameToFind) && elements[3].Equals(genreToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(fileName2, newLines);
            loadTxtFileBooks(fileName2);

        }

        private void searchOption3(String authorToFind, String genreToFind, String availabilityToFind)
        {
            String[] lines = File.ReadAllLines(fileName);
            List<String> newLines = new List<String>();

            if (genreToFind.Equals("All genres"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    //ukljucujem i == 0 zato sto uvek hocu da kopiram patern liniju koja se nalazi u fajlu, njena pozicija je 0
                    if (i == 0 || (elements[1].Contains(authorToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (i == 0 || (elements[1].Contains(authorToFind) && elements[3].Equals(genreToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(fileName2, newLines);
            loadTxtFileBooks(fileName2);

        }

        private void searchOption4(String nameToFind, String authorToFind, String genreToFind, String availabilityToFind)
        {
            String[] lines = File.ReadAllLines(fileName);
            List<String> newLines = new List<String>();

            if (genreToFind.Equals("All genres"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');
                    //ukljucujem i == 0 zato sto uvek hocu da kopiram patern liniju koja se nalazi u fajlu, njena pozicija je 0
                    if (i == 0 || (elements[0].Contains(nameToFind) && elements[1].Contains(authorToFind) && elements[3].Equals(genreToFind)))
                        newLines.Add(lines[i]);
                }
            }

            else
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (i == 0 || (elements[0].Contains(nameToFind) && elements[1].Contains(authorToFind) && elements[3].Equals(genreToFind) && elements[5].Equals(availabilityToFind)))
                        newLines.Add(lines[i]);
                }
            }

            File.WriteAllLines(fileName2, newLines);
            loadTxtFileBooks(fileName2);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String nameToFind = this.txtBoxName.Text;
            String authorToFind = this.txtBoxAuthor.Text;
            String genreToFind = this.cBoxGenres.Text;
            String availabilityToFind = this.cBoxAvailability.Text;

            if (String.IsNullOrWhiteSpace(nameToFind) && String.IsNullOrWhiteSpace(authorToFind))
                searchOption1(genreToFind, availabilityToFind);

            else if (!String.IsNullOrWhiteSpace(nameToFind) && String.IsNullOrWhiteSpace(authorToFind))
                searchOption2(nameToFind, genreToFind, availabilityToFind);

            else if (String.IsNullOrWhiteSpace(nameToFind) && !String.IsNullOrWhiteSpace(authorToFind))
                searchOption3(authorToFind, genreToFind, availabilityToFind);

            else
                searchOption4(nameToFind, authorToFind, genreToFind, availabilityToFind);
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            this.txtBoxName.Text = "";
            this.txtBoxAuthor.Text = "";
            this.cBoxGenres.SelectedIndex = 0;
            this.cBoxGenres.SelectedIndex = 0;
            loadTxtFileBooks(fileName);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainStage mainStage = MainStage.getInstance();
            mainStage.Show();
        }

        //Metoda kojom dodajem stvari u Payment stage, odnosno u rich text box unutar njega
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(dgvBooks.SelectedRows.Count == 0)
                MessageBox.Show("Please select book from the left table before clicking this button", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                adjustLabelCount('+');
                DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
                String bookName = selectedRow.Cells["Name"].Value.ToString();
                String author = selectedRow.Cells["Author"].Value.ToString();
                String price = selectedRow.Cells["Price ($)"].Value.ToString();
                String quantity = selectedRow.Cells["Quantity"].Value.ToString();

                reduceQuantityDataBaseBooks(bookName, quantity);
                PaymentStage paymentStage = new PaymentStage();
                paymentStage.fillRTBox(bookName, author, price);
            }
        }

        //Metoda koja prikazuje payment stage i zove metodu koja ce na kraj rich text boxa dodati ukupnu cenu
        private void cartBtn_Click(object sender, EventArgs e)
        {
            PaymentStage paymentStage = new PaymentStage();
            paymentStage.Show();
            paymentStage.fillRTBoxWithPrice();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];
            String bookName = selectedRow.Cells["Name"].Value.ToString();
            String author = selectedRow.Cells["Author"].Value.ToString();
            String genre = selectedRow.Cells["Genre"].Value.ToString();
            String quantity = selectedRow.Cells["Quantity"].Value.ToString();

            BorrowerInfoStage borrowerInfoStage = new BorrowerInfoStage(bookName, author, genre, quantity);
            borrowerInfoStage.Show();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            loadTxtFileBooks(fileName);
        }

        private void btnReturnToLibrary_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvBorrowedBooks.SelectedRows[0];
            String bookName = selectedRow.Cells["Book name"].Value.ToString();

            try
            {
                /*Boolean hasbeenFound je tu iz razloga sto  mozemo imati vise pozajmljenih knjiga sa istim imenom, autorom, i publisherom koje se podudaraju sa kliknutom knjigom
             *  If uslov ce biti SKIPOVAN kada su stringovi jednaki ili kada je hasBeenFound = false, tada postavljamo hasBeenFound na true i tu knjigu necemo dodati u novu listu
             *  Svaki sledeci put ako prvi deo if uslova nije ispunjen to znaci da smo naleteli opet na knjigu sa istim imenom autorom i publisherom kao i kliknuta knjiga
             *  ali posto smo vec vratili knjigu koju smo kliknuli (knjiga koju smo vratili se vise nece nalaziti na spisku iznajmljenih knjiga), 
             *  hasBeenFound je ispunjen i ta knjiga ce se dodati u novu listu knjiga i na taj nacin se nece obrisati sve
             *  knjige iz lista pozajmljenih knjiga sa istim imenom autorom i publisherom kao i kliknuta knjiga
             */
                String[] lines = File.ReadAllLines(fileName3);
                List<String> newLines = new List<String>();
                Boolean hasBeenFound = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (!(elements[1].Equals(bookName)) || hasBeenFound)
                        newLines.Add(lines[i]);

                    else
                        hasBeenFound = true;
                }

                File.WriteAllLines(fileName3, newLines);

                increaseQuantityDataBaseBooks(bookName, 0);
                loadTxtFileBorrowedBooks();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static TransactionsStage getInstance()
        {
            if (instance == null)
                instance = new TransactionsStage();

            return instance;
        }

        private void TransactionsStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
