﻿namespace RestaurantSystem
{
    partial class EmployeesTables
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.billTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productsList = new System.Windows.Forms.RichTextBox();
            this.tableNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tablesCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.itemsList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.billTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.productsList);
            this.groupBox1.Controls.Add(this.tableNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 555);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Избрана маса";
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(81, 40);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(62, 20);
            this.dateTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата:";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.okBtn.Location = new System.Drawing.Point(261, 351);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(111, 37);
            this.okBtn.TabIndex = 10;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // billTxt
            // 
            this.billTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billTxt.Location = new System.Drawing.Point(261, 305);
            this.billTxt.Name = "billTxt";
            this.billTxt.Size = new System.Drawing.Size(111, 29);
            this.billTxt.TabIndex = 4;
            this.billTxt.Text = "0";
            this.billTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Обща сума:";
            // 
            // productsList
            // 
            this.productsList.Location = new System.Drawing.Point(20, 87);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(352, 202);
            this.productsList.TabIndex = 2;
            this.productsList.Text = "";
            // 
            // tableNum
            // 
            this.tableNum.Location = new System.Drawing.Point(323, 40);
            this.tableNum.Name = "tableNum";
            this.tableNum.ReadOnly = true;
            this.tableNum.Size = new System.Drawing.Size(60, 20);
            this.tableNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Избрана маса:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tablesCombo);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(471, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(402, 162);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Маси";
            // 
            // tablesCombo
            // 
            this.tablesCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tablesCombo.FormattingEnabled = true;
            this.tablesCombo.Location = new System.Drawing.Point(179, 32);
            this.tablesCombo.Name = "tablesCombo";
            this.tablesCombo.Size = new System.Drawing.Size(155, 32);
            this.tablesCombo.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.priceTxt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.addItem);
            this.groupBox3.Controls.Add(this.itemsList);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(471, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 373);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавяне на продукт";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(191, 77);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 29);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Цена:";
            // 
            // priceTxt
            // 
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTxt.Location = new System.Drawing.Point(191, 132);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(143, 29);
            this.priceTxt.TabIndex = 12;
            this.priceTxt.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Продукти:";
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addItem.Location = new System.Drawing.Point(223, 185);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(111, 37);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Добави";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // itemsList
            // 
            this.itemsList.DisplayMember = "DishCategory";
            this.itemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(191, 19);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(143, 32);
            this.itemsList.TabIndex = 0;
            this.itemsList.ValueMember = "DishCategory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(11, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Изберете маса:";
            // 
            // EmployeesTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeesTables";
            this.Text = "EmployeesTables";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox billTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox productsList;
        private System.Windows.Forms.TextBox tableNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox tablesCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.ComboBox itemsList;
        private System.Windows.Forms.Label label7;
    }
}