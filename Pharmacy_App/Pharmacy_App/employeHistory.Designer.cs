﻿namespace Pharmacy_App
{
    partial class employeHistory
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
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewHistory
            // 
            this.listViewHistory.GridLines = true;
            this.listViewHistory.Location = new System.Drawing.Point(12, 42);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(1056, 396);
            this.listViewHistory.TabIndex = 0;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(12, 12);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // employeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.listViewHistory);
            this.Name = "employeHistory";
            this.Text = "employeHistory";
            this.Load += new System.EventHandler(this.employeHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.Button buttonReturn;
    }
}