namespace Pharmacy_App
{
    partial class employePanel
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.comboBoxAmount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMedicineName = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.radioButtonRecipe = new System.Windows.Forms.RadioButton();
            this.radioButtonWithoutRecipe = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBarcodeNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(1123, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Admin Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name :";
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(106, 236);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomerName.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 271);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Amount :";
            // 
            // comboBoxAmount
            // 
            this.comboBoxAmount.FormattingEnabled = true;
            this.comboBoxAmount.Location = new System.Drawing.Point(67, 268);
            this.comboBoxAmount.Name = "comboBoxAmount";
            this.comboBoxAmount.Size = new System.Drawing.Size(78, 21);
            this.comboBoxAmount.TabIndex = 5;
            this.comboBoxAmount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medicine Name :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(55, 159);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 13);
            this.labelPrice.TabIndex = 13;
            // 
            // labelMedicineName
            // 
            this.labelMedicineName.AutoSize = true;
            this.labelMedicineName.Location = new System.Drawing.Point(103, 135);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineName.TabIndex = 14;
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(12, 378);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(250, 58);
            this.buttonSell.TabIndex = 15;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // radioButtonRecipe
            // 
            this.radioButtonRecipe.AutoSize = true;
            this.radioButtonRecipe.Location = new System.Drawing.Point(15, 307);
            this.radioButtonRecipe.Name = "radioButtonRecipe";
            this.radioButtonRecipe.Size = new System.Drawing.Size(76, 17);
            this.radioButtonRecipe.TabIndex = 16;
            this.radioButtonRecipe.TabStop = true;
            this.radioButtonRecipe.Text = "with recipe";
            this.radioButtonRecipe.UseVisualStyleBackColor = true;
            // 
            // radioButtonWithoutRecipe
            // 
            this.radioButtonWithoutRecipe.AutoSize = true;
            this.radioButtonWithoutRecipe.Location = new System.Drawing.Point(106, 307);
            this.radioButtonWithoutRecipe.Name = "radioButtonWithoutRecipe";
            this.radioButtonWithoutRecipe.Size = new System.Drawing.Size(91, 17);
            this.radioButtonWithoutRecipe.TabIndex = 17;
            this.radioButtonWithoutRecipe.TabStop = true;
            this.radioButtonWithoutRecipe.Text = "without recipe";
            this.radioButtonWithoutRecipe.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total :";
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(194, 268);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(47, 20);
            this.textBoxTotalPrice.TabIndex = 19;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(1042, 12);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonHistory.TabIndex = 20;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(194, 175);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Search ";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Barcode No :";
            // 
            // textBoxBarcodeNo
            // 
            this.textBoxBarcodeNo.Location = new System.Drawing.Point(88, 178);
            this.textBoxBarcodeNo.Name = "textBoxBarcodeNo";
            this.textBoxBarcodeNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxBarcodeNo.TabIndex = 23;
            this.textBoxBarcodeNo.TextChanged += new System.EventHandler(this.textBoxBarcodeNo_TextChanged);
            // 
            // employePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 523);
            this.Controls.Add(this.textBoxBarcodeNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonWithoutRecipe);
            this.Controls.Add(this.radioButtonRecipe);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.labelMedicineName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAmount);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Name = "employePanel";
            this.Text = "employePanel";
            this.Load += new System.EventHandler(this.employePanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonSearch;
        public System.Windows.Forms.Label labelMedicineName;
        public System.Windows.Forms.TextBox textBoxCustomerName;
        public System.Windows.Forms.ComboBox comboBoxAmount;
        public System.Windows.Forms.Label labelPrice;
        public System.Windows.Forms.RadioButton radioButtonRecipe;
        public System.Windows.Forms.RadioButton radioButtonWithoutRecipe;
        public System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxBarcodeNo;
    }
}