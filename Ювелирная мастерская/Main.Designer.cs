﻿namespace Ювелирная_мастерская
{
    partial class Main
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.PlaceOrder = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientPage = new System.Windows.Forms.TabPage();
            this.patronymic_sort = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.name_sort = new System.Windows.Forms.CheckBox();
            this.surname_sort = new System.Windows.Forms.CheckBox();
            this.Delete_Client = new System.Windows.Forms.Button();
            this.All_Client = new System.Windows.Forms.Button();
            this.Upd_Client = new System.Windows.Forms.Button();
            this.Add_Client = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.ClientList = new System.Windows.Forms.DataGridView();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.SelectType = new System.Windows.Forms.Button();
            this.AlphaSort = new System.Windows.Forms.CheckBox();
            this.TimeProdSort = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.spt = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.MaterialPage = new System.Windows.Forms.TabPage();
            this.MaterialList = new System.Windows.Forms.DataGridView();
            this.TypePage = new System.Windows.Forms.TabPage();
            this.TypeList = new System.Windows.Forms.DataGridView();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.OrdersList = new System.Windows.Forms.DataGridView();
            this.ContractPage = new System.Windows.Forms.TabPage();
            this.ContractList = new System.Windows.Forms.DataGridView();
            this.Report = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.PlaceOrder.SuspendLayout();
            this.ClientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            this.ProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.MaterialPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).BeginInit();
            this.TypePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).BeginInit();
            this.OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            this.ContractPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.PlaceOrder);
            this.Menu.Controls.Add(this.ClientPage);
            this.Menu.Controls.Add(this.ProductPage);
            this.Menu.Controls.Add(this.MaterialPage);
            this.Menu.Controls.Add(this.TypePage);
            this.Menu.Controls.Add(this.OrdersPage);
            this.Menu.Controls.Add(this.ContractPage);
            this.Menu.Controls.Add(this.Report);
            this.Menu.Location = new System.Drawing.Point(20, 86);
            this.Menu.Margin = new System.Windows.Forms.Padding(5);
            this.Menu.Multiline = true;
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1015, 516);
            this.Menu.TabIndex = 0;
            this.Menu.Selected += new System.Windows.Forms.TabControlEventHandler(this.Menu_Selected);
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Controls.Add(this.comboBox4);
            this.PlaceOrder.Controls.Add(this.label10);
            this.PlaceOrder.Controls.Add(this.textBox3);
            this.PlaceOrder.Controls.Add(this.comboBox3);
            this.PlaceOrder.Controls.Add(this.comboBox2);
            this.PlaceOrder.Controls.Add(this.comboBox1);
            this.PlaceOrder.Controls.Add(this.textBox2);
            this.PlaceOrder.Controls.Add(this.button1);
            this.PlaceOrder.Controls.Add(this.label5);
            this.PlaceOrder.Controls.Add(this.label4);
            this.PlaceOrder.Controls.Add(this.label3);
            this.PlaceOrder.Controls.Add(this.label2);
            this.PlaceOrder.Controls.Add(this.label1);
            this.PlaceOrder.Location = new System.Drawing.Point(4, 30);
            this.PlaceOrder.Margin = new System.Windows.Forms.Padding(5);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(1007, 482);
            this.PlaceOrder.TabIndex = 6;
            this.PlaceOrder.Text = "Оформить заказ";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(200, 250);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(289, 29);
            this.comboBox4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Выберите клиента";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(289, 29);
            this.textBox3.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(200, 118);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(289, 29);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(200, 77);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 29);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 29);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(289, 29);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Оформить заказ и договор";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Время изготовления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Итоговая цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите материал";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите изделие";
            // 
            // ClientPage
            // 
            this.ClientPage.Controls.Add(this.patronymic_sort);
            this.ClientPage.Controls.Add(this.label11);
            this.ClientPage.Controls.Add(this.name_sort);
            this.ClientPage.Controls.Add(this.surname_sort);
            this.ClientPage.Controls.Add(this.Delete_Client);
            this.ClientPage.Controls.Add(this.All_Client);
            this.ClientPage.Controls.Add(this.Upd_Client);
            this.ClientPage.Controls.Add(this.Add_Client);
            this.ClientPage.Controls.Add(this.label9);
            this.ClientPage.Controls.Add(this.SearchText);
            this.ClientPage.Controls.Add(this.ClientList);
            this.ClientPage.Location = new System.Drawing.Point(4, 30);
            this.ClientPage.Margin = new System.Windows.Forms.Padding(5);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Padding = new System.Windows.Forms.Padding(5);
            this.ClientPage.Size = new System.Drawing.Size(1007, 482);
            this.ClientPage.TabIndex = 0;
            this.ClientPage.Text = "Клиенты";
            this.ClientPage.UseVisualStyleBackColor = true;
            // 
            // patronymic_sort
            // 
            this.patronymic_sort.AutoSize = true;
            this.patronymic_sort.Location = new System.Drawing.Point(19, 192);
            this.patronymic_sort.Name = "patronymic_sort";
            this.patronymic_sort.Size = new System.Drawing.Size(114, 25);
            this.patronymic_sort.TabIndex = 10;
            this.patronymic_sort.Text = "по отчеству";
            this.patronymic_sort.UseVisualStyleBackColor = true;
            this.patronymic_sort.CheckedChanged += new System.EventHandler(this.patronymic_sort_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Сортировка";
            // 
            // name_sort
            // 
            this.name_sort.AutoSize = true;
            this.name_sort.Location = new System.Drawing.Point(19, 161);
            this.name_sort.Name = "name_sort";
            this.name_sort.Size = new System.Drawing.Size(97, 25);
            this.name_sort.TabIndex = 8;
            this.name_sort.Text = "по имени";
            this.name_sort.UseVisualStyleBackColor = true;
            this.name_sort.CheckedChanged += new System.EventHandler(this.name_sort_CheckedChanged);
            // 
            // surname_sort
            // 
            this.surname_sort.AutoSize = true;
            this.surname_sort.Location = new System.Drawing.Point(19, 129);
            this.surname_sort.Name = "surname_sort";
            this.surname_sort.Size = new System.Drawing.Size(116, 25);
            this.surname_sort.TabIndex = 7;
            this.surname_sort.Text = "по фамилии";
            this.surname_sort.UseVisualStyleBackColor = true;
            this.surname_sort.CheckedChanged += new System.EventHandler(this.surname_sort_CheckedChanged);
            // 
            // Delete_Client
            // 
            this.Delete_Client.Location = new System.Drawing.Point(19, 430);
            this.Delete_Client.Name = "Delete_Client";
            this.Delete_Client.Size = new System.Drawing.Size(383, 42);
            this.Delete_Client.TabIndex = 6;
            this.Delete_Client.Text = " Удалить";
            this.Delete_Client.UseVisualStyleBackColor = true;
            this.Delete_Client.Click += new System.EventHandler(this.Delete_Client_Click);
            // 
            // All_Client
            // 
            this.All_Client.Location = new System.Drawing.Point(19, 382);
            this.All_Client.Name = "All_Client";
            this.All_Client.Size = new System.Drawing.Size(383, 42);
            this.All_Client.TabIndex = 5;
            this.All_Client.Text = "Обновить";
            this.All_Client.UseVisualStyleBackColor = true;
            this.All_Client.Click += new System.EventHandler(this.All_Client_Click);
            // 
            // Upd_Client
            // 
            this.Upd_Client.Location = new System.Drawing.Point(19, 334);
            this.Upd_Client.Name = "Upd_Client";
            this.Upd_Client.Size = new System.Drawing.Size(383, 42);
            this.Upd_Client.TabIndex = 4;
            this.Upd_Client.Text = "Изменить";
            this.Upd_Client.UseVisualStyleBackColor = true;
            this.Upd_Client.Click += new System.EventHandler(this.Upd_Client_Click);
            // 
            // Add_Client
            // 
            this.Add_Client.Location = new System.Drawing.Point(19, 286);
            this.Add_Client.Name = "Add_Client";
            this.Add_Client.Size = new System.Drawing.Size(383, 42);
            this.Add_Client.TabIndex = 3;
            this.Add_Client.Text = "Добавить";
            this.Add_Client.UseVisualStyleBackColor = true;
            this.Add_Client.Click += new System.EventHandler(this.Add_Client_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Поиск";
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(10, 43);
            this.SearchText.Margin = new System.Windows.Forms.Padding(5);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(392, 29);
            this.SearchText.TabIndex = 1;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // ClientList
            // 
            this.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientList.Location = new System.Drawing.Point(412, 10);
            this.ClientList.Margin = new System.Windows.Forms.Padding(5);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(585, 462);
            this.ClientList.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.SelectType);
            this.ProductPage.Controls.Add(this.AlphaSort);
            this.ProductPage.Controls.Add(this.TimeProdSort);
            this.ProductPage.Controls.Add(this.label16);
            this.ProductPage.Controls.Add(this.label15);
            this.ProductPage.Controls.Add(this.label14);
            this.ProductPage.Controls.Add(this.TypeCombo);
            this.ProductPage.Controls.Add(this.label13);
            this.ProductPage.Controls.Add(this.label12);
            this.ProductPage.Controls.Add(this.spt);
            this.ProductPage.Controls.Add(this.ProductList);
            this.ProductPage.Location = new System.Drawing.Point(4, 30);
            this.ProductPage.Margin = new System.Windows.Forms.Padding(5);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(5);
            this.ProductPage.Size = new System.Drawing.Size(1007, 482);
            this.ProductPage.TabIndex = 1;
            this.ProductPage.Text = "Изделия";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // SelectType
            // 
            this.SelectType.Location = new System.Drawing.Point(81, 154);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(103, 36);
            this.SelectType.TabIndex = 14;
            this.SelectType.Text = "Выбрать";
            this.SelectType.UseVisualStyleBackColor = true;
            this.SelectType.Click += new System.EventHandler(this.SelectType_Click);
            // 
            // AlphaSort
            // 
            this.AlphaSort.AutoSize = true;
            this.AlphaSort.Location = new System.Drawing.Point(24, 249);
            this.AlphaSort.Name = "AlphaSort";
            this.AlphaSort.Size = new System.Drawing.Size(88, 25);
            this.AlphaSort.TabIndex = 13;
            this.AlphaSort.Text = "алфавит";
            this.AlphaSort.UseVisualStyleBackColor = true;
            this.AlphaSort.CheckedChanged += new System.EventHandler(this.AlphaSort_CheckedChanged);
            // 
            // TimeProdSort
            // 
            this.TimeProdSort.AutoSize = true;
            this.TimeProdSort.Location = new System.Drawing.Point(24, 217);
            this.TimeProdSort.Name = "TimeProdSort";
            this.TimeProdSort.Size = new System.Drawing.Size(174, 25);
            this.TimeProdSort.TabIndex = 12;
            this.TimeProdSort.Text = "время изготовления";
            this.TimeProdSort.UseVisualStyleBackColor = true;
            this.TimeProdSort.CheckedChanged += new System.EventHandler(this.TimeProdSort_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 21);
            this.label16.TabIndex = 11;
            this.label16.Text = "Сортировка";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 337);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 21);
            this.label15.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Тип изделия";
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(140, 107);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 29);
            this.TypeCombo.TabIndex = 7;
            this.TypeCombo.SelectedValueChanged += new System.EventHandler(this.TypeCombo_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 6;
            this.label13.Text = "Фильтрация";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Поиск";
            // 
            // spt
            // 
            this.spt.Location = new System.Drawing.Point(191, 27);
            this.spt.Name = "spt";
            this.spt.Size = new System.Drawing.Size(764, 29);
            this.spt.TabIndex = 2;
            this.spt.TextChanged += new System.EventHandler(this.spt_TextChanged);
            // 
            // ProductList
            // 
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Location = new System.Drawing.Point(276, 78);
            this.ProductList.Margin = new System.Windows.Forms.Padding(5);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(731, 394);
            this.ProductList.TabIndex = 0;
            // 
            // MaterialPage
            // 
            this.MaterialPage.Controls.Add(this.MaterialList);
            this.MaterialPage.Location = new System.Drawing.Point(4, 30);
            this.MaterialPage.Margin = new System.Windows.Forms.Padding(5);
            this.MaterialPage.Name = "MaterialPage";
            this.MaterialPage.Size = new System.Drawing.Size(1007, 482);
            this.MaterialPage.TabIndex = 2;
            this.MaterialPage.Text = "Материалы";
            this.MaterialPage.UseVisualStyleBackColor = true;
            // 
            // MaterialList
            // 
            this.MaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialList.Location = new System.Drawing.Point(5, 11);
            this.MaterialList.Margin = new System.Windows.Forms.Padding(5);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(726, 463);
            this.MaterialList.TabIndex = 0;
            // 
            // TypePage
            // 
            this.TypePage.Controls.Add(this.TypeList);
            this.TypePage.Location = new System.Drawing.Point(4, 30);
            this.TypePage.Margin = new System.Windows.Forms.Padding(5);
            this.TypePage.Name = "TypePage";
            this.TypePage.Size = new System.Drawing.Size(1007, 482);
            this.TypePage.TabIndex = 3;
            this.TypePage.Text = "Типы изделий";
            this.TypePage.UseVisualStyleBackColor = true;
            // 
            // TypeList
            // 
            this.TypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeList.Location = new System.Drawing.Point(167, 28);
            this.TypeList.Margin = new System.Windows.Forms.Padding(5);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(525, 507);
            this.TypeList.TabIndex = 0;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersList);
            this.OrdersPage.Location = new System.Drawing.Point(4, 30);
            this.OrdersPage.Margin = new System.Windows.Forms.Padding(5);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(5);
            this.OrdersPage.Size = new System.Drawing.Size(1007, 482);
            this.OrdersPage.TabIndex = 7;
            this.OrdersPage.Text = "Заказы";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersList
            // 
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersList.Location = new System.Drawing.Point(9, 10);
            this.OrdersList.Margin = new System.Windows.Forms.Padding(5);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.Size = new System.Drawing.Size(902, 575);
            this.OrdersList.TabIndex = 0;
            // 
            // ContractPage
            // 
            this.ContractPage.Controls.Add(this.ContractList);
            this.ContractPage.Location = new System.Drawing.Point(4, 30);
            this.ContractPage.Margin = new System.Windows.Forms.Padding(5);
            this.ContractPage.Name = "ContractPage";
            this.ContractPage.Size = new System.Drawing.Size(1007, 482);
            this.ContractPage.TabIndex = 4;
            this.ContractPage.Text = "Договоры";
            this.ContractPage.UseVisualStyleBackColor = true;
            // 
            // ContractList
            // 
            this.ContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractList.Location = new System.Drawing.Point(5, 5);
            this.ContractList.Margin = new System.Windows.Forms.Padding(5);
            this.ContractList.Name = "ContractList";
            this.ContractList.Size = new System.Drawing.Size(911, 585);
            this.ContractList.TabIndex = 0;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 30);
            this.Report.Margin = new System.Windows.Forms.Padding(5);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1007, 482);
            this.Report.TabIndex = 5;
            this.Report.Text = "Отчёты";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 62);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 604);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Menu.ResumeLayout(false);
            this.PlaceOrder.ResumeLayout(false);
            this.PlaceOrder.PerformLayout();
            this.ClientPage.ResumeLayout(false);
            this.ClientPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.MaterialPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).EndInit();
            this.TypePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).EndInit();
            this.OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            this.ContractPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContractList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage PlaceOrder;
        private System.Windows.Forms.TabPage ClientPage;
        private System.Windows.Forms.DataGridView ClientList;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.TabPage MaterialPage;
        private System.Windows.Forms.TabPage TypePage;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage ContractPage;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.DataGridView MaterialList;
        private System.Windows.Forms.DataGridView TypeList;
        private System.Windows.Forms.DataGridView OrdersList;
        private System.Windows.Forms.DataGridView ContractList;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete_Client;
        private System.Windows.Forms.Button All_Client;
        private System.Windows.Forms.Button Upd_Client;
        private System.Windows.Forms.Button Add_Client;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox name_sort;
        private System.Windows.Forms.CheckBox surname_sort;
        private System.Windows.Forms.CheckBox patronymic_sort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox spt;
        private System.Windows.Forms.CheckBox AlphaSort;
        private System.Windows.Forms.CheckBox TimeProdSort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SelectType;
    }
}