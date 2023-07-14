namespace LibraryManagementSystem
{
    partial class SettingsStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsStage));
            this.panelHeaderSettings = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSetTheme1 = new System.Windows.Forms.Button();
            this.btnSetTheme2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxOption1 = new System.Windows.Forms.PictureBox();
            this.pBoxGearIcon = new System.Windows.Forms.PictureBox();
            this.panelHeaderSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOption1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGearIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderSettings
            // 
            this.panelHeaderSettings.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderSettings.Controls.Add(this.pBoxGearIcon);
            this.panelHeaderSettings.Controls.Add(this.lblSettings);
            this.panelHeaderSettings.Controls.Add(this.btnBack);
            this.panelHeaderSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderSettings.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderSettings.Name = "panelHeaderSettings";
            this.panelHeaderSettings.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderSettings.TabIndex = 0;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.Location = new System.Drawing.Point(524, 16);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(96, 29);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseClick);
            // 
            // btnSetTheme1
            // 
            this.btnSetTheme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTheme1.Location = new System.Drawing.Point(202, 499);
            this.btnSetTheme1.Name = "btnSetTheme1";
            this.btnSetTheme1.Size = new System.Drawing.Size(172, 45);
            this.btnSetTheme1.TabIndex = 2;
            this.btnSetTheme1.Text = "Set Theme";
            this.btnSetTheme1.UseVisualStyleBackColor = true;
            this.btnSetTheme1.Click += new System.EventHandler(this.btnSetTheme1_Click);
            // 
            // btnSetTheme2
            // 
            this.btnSetTheme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTheme2.Location = new System.Drawing.Point(838, 499);
            this.btnSetTheme2.Name = "btnSetTheme2";
            this.btnSetTheme2.Size = new System.Drawing.Size(172, 45);
            this.btnSetTheme2.TabIndex = 3;
            this.btnSetTheme2.Text = "Set Theme";
            this.btnSetTheme2.UseVisualStyleBackColor = true;
            this.btnSetTheme2.Click += new System.EventHandler(this.btnSetTheme2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.Option2;
            this.pictureBox1.Location = new System.Drawing.Point(628, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxOption1
            // 
            this.pBoxOption1.Image = global::LibraryManagementSystem.Properties.Resources.Option1;
            this.pBoxOption1.Location = new System.Drawing.Point(33, 125);
            this.pBoxOption1.Name = "pBoxOption1";
            this.pBoxOption1.Size = new System.Drawing.Size(526, 337);
            this.pBoxOption1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxOption1.TabIndex = 1;
            this.pBoxOption1.TabStop = false;
            // 
            // pBoxGearIcon
            // 
            this.pBoxGearIcon.Image = global::LibraryManagementSystem.Properties.Resources.Gear32px;
            this.pBoxGearIcon.Location = new System.Drawing.Point(486, 14);
            this.pBoxGearIcon.Name = "pBoxGearIcon";
            this.pBoxGearIcon.Size = new System.Drawing.Size(34, 35);
            this.pBoxGearIcon.TabIndex = 2;
            this.pBoxGearIcon.TabStop = false;
            // 
            // SettingsStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSetTheme2);
            this.Controls.Add(this.btnSetTheme1);
            this.Controls.Add(this.pBoxOption1);
            this.Controls.Add(this.panelHeaderSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsStage_FormClosing);
            this.panelHeaderSettings.ResumeLayout(false);
            this.panelHeaderSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxOption1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGearIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderSettings;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.PictureBox pBoxGearIcon;
        private System.Windows.Forms.PictureBox pBoxOption1;
        private System.Windows.Forms.Button btnSetTheme1;
        private System.Windows.Forms.Button btnSetTheme2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}