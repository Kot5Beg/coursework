﻿namespace Ювелирная_мастерская
{
    partial class AddMaster
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
            this.AddMasterBut = new System.Windows.Forms.Button();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PatronimycText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.QualList = new System.Windows.Forms.ComboBox();
            this.SalaryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddMasterBut
            // 
            this.AddMasterBut.Location = new System.Drawing.Point(107, 262);
            this.AddMasterBut.Name = "AddMasterBut";
            this.AddMasterBut.Size = new System.Drawing.Size(162, 23);
            this.AddMasterBut.TabIndex = 0;
            this.AddMasterBut.Text = "Добавить";
            this.AddMasterBut.UseVisualStyleBackColor = true;
            this.AddMasterBut.Click += new System.EventHandler(this.AddMasterBut_Click);
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(137, 59);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(225, 20);
            this.SurnameText.TabIndex = 1;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(137, 86);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(225, 20);
            this.NameText.TabIndex = 2;
            // 
            // PatronimycText
            // 
            this.PatronimycText.Location = new System.Drawing.Point(137, 113);
            this.PatronimycText.Name = "PatronimycText";
            this.PatronimycText.Size = new System.Drawing.Size(225, 20);
            this.PatronimycText.TabIndex = 3;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(137, 143);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(225, 20);
            this.AddressText.TabIndex = 4;
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(137, 167);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(225, 20);
            this.PhoneText.TabIndex = 5;
            // 
            // QualList
            // 
            this.QualList.FormattingEnabled = true;
            this.QualList.Location = new System.Drawing.Point(137, 194);
            this.QualList.Name = "QualList";
            this.QualList.Size = new System.Drawing.Size(225, 21);
            this.QualList.TabIndex = 6;
            // 
            // SalaryText
            // 
            this.SalaryText.Location = new System.Drawing.Point(137, 222);
            this.SalaryText.Name = "SalaryText";
            this.SalaryText.Size = new System.Drawing.Size(225, 20);
            this.SalaryText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Квалификация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зарплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Введите данные о мастере";
            // 
            // AddMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 312);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalaryText);
            this.Controls.Add(this.QualList);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.PatronimycText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.AddMasterBut);
            this.Name = "AddMaster";
            this.Text = "AddMaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMasterBut;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PatronimycText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.ComboBox QualList;
        private System.Windows.Forms.TextBox SalaryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}