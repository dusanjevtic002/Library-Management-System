using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BooksStage : Form
    {
        private static BooksStage instance;
        private static int counter = 1;
        private BooksStage()
        {
            InitializeComponent();
            adjustComboBoxes();
            adjustDataGrid();
            adjustTxtBox();
            loadDataBase();
            adjustMaskedTextBoxes();
        }

        private void loadDataBase()
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT * FROM LBAllBooks", con);

                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;

                DataTable dbDataSet = new DataTable();
                sda.Fill(dbDataSet);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbDataSet;
                this.dgvBooks.DataSource = dbDataSet;
                sda.Update(dbDataSet);
                this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            this.lblID.ForeColor = Color.Black;
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
            this.lblID.ForeColor = Color.White;
            this.lblInfo.ForeColor = Color.White;
            this.lblName.ForeColor = Color.White;
            this.lblNameSearch.ForeColor = Color.White;
            this.lblPublisher.ForeColor = Color.White;
            this.lblQuantity.ForeColor = Color.White;
            this.lblSearch.ForeColor = Color.White;
        }

        private void adjustTxtBox()
        {
            this.txtBoxBookID.Enabled = false;
            this.txtBoxBookID.ReadOnly = true;
        }

        private void adjustMaskedTextBoxes()
        {
            this.maskedTxtBoxPrice.Mask = "0000";
            this.maskedTxtBoxQuantity.Mask = "00000";
        }

        private void adjustDataGrid()
        {
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void adjustCounter()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            //Query ce proci kroz bazu i vratice najveci id knjige
            string query = "SELECT MAX(Id) FROM LBAllBooks";
            SqlCommand command = new SqlCommand(query, con);

            //Izvrsava se komanda nad LBAllBooks i vraca se prva kolona rezultata, u toj prvoj koloni je moj rezultat
            //Result je tipa object jer povratna vrednost moze biti NULL
            object result = command.ExecuteScalar();

            if (result != DBNull.Value)
                counter = Convert.ToInt32(result) + 1;

            else
                counter = 1;
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
                adjustCounter();

                String name = this.txtBoxName.Text;
                String author = this.txtBoxAuthor.Text;
                String publisher = this.txtBoxPublisher.Text;
                String genre = this.cBoxGenres.Text;
                int quantity = int.Parse(this.maskedTxtBoxQuantity.Text);
                String availability = this.cBoxAvailability.Text;
                int price = int.Parse(this.maskedTxtBoxPrice.Text);

                try
                {
                    String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString; ;
                    String insertSQL = "INSERT INTO LBAllBooks (Id, Name, Author, Publisher, Genre, Quantity, Availability, Price) VALUES (@Id, @Name, @Author, @Publisher, @Genre, @Quantity, @Availability, @Price)";

                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(insertSQL, con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@Id", counter++);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Publisher", publisher);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Availability", availability);
                    cmd.Parameters.AddWithValue("@Price", price);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have added book successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataBase();
                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString;
                string deleteQuery = "DELETE FROM LBAllBooks WHERE Id = @Id";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@Id", this.txtBoxBookID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("You have removed this book successfully");
                loadDataBase();

                this.txtBoxBookID.Text = "";
                this.txtBoxAuthor.Text = "";
                this.txtBoxName.Text = "";
                this.txtBoxPublisher.Text = "";
                this.maskedTxtBoxQuantity.Text = "";
                this.maskedTxtBoxPrice.Text = "";
                this.cBoxAvailability.SelectedIndex = 0;
                this.cBoxGenres.SelectedIndex = 0;
                loadDataBase();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            this.txtBoxBookID.Text = "";
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
                this.txtBoxBookID.Text = row.Cells["Id"].Value.ToString();
                this.txtBoxName.Text = row.Cells["Name"].Value.ToString();
                this.txtBoxAuthor.Text = row.Cells["Author"].Value.ToString();
                this.txtBoxPublisher.Text = row.Cells["Publisher"].Value.ToString();
                this.maskedTxtBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                this.cBoxGenres.Text = row.Cells["Genre"].Value.ToString();
                this.maskedTxtBoxPrice.Text = row.Cells["Price"].Value.ToString();
                this.cBoxAvailability.Text = row.Cells["Availability"].Value.ToString();
            }
        }

        private void executeSearchOption(String connectionString, String query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;

            DataTable dbDataSet = new DataTable();
            sda.Fill(dbDataSet);

            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbDataSet;
            this.dgvBooks.DataSource = dbDataSet;
            sda.Update(dbDataSet);
        }

        private void searchOption1(String genreToFind, String availabilityToFind)
        {
            String query = null;
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString; ;

            if (genreToFind.Equals("All genres"))
               query = "SELECT * FROM LBAllBooks WHERE Availability = '" + availabilityToFind + "'";

            else
               query = "SELECT * FROM LBAllBooks WHERE Genre = '" + genreToFind + "'AND Availability = '" + availabilityToFind + "'";

            executeSearchOption(connectionString, query);
        }

        private void searchOption2(String nameToFind, String genreToFind, String availabilityToFind)
        {
            String query = null;
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString; ;

            if (genreToFind.Equals("All genres"))//Like % text % mi omogucava parcijalno podudaranje rezultata
                query = "SELECT * FROM LBAllBooks WHERE Name LIKE '%" + nameToFind +  "%' AND Availability = '" + availabilityToFind + "'";

            else
                query = "SELECT * FROM LBAllBooks WHERE Name LIKE '%" + nameToFind + "%' AND Genre = '" + genreToFind + "'AND Availability = '" + availabilityToFind + "'";

            executeSearchOption(connectionString, query);
        }

        private void searchOption3(String authorToFind, String genreToFind, String availabilityToFind)
        {
            String query = null;
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString; ;

            if (genreToFind.Equals("All genres"))
                query = "SELECT * FROM LBAllBooks WHERE Author LIKE '%" + authorToFind + "%' AND Availability = '" + availabilityToFind + "'";

            else
                query = "SELECT * FROM LBAllBooks WHERE Author LIKE '%" + authorToFind + "%' AND Genre = '" + genreToFind + "'AND Availability = '" + availabilityToFind + "'";

            executeSearchOption(connectionString, query);
        }

        private void searchOption4(String nameToFind, String authorToFind, String genreToFind, String availabilityToFind)
        {
            String query = null;
            String connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.LocalDataBaseAllBooksConnectionString"].ConnectionString; ;

            if (genreToFind.Equals("All genres"))
                query = "SELECT * FROM LBAllBooks WHERE Name LIKE '%" + nameToFind + "%' AND Author LIKE '%" + authorToFind + "%' AND Availability = '" + availabilityToFind + "'";

            else
                query = "SELECT * FROM LBAllBooks WHERE Name LIKE '%" + nameToFind + "%' AND Author LIKE '%" + authorToFind + "%' AND Genre = '" + genreToFind + "'AND Availability = '" + availabilityToFind + "'";

            executeSearchOption(connectionString, query);
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
            loadDataBase();
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
