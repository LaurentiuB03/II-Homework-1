
namespace Homework_1
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.TotalPriceText = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.CashBtn = new System.Windows.Forms.RadioButton();
            this.CardBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PlaceOrderBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(177, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 180);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Siemens Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(202, 46);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(275, 32);
            this.OrderLabel.TabIndex = 1;
            this.OrderLabel.Text = "Sumarul comenzii";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceText
            // 
            this.TotalPriceText.AutoSize = true;
            this.TotalPriceText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceText.Location = new System.Drawing.Point(208, 287);
            this.TotalPriceText.Name = "TotalPriceText";
            this.TotalPriceText.Size = new System.Drawing.Size(155, 35);
            this.TotalPriceText.TabIndex = 2;
            this.TotalPriceText.Text = "Pret total:";
            this.TotalPriceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(377, 299);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.TotalPriceTextBox.TabIndex = 3;
            this.TotalPriceTextBox.Text = "0";
            // 
            // CashBtn
            // 
            this.CashBtn.AutoSize = true;
            this.CashBtn.Location = new System.Drawing.Point(572, 173);
            this.CashBtn.Name = "CashBtn";
            this.CashBtn.Size = new System.Drawing.Size(61, 21);
            this.CashBtn.TabIndex = 4;
            this.CashBtn.TabStop = true;
            this.CashBtn.Text = "Cash";
            this.CashBtn.UseVisualStyleBackColor = true;
            // 
            // CardBtn
            // 
            this.CardBtn.AutoSize = true;
            this.CardBtn.Location = new System.Drawing.Point(572, 200);
            this.CardBtn.Name = "CardBtn";
            this.CardBtn.Size = new System.Drawing.Size(59, 21);
            this.CardBtn.TabIndex = 5;
            this.CardBtn.TabStop = true;
            this.CardBtn.Text = "Card";
            this.CardBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modalitate plata";
            // 
            // PlaceOrderBtn
            // 
            this.PlaceOrderBtn.BackColor = System.Drawing.Color.Aqua;
            this.PlaceOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOrderBtn.Location = new System.Drawing.Point(195, 355);
            this.PlaceOrderBtn.Name = "PlaceOrderBtn";
            this.PlaceOrderBtn.Size = new System.Drawing.Size(302, 62);
            this.PlaceOrderBtn.TabIndex = 7;
            this.PlaceOrderBtn.Text = "Plasati comanda";
            this.PlaceOrderBtn.UseVisualStyleBackColor = false;
            this.PlaceOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlaceOrderBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardBtn);
            this.Controls.Add(this.CashBtn);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.TotalPriceText);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Label TotalPriceText;
        public System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.RadioButton CashBtn;
        private System.Windows.Forms.RadioButton CardBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button PlaceOrderBtn;
    }
}