namespace LibraryManagementSystem
{
    partial class BooksStage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksStage));
            this.panelHeaderBooks = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBooks = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cBoxGenres = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBoxAvailability = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.txtBoxNameSearch = new System.Windows.Forms.TextBox();
            this.txtBoxAuthorSearch = new System.Windows.Forms.TextBox();
            this.lblAutorSearch = new System.Windows.Forms.Label();
            this.cBoxGenresSearch = new System.Windows.Forms.ComboBox();
            this.lblGenreSearch = new System.Windows.Forms.Label();
            this.cBoxAvailabilitySearch = new System.Windows.Forms.ComboBox();
            this.lblAvailabilitySearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.maskedTxtBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtBoxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.panelHeaderBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderBooks
            // 
            this.panelHeaderBooks.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderBooks.Controls.Add(this.pictureBox1);
            this.panelHeaderBooks.Controls.Add(this.lblBooks);
            this.panelHeaderBooks.Controls.Add(this.btnBack);
            this.panelHeaderBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBooks.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBooks.Name = "panelHeaderBooks";
            this.panelHeaderBooks.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderBooks.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.OpenBook32px;
            this.pictureBox1.Location = new System.Drawing.Point(470, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.Location = new System.Drawing.Point(518, 15);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(76, 29);
            this.lblBooks.TabIndex = 1;
            this.lblBooks.Text = "Books";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(461, 306);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(698, 375);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(69, 138);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(72, 159);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(276, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(69, 204);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(72, 225);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(276, 20);
            this.txtBoxAuthor.TabIndex = 5;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(69, 270);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(69, 18);
            this.lblPublisher.TabIndex = 6;
            this.lblPublisher.Text = "Publisher";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(72, 291);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(276, 20);
            this.txtBoxPublisher.TabIndex = 7;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(69, 339);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(49, 18);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre";
            // 
            // cBoxGenres
            // 
            this.cBoxGenres.FormattingEnabled = true;
            this.cBoxGenres.Location = new System.Drawing.Point(72, 360);
            this.cBoxGenres.Name = "cBoxGenres";
            this.cBoxGenres.Size = new System.Drawing.Size(276, 21);
            this.cBoxGenres.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(69, 408);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 18);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(69, 475);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(74, 18);
            this.lblAvailability.TabIndex = 12;
            this.lblAvailability.Text = "Availability";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(41, 644);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 37);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cBoxAvailability
            // 
            this.cBoxAvailability.FormattingEnabled = true;
            this.cBoxAvailability.Location = new System.Drawing.Point(72, 496);
            this.cBoxAvailability.Name = "cBoxAvailability";
            this.cBoxAvailability.Size = new System.Drawing.Size(276, 21);
            this.cBoxAvailability.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(158, 644);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(67, 84);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(319, 25);
            this.lblInfo.TabIndex = 19;
            this.lblInfo.Text = "Click on any row to fill text fields";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(510, 84);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(133, 25);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search book";
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.Location = new System.Drawing.Point(512, 138);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(48, 18);
            this.lblNameSearch.TabIndex = 21;
            this.lblNameSearch.Text = "Name";
            // 
            // txtBoxNameSearch
            // 
            this.txtBoxNameSearch.Location = new System.Drawing.Point(515, 159);
            this.txtBoxNameSearch.Name = "txtBoxNameSearch";
            this.txtBoxNameSearch.Size = new System.Drawing.Size(276, 20);
            this.txtBoxNameSearch.TabIndex = 22;
            // 
            // txtBoxAuthorSearch
            // 
            this.txtBoxAuthorSearch.Location = new System.Drawing.Point(837, 159);
            this.txtBoxAuthorSearch.Name = "txtBoxAuthorSearch";
            this.txtBoxAuthorSearch.Size = new System.Drawing.Size(276, 20);
            this.txtBoxAuthorSearch.TabIndex = 23;
            // 
            // lblAutorSearch
            // 
            this.lblAutorSearch.AutoSize = true;
            this.lblAutorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorSearch.Location = new System.Drawing.Point(834, 138);
            this.lblAutorSearch.Name = "lblAutorSearch";
            this.lblAutorSearch.Size = new System.Drawing.Size(51, 18);
            this.lblAutorSearch.TabIndex = 24;
            this.lblAutorSearch.Text = "Author";
            // 
            // cBoxGenresSearch
            // 
            this.cBoxGenresSearch.FormattingEnabled = true;
            this.cBoxGenresSearch.Location = new System.Drawing.Point(515, 218);
            this.cBoxGenresSearch.Name = "cBoxGenresSearch";
            this.cBoxGenresSearch.Size = new System.Drawing.Size(276, 21);
            this.cBoxGenresSearch.TabIndex = 25;
            // 
            // lblGenreSearch
            // 
            this.lblGenreSearch.AutoSize = true;
            this.lblGenreSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreSearch.Location = new System.Drawing.Point(512, 197);
            this.lblGenreSearch.Name = "lblGenreSearch";
            this.lblGenreSearch.Size = new System.Drawing.Size(49, 18);
            this.lblGenreSearch.TabIndex = 26;
            this.lblGenreSearch.Text = "Genre";
            // 
            // cBoxAvailabilitySearch
            // 
            this.cBoxAvailabilitySearch.FormattingEnabled = true;
            this.cBoxAvailabilitySearch.Location = new System.Drawing.Point(837, 218);
            this.cBoxAvailabilitySearch.Name = "cBoxAvailabilitySearch";
            this.cBoxAvailabilitySearch.Size = new System.Drawing.Size(276, 21);
            this.cBoxAvailabilitySearch.TabIndex = 27;
            // 
            // lblAvailabilitySearch
            // 
            this.lblAvailabilitySearch.AutoSize = true;
            this.lblAvailabilitySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilitySearch.Location = new System.Drawing.Point(834, 197);
            this.lblAvailabilitySearch.Name = "lblAvailabilitySearch";
            this.lblAvailabilitySearch.Size = new System.Drawing.Size(74, 18);
            this.lblAvailabilitySearch.TabIndex = 28;
            this.lblAvailabilitySearch.Text = "Availability";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(665, 253);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 37);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.Location = new System.Drawing.Point(817, 253);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(142, 37);
            this.btnClearFilters.TabIndex = 30;
            this.btnClearFilters.Text = "Clear filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(275, 644);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(111, 37);
            this.btnClearFields.TabIndex = 31;
            this.btnClearFields.Text = "Clear fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(69, 539);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Price";
            // 
            // maskedTxtBoxPrice
            // 
            this.maskedTxtBoxPrice.Location = new System.Drawing.Point(72, 560);
            this.maskedTxtBoxPrice.Name = "maskedTxtBoxPrice";
            this.maskedTxtBoxPrice.Size = new System.Drawing.Size(276, 20);
            this.maskedTxtBoxPrice.TabIndex = 34;
            // 
            // maskedTxtBoxQuantity
            // 
            this.maskedTxtBoxQuantity.Location = new System.Drawing.Point(72, 429);
            this.maskedTxtBoxQuantity.Name = "maskedTxtBoxQuantity";
            this.maskedTxtBoxQuantity.Size = new System.Drawing.Size(276, 20);
            this.maskedTxtBoxQuantity.TabIndex = 35;
            // 
            // BooksStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.maskedTxtBoxQuantity);
            this.Controls.Add(this.maskedTxtBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAvailabilitySearch);
            this.Controls.Add(this.cBoxAvailabilitySearch);
            this.Controls.Add(this.lblGenreSearch);
            this.Controls.Add(this.cBoxGenresSearch);
            this.Controls.Add(this.lblAutorSearch);
            this.Controls.Add(this.txtBoxAuthorSearch);
            this.Controls.Add(this.txtBoxNameSearch);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cBoxAvailability);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cBoxGenres);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.panelHeaderBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BooksStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Books";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BooksStage_FormClosing);
            this.panelHeaderBooks.ResumeLayout(false);
            this.panelHeaderBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBooks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cBoxGenres;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cBoxAvailability;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox txtBoxNameSearch;
        private System.Windows.Forms.TextBox txtBoxAuthorSearch;
        private System.Windows.Forms.Label lblAutorSearch;
        private System.Windows.Forms.ComboBox cBoxGenresSearch;
        private System.Windows.Forms.Label lblGenreSearch;
        private System.Windows.Forms.ComboBox cBoxAvailabilitySearch;
        private System.Windows.Forms.Label lblAvailabilitySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxPrice;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxQuantity;
    }
}