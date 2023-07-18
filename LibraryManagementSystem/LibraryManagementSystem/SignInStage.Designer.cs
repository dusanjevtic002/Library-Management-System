using System.Drawing;
namespace LibraryManagementSystem
{
    partial class SignInStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInStage));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.linkLblSignUp = new System.Windows.Forms.LinkLabel();
            this.lblNewWorker = new System.Windows.Forms.Label();
            this.cBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.pBoxIconSignIn = new System.Windows.Forms.PictureBox();
            this.lblLibrarySystem = new System.Windows.Forms.Label();
            this.pBoxBackgroundSignIn = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIconSignIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBackgroundSignIn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.linkLblSignUp);
            this.panelBackground.Controls.Add(this.lblNewWorker);
            this.panelBackground.Controls.Add(this.cBoxShowPassword);
            this.panelBackground.Controls.Add(this.btnSignIn);
            this.panelBackground.Controls.Add(this.txtBoxPassword);
            this.panelBackground.Controls.Add(this.lblPassword);
            this.panelBackground.Controls.Add(this.lblUsername);
            this.panelBackground.Controls.Add(this.txtBoxEmail);
            this.panelBackground.Controls.Add(this.lblSignIn);
            this.panelBackground.Controls.Add(this.pBoxIconSignIn);
            this.panelBackground.Location = new System.Drawing.Point(298, 120);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(288, 316);
            this.panelBackground.TabIndex = 3;
            // 
            // linkLblSignUp
            // 
            this.linkLblSignUp.AutoSize = true;
            this.linkLblSignUp.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblSignUp.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLblSignUp.Location = new System.Drawing.Point(160, 279);
            this.linkLblSignUp.Name = "linkLblSignUp";
            this.linkLblSignUp.Size = new System.Drawing.Size(55, 24);
            this.linkLblSignUp.TabIndex = 10;
            this.linkLblSignUp.TabStop = true;
            this.linkLblSignUp.Text = "Sign up";
            this.linkLblSignUp.UseCompatibleTextRendering = true;
            this.linkLblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblSignUp_LinkClicked);
            // 
            // lblNewWorker
            // 
            this.lblNewWorker.AutoSize = true;
            this.lblNewWorker.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewWorker.Location = new System.Drawing.Point(66, 279);
            this.lblNewWorker.Name = "lblNewWorker";
            this.lblNewWorker.Size = new System.Drawing.Size(94, 18);
            this.lblNewWorker.TabIndex = 9;
            this.lblNewWorker.Text = "New worker?";
            // 
            // cBoxShowPassword
            // 
            this.cBoxShowPassword.AutoSize = true;
            this.cBoxShowPassword.Location = new System.Drawing.Point(68, 197);
            this.cBoxShowPassword.Name = "cBoxShowPassword";
            this.cBoxShowPassword.Size = new System.Drawing.Size(102, 17);
            this.cBoxShowPassword.TabIndex = 8;
            this.cBoxShowPassword.Text = "Show Password";
            this.cBoxShowPassword.UseVisualStyleBackColor = true;
            this.cBoxShowPassword.CheckedChanged += new System.EventHandler(this.cBoxShowPassword_CheckedChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(107, 232);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(68, 171);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(156, 20);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(65, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 18);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(65, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 18);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(68, 118);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(156, 20);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.Location = new System.Drawing.Point(107, 30);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(118, 37);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "SIGN IN";
            // 
            // pBoxIconSignIn
            // 
            this.pBoxIconSignIn.Image = global::LibraryManagementSystem.Properties.Resources.User32px;
            this.pBoxIconSignIn.Location = new System.Drawing.Point(69, 33);
            this.pBoxIconSignIn.Name = "pBoxIconSignIn";
            this.pBoxIconSignIn.Size = new System.Drawing.Size(32, 34);
            this.pBoxIconSignIn.TabIndex = 0;
            this.pBoxIconSignIn.TabStop = false;
            // 
            // lblLibrarySystem
            // 
            this.lblLibrarySystem.AutoSize = true;
            this.lblLibrarySystem.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrarySystem.Font = new System.Drawing.Font("Constantia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarySystem.ForeColor = System.Drawing.Color.White;
            this.lblLibrarySystem.Location = new System.Drawing.Point(334, 77);
            this.lblLibrarySystem.Name = "lblLibrarySystem";
            this.lblLibrarySystem.Size = new System.Drawing.Size(220, 36);
            this.lblLibrarySystem.TabIndex = 4;
            this.lblLibrarySystem.Text = "Library System";
            // 
            // pBoxBackgroundSignIn
            // 
            this.pBoxBackgroundSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBoxBackgroundSignIn.Image = global::LibraryManagementSystem.Properties.Resources.bacgrkoundLogInForm;
            this.pBoxBackgroundSignIn.Location = new System.Drawing.Point(0, 0);
            this.pBoxBackgroundSignIn.Name = "pBoxBackgroundSignIn";
            this.pBoxBackgroundSignIn.Size = new System.Drawing.Size(884, 561);
            this.pBoxBackgroundSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBackgroundSignIn.TabIndex = 1;
            this.pBoxBackgroundSignIn.TabStop = false;
            // 
            // SignInStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblLibrarySystem);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.pBoxBackgroundSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignInStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInStage_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIconSignIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBackgroundSignIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxBackgroundSignIn;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label lblLibrarySystem;
        private System.Windows.Forms.PictureBox pBoxIconSignIn;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.CheckBox cBoxShowPassword;
        private System.Windows.Forms.LinkLabel linkLblSignUp;
        private System.Windows.Forms.Label lblNewWorker;
    }
}

