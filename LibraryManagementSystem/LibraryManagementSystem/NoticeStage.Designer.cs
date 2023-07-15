namespace LibraryManagementSystem
{
    partial class NoticeStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeStage));
            this.panelHeaderNotice = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.pBoxNotice = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblContanctInfo = new System.Windows.Forms.Label();
            this.txtBoxContactInfo = new System.Windows.Forms.TextBox();
            this.rTBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rButtonIncludeDate = new System.Windows.Forms.RadioButton();
            this.rButtonExcludeDate = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rTBoxLargeArea = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelHeaderNotice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderNotice
            // 
            this.panelHeaderNotice.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderNotice.Controls.Add(this.lblNotice);
            this.panelHeaderNotice.Controls.Add(this.pBoxNotice);
            this.panelHeaderNotice.Controls.Add(this.btnBack);
            this.panelHeaderNotice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderNotice.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderNotice.Name = "panelHeaderNotice";
            this.panelHeaderNotice.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderNotice.TabIndex = 0;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(524, 16);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(82, 29);
            this.lblNotice.TabIndex = 2;
            this.lblNotice.Text = "Notice";
            // 
            // pBoxNotice
            // 
            this.pBoxNotice.Image = global::LibraryManagementSystem.Properties.Resources.Notice32px;
            this.pBoxNotice.Location = new System.Drawing.Point(485, 15);
            this.pBoxNotice.Name = "pBoxNotice";
            this.pBoxNotice.Size = new System.Drawing.Size(39, 32);
            this.pBoxNotice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxNotice.TabIndex = 1;
            this.pBoxNotice.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 25);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(88, 78);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(92, 105);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(225, 20);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(88, 216);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(89, 24);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(92, 244);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(225, 20);
            this.dtpStartDate.TabIndex = 4;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(88, 288);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(88, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(92, 315);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(225, 20);
            this.dtpEndDate.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(88, 145);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(85, 24);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(92, 173);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(225, 21);
            this.cBoxCategory.TabIndex = 8;
            // 
            // lblContanctInfo
            // 
            this.lblContanctInfo.AutoSize = true;
            this.lblContanctInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContanctInfo.Location = new System.Drawing.Point(88, 384);
            this.lblContanctInfo.Name = "lblContanctInfo";
            this.lblContanctInfo.Size = new System.Drawing.Size(170, 24);
            this.lblContanctInfo.TabIndex = 9;
            this.lblContanctInfo.Text = "Contact Information";
            // 
            // txtBoxContactInfo
            // 
            this.txtBoxContactInfo.Location = new System.Drawing.Point(92, 411);
            this.txtBoxContactInfo.Name = "txtBoxContactInfo";
            this.txtBoxContactInfo.Size = new System.Drawing.Size(225, 20);
            this.txtBoxContactInfo.TabIndex = 10;
            // 
            // rTBoxDescription
            // 
            this.rTBoxDescription.Location = new System.Drawing.Point(92, 477);
            this.rTBoxDescription.Name = "rTBoxDescription";
            this.rTBoxDescription.Size = new System.Drawing.Size(225, 109);
            this.rTBoxDescription.TabIndex = 11;
            this.rTBoxDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(88, 450);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 24);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // rButtonIncludeDate
            // 
            this.rButtonIncludeDate.AutoSize = true;
            this.rButtonIncludeDate.Location = new System.Drawing.Point(92, 341);
            this.rButtonIncludeDate.Name = "rButtonIncludeDate";
            this.rButtonIncludeDate.Size = new System.Drawing.Size(108, 17);
            this.rButtonIncludeDate.TabIndex = 13;
            this.rButtonIncludeDate.TabStop = true;
            this.rButtonIncludeDate.Text = "Include End Date";
            this.rButtonIncludeDate.UseVisualStyleBackColor = true;
            // 
            // rButtonExcludeDate
            // 
            this.rButtonExcludeDate.AutoSize = true;
            this.rButtonExcludeDate.Location = new System.Drawing.Point(206, 341);
            this.rButtonExcludeDate.Name = "rButtonExcludeDate";
            this.rButtonExcludeDate.Size = new System.Drawing.Size(111, 17);
            this.rButtonExcludeDate.TabIndex = 14;
            this.rButtonExcludeDate.TabStop = true;
            this.rButtonExcludeDate.Text = "Exclude End Date";
            this.rButtonExcludeDate.UseVisualStyleBackColor = true;
            this.rButtonExcludeDate.CheckedChanged += new System.EventHandler(this.rButtonExcludeDate_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(256, 602);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 32);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(60, 602);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 32);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(158, 602);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 32);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rTBoxLargeArea
            // 
            this.rTBoxLargeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBoxLargeArea.Location = new System.Drawing.Point(529, 105);
            this.rTBoxLargeArea.Name = "rTBoxLargeArea";
            this.rTBoxLargeArea.Size = new System.Drawing.Size(556, 533);
            this.rTBoxLargeArea.TabIndex = 19;
            this.rTBoxLargeArea.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(81, 648);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(250, 16);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "Click generate button to fill large text area";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // NoticeStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rTBoxLargeArea);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rButtonExcludeDate);
            this.Controls.Add(this.rButtonIncludeDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.rTBoxDescription);
            this.Controls.Add(this.txtBoxContactInfo);
            this.Controls.Add(this.lblContanctInfo);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelHeaderNotice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NoticeStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Notice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoticeStage_FormClosing);
            this.panelHeaderNotice.ResumeLayout(false);
            this.panelHeaderNotice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderNotice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pBoxNotice;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.Label lblContanctInfo;
        private System.Windows.Forms.TextBox txtBoxContactInfo;
        private System.Windows.Forms.RichTextBox rTBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RadioButton rButtonIncludeDate;
        private System.Windows.Forms.RadioButton rButtonExcludeDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rTBoxLargeArea;
        private System.Windows.Forms.Label lblInfo;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}