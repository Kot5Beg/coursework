﻿namespace Ювелирная_мастерская
{
    partial class Admin
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
            this.AdminPanel = new System.Windows.Forms.TabControl();
            this.Managers = new System.Windows.Forms.TabPage();
            this.Delete_Manager = new System.Windows.Forms.Button();
            this.Update_Manager = new System.Windows.Forms.Button();
            this.Add_Manager = new System.Windows.Forms.Button();
            this.ManagerList = new System.Windows.Forms.DataGridView();
            this.Masters = new System.Windows.Forms.TabPage();
            this.Delete_Master = new System.Windows.Forms.Button();
            this.Update_Master = new System.Windows.Forms.Button();
            this.Add_Master = new System.Windows.Forms.Button();
            this.MasterList = new System.Windows.Forms.DataGridView();
            this.Qualification = new System.Windows.Forms.TabPage();
            this.Delete_Qual = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Add_Qual = new System.Windows.Forms.Button();
            this.QualList = new System.Windows.Forms.DataGridView();
            this.Products = new System.Windows.Forms.TabPage();
            this.Delete_Product = new System.Windows.Forms.Button();
            this.Update_Product = new System.Windows.Forms.Button();
            this.Add_Product = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.Materials = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MaterialList = new System.Windows.Forms.DataGridView();
            this.Products_Type = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.TypeList = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.AdminPanel.SuspendLayout();
            this.Managers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManagerList)).BeginInit();
            this.Masters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MasterList)).BeginInit();
            this.Qualification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualList)).BeginInit();
            this.Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).BeginInit();
            this.Products_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.Managers);
            this.AdminPanel.Controls.Add(this.Masters);
            this.AdminPanel.Controls.Add(this.Qualification);
            this.AdminPanel.Controls.Add(this.Products);
            this.AdminPanel.Controls.Add(this.Materials);
            this.AdminPanel.Controls.Add(this.Products_Type);
            this.AdminPanel.Location = new System.Drawing.Point(18, 19);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.SelectedIndex = 0;
            this.AdminPanel.Size = new System.Drawing.Size(1027, 550);
            this.AdminPanel.TabIndex = 0;
            this.AdminPanel.Selected += new System.Windows.Forms.TabControlEventHandler(this.AdminPanel_Selected);
            // 
            // Managers
            // 
            this.Managers.Controls.Add(this.Delete_Manager);
            this.Managers.Controls.Add(this.Update_Manager);
            this.Managers.Controls.Add(this.Add_Manager);
            this.Managers.Controls.Add(this.ManagerList);
            this.Managers.Location = new System.Drawing.Point(4, 30);
            this.Managers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Managers.Name = "Managers";
            this.Managers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Managers.Size = new System.Drawing.Size(1019, 516);
            this.Managers.TabIndex = 0;
            this.Managers.Text = "Менеджеры";
            this.Managers.UseVisualStyleBackColor = true;
            // 
            // Delete_Manager
            // 
            this.Delete_Manager.Location = new System.Drawing.Point(791, 104);
            this.Delete_Manager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete_Manager.Name = "Delete_Manager";
            this.Delete_Manager.Size = new System.Drawing.Size(112, 37);
            this.Delete_Manager.TabIndex = 3;
            this.Delete_Manager.Text = "Удалить";
            this.Delete_Manager.UseVisualStyleBackColor = true;
            this.Delete_Manager.Click += new System.EventHandler(this.Delete_Manager_Click);
            // 
            // Update_Manager
            // 
            this.Update_Manager.Location = new System.Drawing.Point(791, 57);
            this.Update_Manager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Manager.Name = "Update_Manager";
            this.Update_Manager.Size = new System.Drawing.Size(112, 37);
            this.Update_Manager.TabIndex = 2;
            this.Update_Manager.Text = "Изменить";
            this.Update_Manager.UseVisualStyleBackColor = true;
            this.Update_Manager.Click += new System.EventHandler(this.Update_Manager_Click);
            // 
            // Add_Manager
            // 
            this.Add_Manager.Location = new System.Drawing.Point(791, 10);
            this.Add_Manager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Manager.Name = "Add_Manager";
            this.Add_Manager.Size = new System.Drawing.Size(112, 37);
            this.Add_Manager.TabIndex = 1;
            this.Add_Manager.Text = "Добавить";
            this.Add_Manager.UseVisualStyleBackColor = true;
            this.Add_Manager.Click += new System.EventHandler(this.Add_Manager_Click);
            // 
            // ManagerList
            // 
            this.ManagerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagerList.Location = new System.Drawing.Point(9, 10);
            this.ManagerList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManagerList.Name = "ManagerList";
            this.ManagerList.Size = new System.Drawing.Size(774, 478);
            this.ManagerList.TabIndex = 0;
            // 
            // Masters
            // 
            this.Masters.Controls.Add(this.Delete_Master);
            this.Masters.Controls.Add(this.Update_Master);
            this.Masters.Controls.Add(this.Add_Master);
            this.Masters.Controls.Add(this.MasterList);
            this.Masters.Location = new System.Drawing.Point(4, 30);
            this.Masters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Masters.Name = "Masters";
            this.Masters.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Masters.Size = new System.Drawing.Size(1019, 516);
            this.Masters.TabIndex = 1;
            this.Masters.Text = "Мастера";
            this.Masters.UseVisualStyleBackColor = true;
            // 
            // Delete_Master
            // 
            this.Delete_Master.Location = new System.Drawing.Point(682, 434);
            this.Delete_Master.Name = "Delete_Master";
            this.Delete_Master.Size = new System.Drawing.Size(110, 49);
            this.Delete_Master.TabIndex = 3;
            this.Delete_Master.Text = "Удалить";
            this.Delete_Master.UseVisualStyleBackColor = true;
            this.Delete_Master.Click += new System.EventHandler(this.Delete_Master_Click);
            // 
            // Update_Master
            // 
            this.Update_Master.Location = new System.Drawing.Point(377, 434);
            this.Update_Master.Name = "Update_Master";
            this.Update_Master.Size = new System.Drawing.Size(139, 49);
            this.Update_Master.TabIndex = 2;
            this.Update_Master.Text = "Изменить";
            this.Update_Master.UseVisualStyleBackColor = true;
            this.Update_Master.Click += new System.EventHandler(this.Update_Master_Click);
            // 
            // Add_Master
            // 
            this.Add_Master.Location = new System.Drawing.Point(156, 434);
            this.Add_Master.Name = "Add_Master";
            this.Add_Master.Size = new System.Drawing.Size(102, 49);
            this.Add_Master.TabIndex = 1;
            this.Add_Master.Text = "Добавить";
            this.Add_Master.UseVisualStyleBackColor = true;
            this.Add_Master.Click += new System.EventHandler(this.Add_Master_Click);
            // 
            // MasterList
            // 
            this.MasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterList.Location = new System.Drawing.Point(9, 10);
            this.MasterList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MasterList.Name = "MasterList";
            this.MasterList.Size = new System.Drawing.Size(950, 377);
            this.MasterList.TabIndex = 0;
            this.MasterList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MasterList_CellContentClick);
            // 
            // Qualification
            // 
            this.Qualification.Controls.Add(this.Delete_Qual);
            this.Qualification.Controls.Add(this.button2);
            this.Qualification.Controls.Add(this.Add_Qual);
            this.Qualification.Controls.Add(this.QualList);
            this.Qualification.Location = new System.Drawing.Point(4, 30);
            this.Qualification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Qualification.Name = "Qualification";
            this.Qualification.Size = new System.Drawing.Size(1019, 516);
            this.Qualification.TabIndex = 5;
            this.Qualification.Text = "Квалификации мастеров";
            this.Qualification.UseVisualStyleBackColor = true;
            // 
            // Delete_Qual
            // 
            this.Delete_Qual.Location = new System.Drawing.Point(666, 101);
            this.Delete_Qual.Name = "Delete_Qual";
            this.Delete_Qual.Size = new System.Drawing.Size(101, 36);
            this.Delete_Qual.TabIndex = 3;
            this.Delete_Qual.Text = "Удалить";
            this.Delete_Qual.UseVisualStyleBackColor = true;
            this.Delete_Qual.Click += new System.EventHandler(this.Delete_Qual_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_Qual
            // 
            this.Add_Qual.Location = new System.Drawing.Point(666, 17);
            this.Add_Qual.Name = "Add_Qual";
            this.Add_Qual.Size = new System.Drawing.Size(101, 36);
            this.Add_Qual.TabIndex = 1;
            this.Add_Qual.Text = "Добавить";
            this.Add_Qual.UseVisualStyleBackColor = true;
            this.Add_Qual.Click += new System.EventHandler(this.Add_Qual_Click);
            // 
            // QualList
            // 
            this.QualList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QualList.Location = new System.Drawing.Point(18, 17);
            this.QualList.Name = "QualList";
            this.QualList.Size = new System.Drawing.Size(633, 458);
            this.QualList.TabIndex = 0;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.Delete_Product);
            this.Products.Controls.Add(this.Update_Product);
            this.Products.Controls.Add(this.Add_Product);
            this.Products.Controls.Add(this.ProductList);
            this.Products.Location = new System.Drawing.Point(4, 30);
            this.Products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Products.Size = new System.Drawing.Size(1019, 516);
            this.Products.TabIndex = 2;
            this.Products.Text = "Изделия";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Delete_Product
            // 
            this.Delete_Product.Location = new System.Drawing.Point(775, 147);
            this.Delete_Product.Name = "Delete_Product";
            this.Delete_Product.Size = new System.Drawing.Size(105, 33);
            this.Delete_Product.TabIndex = 3;
            this.Delete_Product.Text = "Удалить";
            this.Delete_Product.UseVisualStyleBackColor = true;
            // 
            // Update_Product
            // 
            this.Update_Product.Location = new System.Drawing.Point(775, 92);
            this.Update_Product.Name = "Update_Product";
            this.Update_Product.Size = new System.Drawing.Size(105, 33);
            this.Update_Product.TabIndex = 2;
            this.Update_Product.Text = "Изменить";
            this.Update_Product.UseVisualStyleBackColor = true;
            // 
            // Add_Product
            // 
            this.Add_Product.Location = new System.Drawing.Point(775, 41);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(105, 33);
            this.Add_Product.TabIndex = 1;
            this.Add_Product.Text = "Добавить";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // ProductList
            // 
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Location = new System.Drawing.Point(7, 17);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(741, 475);
            this.ProductList.TabIndex = 0;
            // 
            // Materials
            // 
            this.Materials.Controls.Add(this.button1);
            this.Materials.Controls.Add(this.button3);
            this.Materials.Controls.Add(this.button4);
            this.Materials.Controls.Add(this.MaterialList);
            this.Materials.Location = new System.Drawing.Point(4, 30);
            this.Materials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Materials.Name = "Materials";
            this.Materials.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Materials.Size = new System.Drawing.Size(1019, 516);
            this.Materials.TabIndex = 3;
            this.Materials.Text = "Материалы";
            this.Materials.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(841, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(841, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MaterialList
            // 
            this.MaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialList.Location = new System.Drawing.Point(73, 21);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(741, 475);
            this.MaterialList.TabIndex = 4;
            // 
            // Products_Type
            // 
            this.Products_Type.Controls.Add(this.button5);
            this.Products_Type.Controls.Add(this.button6);
            this.Products_Type.Controls.Add(this.button7);
            this.Products_Type.Controls.Add(this.TypeList);
            this.Products_Type.Location = new System.Drawing.Point(4, 30);
            this.Products_Type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Products_Type.Name = "Products_Type";
            this.Products_Type.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Products_Type.Size = new System.Drawing.Size(1019, 516);
            this.Products_Type.TabIndex = 4;
            this.Products_Type.Text = "Типы изделий";
            this.Products_Type.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(841, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 33);
            this.button5.TabIndex = 7;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(841, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(841, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 33);
            this.button7.TabIndex = 5;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // TypeList
            // 
            this.TypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeList.Location = new System.Drawing.Point(73, 21);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(741, 475);
            this.TypeList.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(390, 574);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(261, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "Выйти из учётной записи";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 616);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.AdminPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.AdminPanel.ResumeLayout(false);
            this.Managers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManagerList)).EndInit();
            this.Masters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MasterList)).EndInit();
            this.Qualification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QualList)).EndInit();
            this.Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.Materials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).EndInit();
            this.Products_Type.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AdminPanel;
        private System.Windows.Forms.TabPage Managers;
        private System.Windows.Forms.TabPage Masters;
        private System.Windows.Forms.DataGridView ManagerList;
        private System.Windows.Forms.DataGridView MasterList;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.TabPage Materials;
        private System.Windows.Forms.TabPage Products_Type;
        private System.Windows.Forms.Button Delete_Manager;
        private System.Windows.Forms.Button Update_Manager;
        private System.Windows.Forms.Button Add_Manager;
        private System.Windows.Forms.Button Delete_Master;
        private System.Windows.Forms.Button Update_Master;
        private System.Windows.Forms.Button Add_Master;
        private System.Windows.Forms.TabPage Qualification;
        private System.Windows.Forms.Button Delete_Qual;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add_Qual;
        private System.Windows.Forms.DataGridView QualList;
        private System.Windows.Forms.Button Delete_Product;
        private System.Windows.Forms.Button Update_Product;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView MaterialList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView TypeList;
        private System.Windows.Forms.Button button8;
    }
}