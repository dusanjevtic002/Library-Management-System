namespace LibraryManagementSystem
{
    partial class MainStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStage));
            this.panelLeftDock = new System.Windows.Forms.Panel();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnFaqs = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblLMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelLeftDock.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftDock
            // 
            this.panelLeftDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.panelLeftDock.Controls.Add(this.btnBooks);
            this.panelLeftDock.Controls.Add(this.btnFaqs);
            this.panelLeftDock.Controls.Add(this.btnUsers);
            this.panelLeftDock.Controls.Add(this.btnSettings);
            this.panelLeftDock.Controls.Add(this.btnNotice);
            this.panelLeftDock.Controls.Add(this.btnTransactions);
            this.panelLeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftDock.Location = new System.Drawing.Point(0, 0);
            this.panelLeftDock.Name = "panelLeftDock";
            this.panelLeftDock.Size = new System.Drawing.Size(239, 711);
            this.panelLeftDock.TabIndex = 0;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.725F);
            this.btnBooks.Location = new System.Drawing.Point(0, 72);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(239, 51);
            this.btnBooks.TabIndex = 7;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnFaqs
            // 
            this.btnFaqs.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFaqs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnFaqs.Location = new System.Drawing.Point(0, 141);
            this.btnFaqs.Name = "btnFaqs";
            this.btnFaqs.Size = new System.Drawing.Size(239, 51);
            this.btnFaqs.TabIndex = 6;
            this.btnFaqs.Text = "Faqs";
            this.btnFaqs.UseVisualStyleBackColor = true;
            this.btnFaqs.Click += new System.EventHandler(this.btnFaqs_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnUsers.Location = new System.Drawing.Point(0, 422);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(239, 51);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSettings.Location = new System.Drawing.Point(0, 351);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(239, 51);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotice
            // 
            this.btnNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnNotice.Location = new System.Drawing.Point(0, 280);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(239, 51);
            this.btnNotice.TabIndex = 3;
            this.btnNotice.Text = "Notice";
            this.btnNotice.UseVisualStyleBackColor = true;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnTransactions.Location = new System.Drawing.Point(0, 210);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(239, 51);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeader.Controls.Add(this.lblLMS);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1185, 53);
            this.panelHeader.TabIndex = 2;
            // 
            // lblLMS
            // 
            this.lblLMS.AutoSize = true;
            this.lblLMS.Font = new System.Drawing.Font("Constantia", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLMS.Location = new System.Drawing.Point(51, 15);
            this.lblLMS.Name = "lblLMS";
            this.lblLMS.Size = new System.Drawing.Size(57, 27);
            this.lblLMS.TabIndex = 4;
            this.lblLMS.Text = "LMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.Books32px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(491, 71);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(152, 55);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "label1";
            // 
            // MainStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeftDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainStage_FormClosing);
            this.panelLeftDock.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftDock;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLMS;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnFaqs;
    }
}