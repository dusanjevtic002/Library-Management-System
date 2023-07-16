namespace LibraryManagementSystem
{
    partial class TransactionsStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsStage));
            this.panelHeaderTransactions = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnReturnToLibrary = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cBoxGenres = new System.Windows.Forms.ComboBox();
            this.cBoxAvailability = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeaderTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderTransactions
            // 
            this.panelHeaderTransactions.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderTransactions.Controls.Add(this.btnBack);
            this.panelHeaderTransactions.Controls.Add(this.lblTransactions);
            this.panelHeaderTransactions.Controls.Add(this.pictureBox1);
            this.panelHeaderTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderTransactions.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderTransactions.Name = "panelHeaderTransactions";
            this.panelHeaderTransactions.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderTransactions.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(518, 15);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(147, 29);
            this.lblTransactions.TabIndex = 1;
            this.lblTransactions.Text = "Transactions";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 277);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(568, 366);
            this.dgvBooks.TabIndex = 1;
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.AllowUserToDeleteRows = false;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(604, 277);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.ReadOnly = true;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(568, 366);
            this.dgvBorrowedBooks.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(7, 71);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(123, 25);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search book";
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedBooks.Location = new System.Drawing.Point(805, 238);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(153, 25);
            this.lblBorrowedBooks.TabIndex = 4;
            this.lblBorrowedBooks.Text = "Borrowed books";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(1105, 78);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(16, 16);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(152, 662);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(142, 37);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.Location = new System.Drawing.Point(300, 662);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(142, 37);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "Borrow book";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnToLibrary
            // 
            this.btnReturnToLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToLibrary.Location = new System.Drawing.Point(795, 662);
            this.btnReturnToLibrary.Name = "btnReturnToLibrary";
            this.btnReturnToLibrary.Size = new System.Drawing.Size(190, 37);
            this.btnReturnToLibrary.TabIndex = 9;
            this.btnReturnToLibrary.Text = "Return book to library";
            this.btnReturnToLibrary.UseVisualStyleBackColor = true;
            this.btnReturnToLibrary.Click += new System.EventHandler(this.btnReturnToLibrary_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(12, 137);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(276, 20);
            this.txtBoxName.TabIndex = 10;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(305, 137);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(275, 20);
            this.txtBoxAuthor.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(302, 116);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblAuthor.TabIndex = 13;
            this.lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(12, 168);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(49, 18);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Genre";
            // 
            // cBoxGenres
            // 
            this.cBoxGenres.FormattingEnabled = true;
            this.cBoxGenres.Location = new System.Drawing.Point(12, 189);
            this.cBoxGenres.Name = "cBoxGenres";
            this.cBoxGenres.Size = new System.Drawing.Size(276, 21);
            this.cBoxGenres.TabIndex = 16;
            // 
            // cBoxAvailability
            // 
            this.cBoxAvailability.FormattingEnabled = true;
            this.cBoxAvailability.Location = new System.Drawing.Point(305, 188);
            this.cBoxAvailability.Name = "cBoxAvailability";
            this.cBoxAvailability.Size = new System.Drawing.Size(275, 21);
            this.cBoxAvailability.TabIndex = 17;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(302, 168);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(74, 18);
            this.lblAvailability.TabIndex = 18;
            this.lblAvailability.Text = "Availability";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(152, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 37);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilters.Location = new System.Drawing.Point(300, 226);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(142, 37);
            this.btnClearFilters.TabIndex = 20;
            this.btnClearFilters.Text = "Clear filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.Image = global::LibraryManagementSystem.Properties.Resources.grocery_store__1_;
            this.cartBtn.Location = new System.Drawing.Point(1047, 78);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(51, 50);
            this.cartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartBtn.TabIndex = 5;
            this.cartBtn.TabStop = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.transaction__2_;
            this.pictureBox1.Location = new System.Drawing.Point(461, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TransactionsStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnClearFilters);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.cBoxAvailability);
            this.Controls.Add(this.cBoxGenres);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnReturnToLibrary);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.lblBorrowedBooks);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.panelHeaderTransactions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TransactionsStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionsStage_FormClosing);
            this.panelHeaderTransactions.ResumeLayout(false);
            this.panelHeaderTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderTransactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.PictureBox cartBtn;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnReturnToLibrary;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cBoxGenres;
        private System.Windows.Forms.ComboBox cBoxAvailability;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearFilters;
    }
}