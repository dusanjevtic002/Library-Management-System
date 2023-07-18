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
    public partial class BooksStage : Form
    {
        private static BooksStage instance;
        //Imam dva fajla, jedan prikazuje sve knjige, a drugi sluzi da prikazuje filtrirane knjige
        private static String fileName = "books.txt";
        private static String fileName2 = "filteredBooks.txt";
        private BooksStage()
        {
            InitializeComponent();
            adjustComboBoxes();
            adjustDataGrid();
            loadTxtFile(fileName);
            adjustMaskedTextBoxes();
        }

        //Metoda kao parametar ima fileName, iz razloga sto cu uvek prosledjivati ono sto zelim da prikazem, dakle ili sve knjige ili filtrirane knjige
        private void loadTxtFile(String fileToAdd)
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

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void setTheme1BooksStage()
        {
            this.panelHeaderBooks.BackColor = Color.DarkCyan;
            this.BackColor = Color.Silver;
            this.lblAuthor.ForeColor = Color.Black;
            this.lblAutorSearch.ForeColor = Color.Black;
            this.lblAvailability.ForeColor = Color.Black;
            this.lblAvailabilitySearch.ForeColor = Color.Black;
            this.lblBooks.ForeColor = Color.Black;
            this.lblGenre.ForeColor = Color.Black;
            this.lblGenreSearch.ForeColor = Color.Black;
            this.lblInfo.ForeColor = Color.Black;
            this.lblName.ForeColor = Color.Black;
            this.lblNameSearch.ForeColor = Color.Black;
            this.lblPublisher.ForeColor = Color.Black;
            this.lblQuantity.ForeColor = Color.Black;
            this.lblSearch.ForeColor = Color.Black;
        }

        public void setTheme2BooksStage()
        {
            this.panelHeaderBooks.BackColor = Color.FromArgb(76, 77, 108);
            this.BackColor = Color.FromArgb(43, 45, 61);
            this.lblAuthor.ForeColor = Color.White;
            this.lblAutorSearch.ForeColor = Color.White;
            this.lblAvailability.ForeColor = Color.White; ;
            this.lblAvailabilitySearch.ForeColor = Color.White;
            this.lblBooks.ForeColor = Color.White;
            this.lblGenre.ForeColor = Color.White;
            this.lblGenreSearch.ForeColor = Color.White;
            this.lblInfo.ForeColor = Color.White;
            this.lblName.ForeColor = Color.White;
            this.lblNameSearch.ForeColor = Color.White;
            this.lblPublisher.ForeColor = Color.White;
            this.lblQuantity.ForeColor = Color.White;
            this.lblSearch.ForeColor = Color.White;
        }

        private void adjustMaskedTextBoxes()
        {
            this.maskedTxtBoxPrice.Mask = "0000";
            this.maskedTxtBoxQuantity.Mask = "00000";
        }

        private void adjustDataGrid()
        {
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.MultiSelect = false;
        }

        private void adjustComboBoxes()
        {
            String[] itemsGenre = {"Psychology", "Philosophy", "Business / Entrepreneurship", "Science", "History",
                                   "Self-help", "Biography", "Horror", "Thriller / Suspense", "Romance", "Fantasy",
                                   "Science Fiction", "Mystery", "Non-fiction", "Fiction"};

            String[] itemsAvailability = { "Available", "Not available" };

            this.cBoxGenres.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cBoxAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cBoxGenresSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cBoxAvailabilitySearch.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cBoxGenres.Items.AddRange(itemsGenre);
            this.cBoxGenresSearch.Items.AddRange(itemsGenre);
            this.cBoxGenresSearch.Items.Add("All genres");

            this.cBoxAvailability.Items.AddRange(itemsAvailability);
            this.cBoxAvailabilitySearch.Items.AddRange(itemsAvailability);

            this.cBoxGenres.SelectedIndex = 0;
            this.cBoxAvailability.SelectedIndex = 0;
            this.cBoxAvailabilitySearch.SelectedIndex = 0;
            this.cBoxGenresSearch.SelectedIndex = 0;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainStage mainStage = MainStage.getInstance();
            this.Hide();
            mainStage.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String priceToCheck = this.maskedTxtBoxPrice.Text;
            String quantityToCheck = this.maskedTxtBoxQuantity.Text;

            if (string.IsNullOrWhiteSpace(priceToCheck) || priceToCheck.Contains(" "))
                MessageBox.Show("Please enter the correct price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(string.IsNullOrWhiteSpace(quantityToCheck) || quantityToCheck.Contains(" "))
                MessageBox.Show("Please enter the correct quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                String name = this.txtBoxName.Text;
                String author = this.txtBoxAuthor.Text;
                String publisher = this.txtBoxPublisher.Text;
                String genre = this.cBoxGenres.Text;
                int quantity = int.Parse(this.maskedTxtBoxQuantity.Text);
                String availability = this.cBoxAvailability.Text;
                int price = int.Parse(this.maskedTxtBoxPrice.Text);

                try
                {
                    StreamWriter booksFile = File.AppendText(fileName);
                    booksFile.WriteLine(name + "," + author + "," + publisher + "," + genre + "," + quantity + "," + availability + "," + price);
                    booksFile.Close();

                    loadTxtFile(fileName);
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvBooks.SelectedRows[0];

            String name = selectedRow.Cells["Name"].Value.ToString();
            String author = selectedRow.Cells["Author"].Value.ToString();
            String publisher = selectedRow.Cells["Publisher"].Value.ToString();
 
            try
            {
                String[] lines = File.ReadAllLines(fileName);
                List<String> newLines = new List<String>();

                for(int i = 0; i < lines.Length; i++)
                {
                    String[] elements = lines[i].Split(',');

                    if (!(name.Equals(elements[0]) && author.Equals(elements[1]) && publisher.Equals(elements[2])))
                        newLines.Add(lines[i]);

                }

                File.WriteAllLines(fileName, newLines);
                loadTxtFile(fileName);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            this.txtBoxAuthor.Text = "";
            this.txtBoxName.Text = "";
            this.txtBoxPublisher.Text = "";
            this.maskedTxtBoxQuantity.Text = "";
            this.maskedTxtBoxPrice.Text = "";
            this.cBoxAvailability.SelectedIndex = 0;
            this.cBoxGenres.SelectedIndex = 0;
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvBooks.Rows[e.RowIndex];
                this.txtBoxName.Text = row.Cells["Name"].Value.ToString();
                this.txtBoxAuthor.Text = row.Cells["Author"].Value.ToString();
                this.txtBoxPublisher.Text = row.Cells["Publisher"].Value.ToString();
                this.maskedTxtBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                this.cBoxGenres.Text = row.Cells["Genre"].Value.ToString();
                this.maskedTxtBoxPrice.Text = row.Cells["Price ($)"].Value.ToString();
                this.cBoxAvailability.Text = row.Cells["Availability"].Value.ToString();
            }
        }

        private void searchOption1(String genreToFind, String availabilityToFind)
        {
            String[] lines = File.ReadAllLines(fileName);
            List<String> newLines = new List<String>();

            if (genreToFind.Equals("All genres"))
            {
                for(int i = 0; i < lines.Length; i++)
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
            loadTxtFile(fileName2);
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
            loadTxtFile(fileName2);
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
            loadTxtFile(fileName2);
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
            loadTxtFile(fileName2);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String nameToFind = this.txtBoxNameSearch.Text;
            String authorToFind = this.txtBoxAuthorSearch.Text;
            String genreToFind = this.cBoxGenresSearch.Text;
            String availabilityToFind = this.cBoxAvailabilitySearch.Text;

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
            this.txtBoxNameSearch.Text = "";
            this.txtBoxAuthorSearch.Text = "";
            this.cBoxGenresSearch.SelectedIndex = 0;
            this.cBoxGenresSearch.SelectedIndex = 0;
            loadTxtFile(fileName);
        }

        public static BooksStage getInstance()
        {
            if (instance == null)
                instance = new BooksStage();

            return instance;
        }

        private void BooksStage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
