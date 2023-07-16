namespace LibraryManagementSystem
{
    partial class BorrowerInfoStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowerInfoStage));
            this.panelHeaderBorrower = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBorrowerInfo = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.panelHeaderBorrower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderBorrower
            // 
            this.panelHeaderBorrower.BackColor = System.Drawing.Color.White;
            this.panelHeaderBorrower.Controls.Add(this.pictureBox1);
            this.panelHeaderBorrower.Controls.Add(this.lblBorrowerInfo);
            this.panelHeaderBorrower.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBorrower.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBorrower.Name = "panelHeaderBorrower";
            this.panelHeaderBorrower.Size = new System.Drawing.Size(784, 60);
            this.panelHeaderBorrower.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.information_button;
            this.pictureBox1.Location = new System.Drawing.Point(278, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBorrowerInfo
            // 
            this.lblBorrowerInfo.AutoSize = true;
            this.lblBorrowerInfo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerInfo.Location = new System.Drawing.Point(315, 13);
            this.lblBorrowerInfo.Name = "lblBorrowerInfo";
            this.lblBorrowerInfo.Size = new System.Drawing.Size(155, 29);
            this.lblBorrowerInfo.TabIndex = 1;
            this.lblBorrowerInfo.Text = "Borrower info";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(217, 101);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(226, 18);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact (email or phone number)";
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Location = new System.Drawing.Point(220, 122);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(295, 20);
            this.txtBoxContact.TabIndex = 2;
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(220, 191);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(295, 20);
            this.dtpBorrowDate.TabIndex = 3;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDate.Location = new System.Drawing.Point(217, 170);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(89, 18);
            this.lblBorrowDate.TabIndex = 4;
            this.lblBorrowDate.Text = "Borrow date";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(220, 270);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(295, 20);
            this.dtpReturnDate.TabIndex = 5;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(217, 249);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(84, 18);
            this.lblReturnDate.TabIndex = 6;
            this.lblReturnDate.Text = "Return date";
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.Location = new System.Drawing.Point(307, 340);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(113, 36);
            this.btnBorrowBook.TabIndex = 7;
            this.btnBorrowBook.Text = "Borrow book";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // BorrowerInfoStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.txtBoxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.panelHeaderBorrower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BorrowerInfoStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Transactions";
            this.panelHeaderBorrower.ResumeLayout(false);
            this.panelHeaderBorrower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBorrower;
        private System.Windows.Forms.Label lblBorrowerInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnBorrowBook;
    }
}