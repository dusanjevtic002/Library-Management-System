namespace LibraryManagementSystem
{
    partial class FaqsStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaqsStage));
            this.panelHeaderFaqs = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFaqs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddQuestion = new System.Windows.Forms.Label();
            this.dgvAllQuestions = new System.Windows.Forms.DataGridView();
            this.txtBoxTitleOfQuestion = new System.Windows.Forms.TextBox();
            this.lblTitleOfQuestion = new System.Windows.Forms.Label();
            this.rTBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblQuestionSerialNo = new System.Windows.Forms.Label();
            this.txtBoxQuestionSerialNo = new System.Windows.Forms.TextBox();
            this.panelHeaderFaqs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderFaqs
            // 
            this.panelHeaderFaqs.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeaderFaqs.Controls.Add(this.pictureBox1);
            this.panelHeaderFaqs.Controls.Add(this.lblFaqs);
            this.panelHeaderFaqs.Controls.Add(this.btnBack);
            this.panelHeaderFaqs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderFaqs.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderFaqs.Name = "panelHeaderFaqs";
            this.panelHeaderFaqs.Size = new System.Drawing.Size(1184, 60);
            this.panelHeaderFaqs.TabIndex = 0;
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
            // lblFaqs
            // 
            this.lblFaqs.AutoSize = true;
            this.lblFaqs.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaqs.Location = new System.Drawing.Point(524, 16);
            this.lblFaqs.Name = "lblFaqs";
            this.lblFaqs.Size = new System.Drawing.Size(60, 29);
            this.lblFaqs.TabIndex = 1;
            this.lblFaqs.Text = "Faqs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.Faqs32px;
            this.pictureBox1.Location = new System.Drawing.Point(480, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddQuestion
            // 
            this.lblAddQuestion.AutoSize = true;
            this.lblAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuestion.Location = new System.Drawing.Point(69, 97);
            this.lblAddQuestion.Name = "lblAddQuestion";
            this.lblAddQuestion.Size = new System.Drawing.Size(342, 25);
            this.lblAddQuestion.TabIndex = 1;
            this.lblAddQuestion.Text = "Add, update or delete the question";
            // 
            // dgvAllQuestions
            // 
            this.dgvAllQuestions.AllowUserToAddRows = false;
            this.dgvAllQuestions.AllowUserToDeleteRows = false;
            this.dgvAllQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllQuestions.Location = new System.Drawing.Point(529, 124);
            this.dgvAllQuestions.Name = "dgvAllQuestions";
            this.dgvAllQuestions.ReadOnly = true;
            this.dgvAllQuestions.Size = new System.Drawing.Size(607, 485);
            this.dgvAllQuestions.TabIndex = 2;
            this.dgvAllQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllQuestions_CellClick);
            // 
            // txtBoxTitleOfQuestion
            // 
            this.txtBoxTitleOfQuestion.Location = new System.Drawing.Point(74, 220);
            this.txtBoxTitleOfQuestion.Name = "txtBoxTitleOfQuestion";
            this.txtBoxTitleOfQuestion.Size = new System.Drawing.Size(337, 20);
            this.txtBoxTitleOfQuestion.TabIndex = 3;
            // 
            // lblTitleOfQuestion
            // 
            this.lblTitleOfQuestion.AutoSize = true;
            this.lblTitleOfQuestion.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleOfQuestion.Location = new System.Drawing.Point(71, 199);
            this.lblTitleOfQuestion.Name = "lblTitleOfQuestion";
            this.lblTitleOfQuestion.Size = new System.Drawing.Size(114, 18);
            this.lblTitleOfQuestion.TabIndex = 4;
            this.lblTitleOfQuestion.Text = "Title of question";
            // 
            // rTBoxAnswer
            // 
            this.rTBoxAnswer.Location = new System.Drawing.Point(74, 279);
            this.rTBoxAnswer.Name = "rTBoxAnswer";
            this.rTBoxAnswer.Size = new System.Drawing.Size(337, 213);
            this.rTBoxAnswer.TabIndex = 5;
            this.rTBoxAnswer.Text = "";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(71, 258);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(57, 18);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Answer";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(692, 96);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(284, 25);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Click on any row to fill text fields";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(74, 530);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(196, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(319, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 32);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(794, 630);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 32);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblQuestionSerialNo
            // 
            this.lblQuestionSerialNo.AutoSize = true;
            this.lblQuestionSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionSerialNo.Location = new System.Drawing.Point(71, 143);
            this.lblQuestionSerialNo.Name = "lblQuestionSerialNo";
            this.lblQuestionSerialNo.Size = new System.Drawing.Size(132, 18);
            this.lblQuestionSerialNo.TabIndex = 12;
            this.lblQuestionSerialNo.Text = "Question serial no.";
            // 
            // txtBoxQuestionSerialNo
            // 
            this.txtBoxQuestionSerialNo.Location = new System.Drawing.Point(74, 164);
            this.txtBoxQuestionSerialNo.Name = "txtBoxQuestionSerialNo";
            this.txtBoxQuestionSerialNo.Size = new System.Drawing.Size(337, 20);
            this.txtBoxQuestionSerialNo.TabIndex = 13;
            // 
            // FaqsStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.txtBoxQuestionSerialNo);
            this.Controls.Add(this.lblQuestionSerialNo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.rTBoxAnswer);
            this.Controls.Add(this.lblTitleOfQuestion);
            this.Controls.Add(this.txtBoxTitleOfQuestion);
            this.Controls.Add(this.dgvAllQuestions);
            this.Controls.Add(this.lblAddQuestion);
            this.Controls.Add(this.panelHeaderFaqs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FaqsStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Faqs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaqsStage_FormClosing);
            this.panelHeaderFaqs.ResumeLayout(false);
            this.panelHeaderFaqs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderFaqs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFaqs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddQuestion;
        private System.Windows.Forms.DataGridView dgvAllQuestions;
        private System.Windows.Forms.TextBox txtBoxTitleOfQuestion;
        private System.Windows.Forms.Label lblTitleOfQuestion;
        private System.Windows.Forms.RichTextBox rTBoxAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblQuestionSerialNo;
        private System.Windows.Forms.TextBox txtBoxQuestionSerialNo;
    }
}