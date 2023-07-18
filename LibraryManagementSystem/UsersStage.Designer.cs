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
            this.panelHeaderUsers = new System.Windows.Forms.Panel();
            this.btnBackU = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.comboBoxGenderU = new System.Windows.Forms.ComboBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.panelHeaderUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderUsers
            // 
            this.panelHeaderUsers.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderUsers.Controls.Add(this.btnBackU);
            this.panelHeaderUsers.Controls.Add(this.lblUsers);
            this.panelHeaderUsers.Controls.Add(this.pictureBox1);
            this.panelHeaderUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderUsers.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderUsers.Name = "panelHeaderUsers";
            this.panelHeaderUsers.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderUsers.TabIndex = 0;
            // 
            // btnBackU
            // 
            this.btnBackU.Location = new System.Drawing.Point(12, 12);
            this.btnBackU.Name = "btnBackU";
            this.btnBackU.Size = new System.Drawing.Size(70, 25);
            this.btnBackU.TabIndex = 2;
            this.btnBackU.Text = "Back";
            this.btnBackU.UseVisualStyleBackColor = true;
            this.btnBackU.Click += new System.EventHandler(this.btnBackU_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.User32px;
            this.pictureBox1.Location = new System.Drawing.Point(484, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // txtBoxFirstNameU
            // 
            this.txtBoxFirstNameU.Location = new System.Drawing.Point(131, 129);
            this.txtBoxFirstNameU.Name = "txtBoxFirstNameU";
            this.txtBoxFirstNameU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxFirstNameU.TabIndex = 2;
            // 
            // txtBoxLastNameU
            // 
            this.txtBoxLastNameU.Location = new System.Drawing.Point(131, 170);
            this.txtBoxLastNameU.Name = "txtBoxLastNameU";
            this.txtBoxLastNameU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxLastNameU.TabIndex = 3;
            // 
            // lblFirstNameU
            // 
            this.lblFirstNameU.AutoSize = true;
            this.lblFirstNameU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameU.Location = new System.Drawing.Point(23, 131);
            this.lblFirstNameU.Name = "lblFirstNameU";
            this.lblFirstNameU.Size = new System.Drawing.Size(79, 18);
            this.lblFirstNameU.TabIndex = 5;
            this.lblFirstNameU.Text = "First Name";
            // 
            // lblLastNameU
            // 
            this.lblLastNameU.AutoSize = true;
            this.lblLastNameU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameU.Location = new System.Drawing.Point(23, 170);
            this.lblLastNameU.Name = "lblLastNameU";
            this.lblLastNameU.Size = new System.Drawing.Size(76, 18);
            this.lblLastNameU.TabIndex = 6;
            this.lblLastNameU.Text = "Last Name";
            // 
            // lblGenderU
            // 
            this.lblGenderU.AutoSize = true;
            this.lblGenderU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderU.Location = new System.Drawing.Point(23, 210);
            this.lblGenderU.Name = "lblGenderU";
            this.lblGenderU.Size = new System.Drawing.Size(57, 18);
            this.lblGenderU.TabIndex = 7;
            this.lblGenderU.Text = "Gender";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(23, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 18);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtBoxPasswordU
            // 
            this.txtBoxPasswordU.Location = new System.Drawing.Point(131, 293);
            this.txtBoxPasswordU.Name = "txtBoxPasswordU";
            this.txtBoxPasswordU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPasswordU.TabIndex = 9;
            // 
            // txtBoxEmailU
            // 
            this.txtBoxEmailU.Location = new System.Drawing.Point(131, 252);
            this.txtBoxEmailU.Name = "txtBoxEmailU";
            this.txtBoxEmailU.Size = new System.Drawing.Size(156, 20);
            this.txtBoxEmailU.TabIndex = 10;
            // 
            // lblEmailU
            // 
            this.lblEmailU.AutoSize = true;
            this.lblEmailU.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailU.Location = new System.Drawing.Point(23, 252);
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
            this.btnUpdateUser.Location = new System.Drawing.Point(26, 341);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(122, 33);
            this.btnUpdateUser.TabIndex = 13;
            this.btnUpdateUser.Text = "Update user";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // comboBoxGenderU
            // 
            this.comboBoxGenderU.FormattingEnabled = true;
            this.comboBoxGenderU.Location = new System.Drawing.Point(131, 210);
            this.comboBoxGenderU.Name = "comboBoxGenderU";
            this.comboBoxGenderU.Size = new System.Drawing.Size(156, 21);
            this.comboBoxGenderU.TabIndex = 16;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(165, 341);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(122, 33);
            this.btnClearFields.TabIndex = 18;
            this.btnClearFields.Text = "Clear fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // UsersStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.comboBoxGenderU);
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
            this.Controls.Add(this.panelHeaderUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsersStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Users";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsersStage_FormClosing);
            this.Load += new System.EventHandler(this.UsersStage_Load);
            this.panelHeaderUsers.ResumeLayout(false);
            this.panelHeaderUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderUsers;
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
        private System.Windows.Forms.ComboBox comboBoxGenderU;
        private System.Windows.Forms.Button btnClearFields;
    }
}