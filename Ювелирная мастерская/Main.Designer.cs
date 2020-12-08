namespace Ювелирная_мастерская
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
            this.ClientPage = new System.Windows.Forms.TabPage();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.ClientList = new System.Windows.Forms.DataGridView();
            this.MaterialPage = new System.Windows.Forms.TabPage();
            this.TypePage = new System.Windows.Forms.TabPage();
            this.ContractPage = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.PlaceOrder = new System.Windows.Forms.TabPage();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.MaterialList = new System.Windows.Forms.DataGridView();
            this.TypeList = new System.Windows.Forms.DataGridView();
            this.OrdersList = new System.Windows.Forms.DataGridView();
            this.ContractList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.ClientPage.SuspendLayout();
            this.ProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            this.MaterialPage.SuspendLayout();
            this.TypePage.SuspendLayout();
            this.ContractPage.SuspendLayout();
            this.PlaceOrder.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractList)).BeginInit();
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
            this.Menu.Location = new System.Drawing.Point(13, 25);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(621, 394);
            this.Menu.TabIndex = 0;
            // 
            // ClientPage
            // 
            this.ClientPage.Controls.Add(this.ClientList);
            this.ClientPage.Location = new System.Drawing.Point(4, 22);
            this.ClientPage.Name = "ClientPage";
            this.ClientPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClientPage.Size = new System.Drawing.Size(613, 368);
            this.ClientPage.TabIndex = 0;
            this.ClientPage.Text = "Клиенты";
            this.ClientPage.UseVisualStyleBackColor = true;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.ProductList);
            this.ProductPage.Location = new System.Drawing.Point(4, 22);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(613, 368);
            this.ProductPage.TabIndex = 1;
            this.ProductPage.Text = "Изделия";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // ClientList
            // 
            this.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientList.Location = new System.Drawing.Point(6, 6);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(601, 356);
            this.ClientList.TabIndex = 0;
            // 
            // MaterialPage
            // 
            this.MaterialPage.Controls.Add(this.MaterialList);
            this.MaterialPage.Location = new System.Drawing.Point(4, 22);
            this.MaterialPage.Name = "MaterialPage";
            this.MaterialPage.Size = new System.Drawing.Size(613, 368);
            this.MaterialPage.TabIndex = 2;
            this.MaterialPage.Text = "Материалы";
            this.MaterialPage.UseVisualStyleBackColor = true;
            // 
            // TypePage
            // 
            this.TypePage.Controls.Add(this.TypeList);
            this.TypePage.Location = new System.Drawing.Point(4, 22);
            this.TypePage.Name = "TypePage";
            this.TypePage.Size = new System.Drawing.Size(613, 368);
            this.TypePage.TabIndex = 3;
            this.TypePage.Text = "Типы изделий";
            this.TypePage.UseVisualStyleBackColor = true;
            // 
            // ContractPage
            // 
            this.ContractPage.Controls.Add(this.ContractList);
            this.ContractPage.Location = new System.Drawing.Point(4, 22);
            this.ContractPage.Name = "ContractPage";
            this.ContractPage.Size = new System.Drawing.Size(613, 368);
            this.ContractPage.TabIndex = 4;
            this.ContractPage.Text = "Договоры";
            this.ContractPage.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 22);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(613, 368);
            this.Report.TabIndex = 5;
            this.Report.Text = "Отчёты";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // PlaceOrder
            // 
            this.PlaceOrder.Controls.Add(this.button1);
            this.PlaceOrder.Controls.Add(this.label5);
            this.PlaceOrder.Controls.Add(this.label4);
            this.PlaceOrder.Controls.Add(this.label3);
            this.PlaceOrder.Controls.Add(this.label2);
            this.PlaceOrder.Controls.Add(this.label1);
            this.PlaceOrder.Location = new System.Drawing.Point(4, 22);
            this.PlaceOrder.Name = "PlaceOrder";
            this.PlaceOrder.Size = new System.Drawing.Size(613, 368);
            this.PlaceOrder.TabIndex = 6;
            this.PlaceOrder.Text = "Оформить заказ";
            this.PlaceOrder.UseVisualStyleBackColor = true;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OrdersList);
            this.OrdersPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(613, 368);
            this.OrdersPage.TabIndex = 7;
            this.OrdersPage.Text = "Заказы";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // ProductList
            // 
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Location = new System.Drawing.Point(6, 6);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(601, 356);
            this.ProductList.TabIndex = 0;
            // 
            // MaterialList
            // 
            this.MaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialList.Location = new System.Drawing.Point(3, 3);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(607, 362);
            this.MaterialList.TabIndex = 0;
            // 
            // TypeList
            // 
            this.TypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeList.Location = new System.Drawing.Point(111, 17);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(350, 314);
            this.TypeList.TabIndex = 0;
            // 
            // OrdersList
            // 
            this.OrdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersList.Location = new System.Drawing.Point(6, 6);
            this.OrdersList.Name = "OrdersList";
            this.OrdersList.Size = new System.Drawing.Size(601, 356);
            this.OrdersList.TabIndex = 0;
            // 
            // ContractList
            // 
            this.ContractList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractList.Location = new System.Drawing.Point(3, 3);
            this.ContractList.Name = "ContractList";
            this.ContractList.Size = new System.Drawing.Size(607, 362);
            this.ContractList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.Menu);
            this.Name = "Main";
            this.Text = "Main";
            this.Menu.ResumeLayout(false);
            this.ClientPage.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            this.MaterialPage.ResumeLayout(false);
            this.TypePage.ResumeLayout(false);
            this.ContractPage.ResumeLayout(false);
            this.PlaceOrder.ResumeLayout(false);
            this.PlaceOrder.PerformLayout();
            this.OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractList)).EndInit();
            this.ResumeLayout(false);

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
    }
}