namespace Pharmacy_App
{
    partial class AdminPanelDelete
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
            this.listViewMedicines = new System.Windows.Forms.ListView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelMedicineAmount = new System.Windows.Forms.Label();
            this.labelMedicineName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMedicine = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMedicineStatus = new System.Windows.Forms.Label();
            this.labelMedicineUploadDate = new System.Windows.Forms.Label();
            this.labelMedicineExperationDate = new System.Windows.Forms.Label();
            this.labelLastUploadDate = new System.Windows.Forms.Label();
            this.labelMedicineCategory = new System.Windows.Forms.Label();
            this.labelMg = new System.Windows.Forms.Label();
            this.labelMedicineMg = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelMedicinePrice = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelMedicineCost = new System.Windows.Forms.Label();
            this.labelExperationDate = new System.Windows.Forms.Label();
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.labelMedicineBarcodeNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewMedicines
            // 
            this.listViewMedicines.FullRowSelect = true;
            this.listViewMedicines.GridLines = true;
            this.listViewMedicines.Location = new System.Drawing.Point(12, 45);
            this.listViewMedicines.Name = "listViewMedicines";
            this.listViewMedicines.Size = new System.Drawing.Size(608, 442);
            this.listViewMedicines.TabIndex = 5;
            this.listViewMedicines.UseCompatibleStateImageBehavior = false;
            this.listViewMedicines.View = System.Windows.Forms.View.Details;
            this.listViewMedicines.SelectedIndexChanged += new System.EventHandler(this.listViewMedicines_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(714, 411);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 76);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product List";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(626, 411);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(82, 76);
            this.buttonReturn.TabIndex = 17;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(322, 217);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 13);
            this.labelCategory.TabIndex = 18;
            this.labelCategory.Text = "Category :";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(153, 217);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(49, 13);
            this.labelAmount.TabIndex = 19;
            this.labelAmount.Text = "Amount :";
            // 
            // labelMedicineAmount
            // 
            this.labelMedicineAmount.AutoSize = true;
            this.labelMedicineAmount.Location = new System.Drawing.Point(208, 217);
            this.labelMedicineAmount.Name = "labelMedicineAmount";
            this.labelMedicineAmount.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineAmount.TabIndex = 20;
            // 
            // labelMedicineName
            // 
            this.labelMedicineName.AutoSize = true;
            this.labelMedicineName.Location = new System.Drawing.Point(53, 217);
            this.labelMedicineName.Name = "labelMedicineName";
            this.labelMedicineName.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 217);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMedicineBarcodeNo);
            this.groupBox1.Controls.Add(this.labelBarcodeNo);
            this.groupBox1.Controls.Add(this.pictureBoxMedicine);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.labelMedicineStatus);
            this.groupBox1.Controls.Add(this.labelMedicineUploadDate);
            this.groupBox1.Controls.Add(this.labelMedicineExperationDate);
            this.groupBox1.Controls.Add(this.labelLastUploadDate);
            this.groupBox1.Controls.Add(this.labelMedicineCategory);
            this.groupBox1.Controls.Add(this.labelMg);
            this.groupBox1.Controls.Add(this.labelMedicineMg);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelMedicinePrice);
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelMedicineCost);
            this.groupBox1.Controls.Add(this.labelExperationDate);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.labelMedicineAmount);
            this.groupBox1.Controls.Add(this.labelMedicineName);
            this.groupBox1.Controls.Add(this.labelAmount);
            this.groupBox1.Location = new System.Drawing.Point(626, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 360);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine";
            // 
            // pictureBoxMedicine
            // 
            this.pictureBoxMedicine.Location = new System.Drawing.Point(9, 16);
            this.pictureBoxMedicine.Name = "pictureBoxMedicine";
            this.pictureBoxMedicine.Size = new System.Drawing.Size(209, 178);
            this.pictureBoxMedicine.TabIndex = 36;
            this.pictureBoxMedicine.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(275, 276);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStatus.TabIndex = 35;
            this.labelStatus.Text = "Status :";
            // 
            // labelMedicineStatus
            // 
            this.labelMedicineStatus.AutoSize = true;
            this.labelMedicineStatus.Location = new System.Drawing.Point(324, 276);
            this.labelMedicineStatus.Name = "labelMedicineStatus";
            this.labelMedicineStatus.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineStatus.TabIndex = 34;
            // 
            // labelMedicineUploadDate
            // 
            this.labelMedicineUploadDate.AutoSize = true;
            this.labelMedicineUploadDate.Location = new System.Drawing.Point(108, 276);
            this.labelMedicineUploadDate.Name = "labelMedicineUploadDate";
            this.labelMedicineUploadDate.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineUploadDate.TabIndex = 33;
            // 
            // labelMedicineExperationDate
            // 
            this.labelMedicineExperationDate.AutoSize = true;
            this.labelMedicineExperationDate.Location = new System.Drawing.Point(417, 247);
            this.labelMedicineExperationDate.Name = "labelMedicineExperationDate";
            this.labelMedicineExperationDate.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineExperationDate.TabIndex = 32;
            // 
            // labelLastUploadDate
            // 
            this.labelLastUploadDate.AutoSize = true;
            this.labelLastUploadDate.Location = new System.Drawing.Point(6, 276);
            this.labelLastUploadDate.Name = "labelLastUploadDate";
            this.labelLastUploadDate.Size = new System.Drawing.Size(96, 13);
            this.labelLastUploadDate.TabIndex = 31;
            this.labelLastUploadDate.Text = "Last Upload Date :";
            // 
            // labelMedicineCategory
            // 
            this.labelMedicineCategory.AutoSize = true;
            this.labelMedicineCategory.Location = new System.Drawing.Point(383, 217);
            this.labelMedicineCategory.Name = "labelMedicineCategory";
            this.labelMedicineCategory.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineCategory.TabIndex = 30;
            // 
            // labelMg
            // 
            this.labelMg.AutoSize = true;
            this.labelMg.Location = new System.Drawing.Point(484, 217);
            this.labelMg.Name = "labelMg";
            this.labelMg.Size = new System.Drawing.Size(28, 13);
            this.labelMg.TabIndex = 29;
            this.labelMg.Text = "Mg :";
            // 
            // labelMedicineMg
            // 
            this.labelMedicineMg.AutoSize = true;
            this.labelMedicineMg.Location = new System.Drawing.Point(518, 217);
            this.labelMedicineMg.Name = "labelMedicineMg";
            this.labelMedicineMg.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineMg.TabIndex = 28;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 247);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(37, 13);
            this.labelPrice.TabIndex = 27;
            this.labelPrice.Text = "Price :";
            // 
            // labelMedicinePrice
            // 
            this.labelMedicinePrice.AutoSize = true;
            this.labelMedicinePrice.Location = new System.Drawing.Point(49, 247);
            this.labelMedicinePrice.Name = "labelMedicinePrice";
            this.labelMedicinePrice.Size = new System.Drawing.Size(0, 13);
            this.labelMedicinePrice.TabIndex = 26;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(153, 247);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(34, 13);
            this.labelCost.TabIndex = 25;
            this.labelCost.Text = "Cost :";
            // 
            // labelMedicineCost
            // 
            this.labelMedicineCost.AutoSize = true;
            this.labelMedicineCost.Location = new System.Drawing.Point(193, 247);
            this.labelMedicineCost.Name = "labelMedicineCost";
            this.labelMedicineCost.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineCost.TabIndex = 24;
            // 
            // labelExperationDate
            // 
            this.labelExperationDate.AutoSize = true;
            this.labelExperationDate.Location = new System.Drawing.Point(322, 247);
            this.labelExperationDate.Name = "labelExperationDate";
            this.labelExperationDate.Size = new System.Drawing.Size(89, 13);
            this.labelExperationDate.TabIndex = 23;
            this.labelExperationDate.Text = "Experation Date :";
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.Location = new System.Drawing.Point(6, 301);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(70, 13);
            this.labelBarcodeNo.TabIndex = 37;
            this.labelBarcodeNo.Text = "Barcode No :";
            // 
            // labelMedicineBarcodeNo
            // 
            this.labelMedicineBarcodeNo.AutoSize = true;
            this.labelMedicineBarcodeNo.Location = new System.Drawing.Point(82, 301);
            this.labelMedicineBarcodeNo.Name = "labelMedicineBarcodeNo";
            this.labelMedicineBarcodeNo.Size = new System.Drawing.Size(0, 13);
            this.labelMedicineBarcodeNo.TabIndex = 38;
            // 
            // AdminPanelDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listViewMedicines);
            this.Name = "AdminPanelDelete";
            this.Text = "AdminPanelDelete";
            this.Load += new System.EventHandler(this.AdminPanelDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMedicines;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelMedicineAmount;
        private System.Windows.Forms.Label labelMedicineName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMedicineCategory;
        private System.Windows.Forms.Label labelMg;
        private System.Windows.Forms.Label labelMedicineMg;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMedicinePrice;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelMedicineCost;
        private System.Windows.Forms.Label labelExperationDate;
        private System.Windows.Forms.Label labelMedicineUploadDate;
        private System.Windows.Forms.Label labelMedicineExperationDate;
        private System.Windows.Forms.Label labelLastUploadDate;
        private System.Windows.Forms.PictureBox pictureBoxMedicine;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMedicineStatus;
        private System.Windows.Forms.Label labelMedicineBarcodeNo;
        private System.Windows.Forms.Label labelBarcodeNo;
    }
}