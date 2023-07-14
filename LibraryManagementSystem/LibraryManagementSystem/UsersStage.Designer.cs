namespace LibraryManagementSystem
{
    partial class UsersStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersStage));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnBackU = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.txtBoxFirstNameU = new System.Windows.Forms.TextBox();
            this.txtBoxLastNameU = new System.Windows.Forms.TextBox();
            this.lblFirstNameU = new System.Windows.Forms.Label();
            this.lblLastNameU = new System.Windows.Forms.Label();
            this.lblGenderU = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxPasswordU = new System.Windows.Forms.TextBox();
            this.txtBoxEmailU = new System.Windows.Forms.TextBox();
            this.lblEmailU = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.txtBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.comboBoxGenderU = new System.Windows.Forms.ComboBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.btnBackU);
            this.headerPanel.Controls.Add(this.lblUsers);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1184, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.User32px;
            this.pictureBox1.Location = new System.Drawing.Point(484, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(525, 15);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(209, 29);
            this.lblUsers.TabIndex = 1;
            this.lblUsers.Text = "Users (Employees)";
            // 
            // btnBackU
            // 
            this.btnBackU.Location = new System.Drawing.Point(12, 12);
            this.btnBackU.Name = "btnBackU";
            this.btnBackU.Size = new System.Drawing.Size(72, 25);
            this.btnBackU.TabIndex = 2;
            this.btnBackU.Text = "Back";
            this.btnBackU.UseVisualStyleBackColor = true;
            this.btnBackU.Click += new System.EventHandler(this.btnBackU_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(336, 131);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(784, 466);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // txtBoxFirstNameU
            // 
            this.txtBoxFirstNameU.Location = new System.Drawing.Point(127, 171);
            this.txtBoxFirstNameU.Name = "txtBoxFirstNameU";
            this.txtBoxFirstNameU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxFirstNameU.TabIndex = 2;
            // 
            // txtBoxLastNameU
            // 
            this.txtBoxLastNameU.Location = new System.Drawing.Point(127, 212);
            this.txtBoxLastNameU.Name = "txtBoxLastNameU";
            this.txtBoxLastNameU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxLastNameU.TabIndex = 3;
            // 
            // lblFirstNameU
            // 
            this.lblFirstNameU.AutoSize = true;
            this.lblFirstNameU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameU.Location = new System.Drawing.Point(19, 173);
            this.lblFirstNameU.Name = "lblFirstNameU";
            this.lblFirstNameU.Size = new System.Drawing.Size(79, 18);
            this.lblFirstNameU.TabIndex = 5;
            this.lblFirstNameU.Text = "First Name";
            // 
            // lblLastNameU
            // 
            this.lblLastNameU.AutoSize = true;
            this.lblLastNameU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameU.Location = new System.Drawing.Point(19, 212);
            this.lblLastNameU.Name = "lblLastNameU";
            this.lblLastNameU.Size = new System.Drawing.Size(76, 18);
            this.lblLastNameU.TabIndex = 6;
            this.lblLastNameU.Text = "Last Name";
            // 
            // lblGenderU
            // 
            this.lblGenderU.AutoSize = true;
            this.lblGenderU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderU.Location = new System.Drawing.Point(19, 252);
            this.lblGenderU.Name = "lblGenderU";
            this.lblGenderU.Size = new System.Drawing.Size(57, 18);
            this.lblGenderU.TabIndex = 7;
            this.lblGenderU.Text = "Gender";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(19, 335);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 18);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPasswordU
            // 
            this.txtBoxPasswordU.Location = new System.Drawing.Point(127, 335);
            this.txtBoxPasswordU.Name = "txtBoxPasswordU";
            this.txtBoxPasswordU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPasswordU.TabIndex = 9;
            // 
            // txtBoxEmailU
            // 
            this.txtBoxEmailU.Location = new System.Drawing.Point(127, 294);
            this.txtBoxEmailU.Name = "txtBoxEmailU";
            this.txtBoxEmailU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxEmailU.TabIndex = 10;
            // 
            // lblEmailU
            // 
            this.lblEmailU.AutoSize = true;
            this.lblEmailU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailU.Location = new System.Drawing.Point(19, 294);
            this.lblEmailU.Name = "lblEmailU";
            this.lblEmailU.Size = new System.Drawing.Size(45, 18);
            this.lblEmailU.TabIndex = 11;
            this.lblEmailU.Text = "Email";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(563, 99);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(319, 25);
            this.lblInformation.TabIndex = 12;
            this.lblInformation.Text = "Click on any row to fill text fields";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Location = new System.Drawing.Point(90, 389);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(133, 33);
            this.btnUpdateUser.TabIndex = 13;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // txtBoxEmployeeID
            // 
            this.txtBoxEmployeeID.Location = new System.Drawing.Point(127, 131);
            this.txtBoxEmployeeID.Name = "txtBoxEmployeeID";
            this.txtBoxEmployeeID.Size = new System.Drawing.Size(156, 20);
            this.txtBoxEmployeeID.TabIndex = 14;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(19, 131);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(91, 18);
            this.lblEmployeeID.TabIndex = 15;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // comboBoxGenderU
            // 
            this.comboBoxGenderU.FormattingEnabled = true;
            this.comboBoxGenderU.Location = new System.Drawing.Point(127, 252);
            this.comboBoxGenderU.Name = "comboBoxGenderU";
            this.comboBoxGenderU.Size = new System.Drawing.Size(156, 21);
            this.comboBoxGenderU.TabIndex = 16;
            // 
            // UsersStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.comboBoxGenderU);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.txtBoxEmployeeID);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblEmailU);
            this.Controls.Add(this.txtBoxEmailU);
            this.Controls.Add(this.txtBoxPasswordU);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblGenderU);
            this.Controls.Add(this.lblLastNameU);
            this.Controls.Add(this.lblFirstNameU);
            this.Controls.Add(this.txtBoxLastNameU);
            this.Controls.Add(this.txtBoxFirstNameU);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsersStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersStage_FormClosing);
            this.Load += new System.EventHandler(this.UsersStage_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnBackU;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtBoxFirstNameU;
        private System.Windows.Forms.TextBox txtBoxLastNameU;
        private System.Windows.Forms.Label lblFirstNameU;
        private System.Windows.Forms.Label lblLastNameU;
        private System.Windows.Forms.Label lblGenderU;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxPasswordU;
        private System.Windows.Forms.TextBox txtBoxEmailU;
        private System.Windows.Forms.Label lblEmailU;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox txtBoxEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ComboBox comboBoxGenderU;
    }
}