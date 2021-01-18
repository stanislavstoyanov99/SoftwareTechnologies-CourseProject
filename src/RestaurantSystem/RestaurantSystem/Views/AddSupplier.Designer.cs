﻿namespace RestaurantSystem.Views
{
    partial class AddSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.supplierAvailableDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supplierPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addSupplierButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.suppliersList = new System.Windows.Forms.ListBox();
            this.editSupplier = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на доставчик:";
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(432, 12);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(162, 20);
            this.supplierName.TabIndex = 1;
            // 
            // supplierAvailableDays
            // 
            this.supplierAvailableDays.Location = new System.Drawing.Point(432, 120);
            this.supplierAvailableDays.Name = "supplierAvailableDays";
            this.supplierAvailableDays.Size = new System.Drawing.Size(162, 20);
            this.supplierAvailableDays.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Свободни дни:";
            // 
            // supplierPhone
            // 
            this.supplierPhone.Location = new System.Drawing.Point(432, 66);
            this.supplierPhone.Name = "supplierPhone";
            this.supplierPhone.Size = new System.Drawing.Size(162, 20);
            this.supplierPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефонен номер:";
            // 
            // addSupplierButton
            // 
            this.addSupplierButton.Location = new System.Drawing.Point(511, 169);
            this.addSupplierButton.Name = "addSupplierButton";
            this.addSupplierButton.Size = new System.Drawing.Size(159, 38);
            this.addSupplierButton.TabIndex = 6;
            this.addSupplierButton.Text = "Добави доставчик";
            this.addSupplierButton.UseVisualStyleBackColor = true;
            this.addSupplierButton.Click += new System.EventHandler(this.addSupplierButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // suppliersList
            // 
            this.suppliersList.FormattingEnabled = true;
            this.suppliersList.Location = new System.Drawing.Point(12, 12);
            this.suppliersList.Name = "suppliersList";
            this.suppliersList.Size = new System.Drawing.Size(255, 264);
            this.suppliersList.TabIndex = 8;
            // 
            // editSupplier
            // 
            this.editSupplier.Location = new System.Drawing.Point(294, 169);
            this.editSupplier.Name = "editSupplier";
            this.editSupplier.Size = new System.Drawing.Size(159, 38);
            this.editSupplier.TabIndex = 9;
            this.editSupplier.Text = "Редактирай доствчик";
            this.editSupplier.UseVisualStyleBackColor = true;
            this.editSupplier.Click += new System.EventHandler(this.editSupplier_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(610, 300);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(86, 22);
            this.close.TabIndex = 10;
            this.close.Text = "Затвори";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Име на доставчик/телефон/свободни дни за доставка";
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.close);
            this.Controls.Add(this.editSupplier);
            this.Controls.Add(this.suppliersList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addSupplierButton);
            this.Controls.Add(this.supplierPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplierAvailableDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.label1);
            this.Name = "AddSupplier";
            this.Text = "Добави доставчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox supplierName;
        private System.Windows.Forms.TextBox supplierAvailableDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox supplierPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addSupplierButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox suppliersList;
        private System.Windows.Forms.Button editSupplier;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label5;
    }
}