namespace LibraryManagementSystem
{
    partial class PaymentStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentStage));
            this.rTBoxBill = new System.Windows.Forms.RichTextBox();
            this.btnChargeCustomer = new System.Windows.Forms.Button();
            this.panelHeaderCart = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.panelHeaderCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rTBoxBill
            // 
            this.rTBoxBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBoxBill.Location = new System.Drawing.Point(24, 144);
            this.rTBoxBill.Name = "rTBoxBill";
            this.rTBoxBill.Size = new System.Drawing.Size(489, 268);
            this.rTBoxBill.TabIndex = 0;
            this.rTBoxBill.Text = "";
            // 
            // btnChargeCustomer
            // 
            this.btnChargeCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargeCustomer.Location = new System.Drawing.Point(571, 201);
            this.btnChargeCustomer.Name = "btnChargeCustomer";
            this.btnChargeCustomer.Size = new System.Drawing.Size(165, 40);
            this.btnChargeCustomer.TabIndex = 1;
            this.btnChargeCustomer.Text = "Charge customer";
            this.btnChargeCustomer.UseVisualStyleBackColor = true;
            this.btnChargeCustomer.Click += new System.EventHandler(this.btnChargeCustomer_Click);
            // 
            // panelHeaderCart
            // 
            this.panelHeaderCart.BackColor = System.Drawing.Color.White;
            this.panelHeaderCart.Controls.Add(this.lblPayment);
            this.panelHeaderCart.Controls.Add(this.pictureBox1);
            this.panelHeaderCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderCart.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderCart.Name = "panelHeaderCart";
            this.panelHeaderCart.Size = new System.Drawing.Size(784, 60);
            this.panelHeaderCart.TabIndex = 2;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(315, 17);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(106, 29);
            this.lblPayment.TabIndex = 1;
            this.lblPayment.Text = "Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.payment_method__1_;
            this.pictureBox1.Location = new System.Drawing.Point(270, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(19, 116);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(37, 25);
            this.lblBill.TabIndex = 3;
            this.lblBill.Text = "Bill";
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBill.Location = new System.Drawing.Point(571, 261);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(165, 40);
            this.btnCancelBill.TabIndex = 4;
            this.btnCancelBill.Text = "Cancel bill";
            this.btnCancelBill.UseVisualStyleBackColor = true;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // PaymentStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 443);
            this.Controls.Add(this.btnCancelBill);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.panelHeaderCart);
            this.Controls.Add(this.btnChargeCustomer);
            this.Controls.Add(this.rTBoxBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System - Transactions";
            this.panelHeaderCart.ResumeLayout(false);
            this.panelHeaderCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTBoxBill;
        private System.Windows.Forms.Button btnChargeCustomer;
        private System.Windows.Forms.Panel panelHeaderCart;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnCancelBill;
    }
}