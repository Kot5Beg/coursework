﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ювелирная_мастерская
{
    public partial class Main : Form
    {
        public static DataTable res;
        string i;
        public Main()
        {
            InitializeComponent();
            label6.Text = Manager.surname;
            label7.Text = Manager.name;
            label8.Text = Manager.patronymic;
            LoadCombo();
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = DataBaseWork.Load(query);
            grid.DataSource = res;
            grid.Columns["ID"].Visible = false;
            
        }

        private void Menu_Selected(object sender, TabControlEventArgs e)
        {
            if(Menu.SelectedTab == ClientPage)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, ClientList);

            }
            else if(Menu.SelectedTab == ProductPage)
            {
                string product = "SELECT * FROM PRODUCT";
                Loading(product, ProductList);
                LoadType();
            }
            else if (Menu.SelectedTab == MaterialPage)
            {
                string product = "SELECT * FROM MATERIALS";
                Loading(product, MaterialList);
            }
            else if (Menu.SelectedTab == TypePage)
            {
                string type = "SELECT * FROM PRODUCT_TYPE";
                Loading(type, TypeList);
            }
            else if (Menu.SelectedTab == OrdersPage)
            {
                string order = "SELECT * FROM ORDERS";
                Loading(order, OrdersList);
            }
            else if (Menu.SelectedTab == ContractPage)
            {
                string contract = "SELECT * FROM CONTRACTS WHERE ID_MANAGER = '"+Manager.id+"';";
                Loading(contract, ContractList);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Add_Client_Click(object sender, EventArgs e)
        {
            Add_Client ac = new Add_Client();
            ac.ShowDialog();
        }

        private void Delete_Client_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Client.DeleteClient(ClientList);
                    MessageBox.Show("Данные о клиенте удалены");
                    Loading("SELECT * FROM CLIENTS", ClientList);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void All_Client_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM CLIENTS";
            Loading(client, ClientList);
        }

        private void Upd_Client_Click(object sender, EventArgs e)
        {
            List<string> client = new List<string>();
            var number = ClientList.CurrentCell.RowIndex;
            DataGridViewRow row = ClientList.Rows[number];
            Upd_Client uc = new Upd_Client(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString());
            uc.ShowDialog();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            string client = "SELECT * FROM CLIENTS WHERE CONCAT (C_SURNAME, C_NAME, C_PATRONYMIC, C_ADDRESS, C_NUMBER) LIKE '%" + SearchText.Text +"%' ";
            Loading(client, ClientList);

        }

        private void ProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void surname_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (surname_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_SURNAME ASC";
                Loading(client, ClientList);
                name_sort.Enabled = false;
                patronymic_sort.Enabled = false;
            }
            else if (surname_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, ClientList);
                name_sort.Enabled = true;
                patronymic_sort.Enabled = true;
            }
        }

        private void name_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (name_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_NAME ASC";
                Loading(client, ClientList);
                surname_sort.Enabled = false;
                patronymic_sort.Enabled = false;
            }
            else if (name_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, ClientList);
                surname_sort.Enabled = true;
                patronymic_sort.Enabled = true;
            }
        }

        private void patronymic_sort_CheckedChanged(object sender, EventArgs e)
        {
            if (patronymic_sort.Checked == true)
            {
                string client = "SELECT * FROM CLIENTS ORDER BY C_PATRONYMIC ASC";
                Loading(client, ClientList);
                name_sort.Enabled = false;
                surname_sort.Enabled = false;
            }
            else if (patronymic_sort.Checked == false)
            {
                string client = "SELECT * FROM CLIENTS";
                Loading(client, ClientList);
                name_sort.Enabled = true;
                surname_sort.Enabled = true;
            }
        }

        private void spt_TextChanged(object sender, EventArgs e)
        {
            string product = "SELECT * FROM PRODUCT WHERE CONCAT (APPELATION, P_TYPE, TIME_PROD) LIKE '%" + spt.Text + "%' ";
            Loading(product, ProductList);
        }

        private void LoadType()
        {
            SqlCommand sc = new SqlCommand("SELECT * FROM PRODUCT_TYPE", DataBaseWork.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            TypeCombo.DataSource = dt;
            TypeCombo.DisplayMember = "NAME_TYPE";
            TypeCombo.ValueMember = "ID";
            TypeCombo.SelectedIndex = 0;
        }

        private void SelectType_Click(object sender, EventArgs e)
        {
            string FilterProduct = "SELECT * FROM PRODUCT WHERE P_TYPE = '"+i+"'";
            Loading(FilterProduct, ProductList);
        }

        private void TypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            i = TypeCombo.SelectedValue.ToString();
        }

        private void TimeProdSort_CheckedChanged(object sender, EventArgs e)
        {
            if (TimeProdSort.Checked == true)
            {
                string prodtime = "SELECT * FROM PRODUCT ORDER BY TIME_PROD ASC";
                Loading(prodtime, ProductList);
                AlphaSort.Enabled = false;
            }
            else if (TimeProdSort.Checked == false)
            {
                string products = "SELECT * FROM PRODUCT";
                Loading(products, ProductList);
                AlphaSort.Enabled = true;
            }
        }

        private void AlphaSort_CheckedChanged(object sender, EventArgs e)
        {
            if (AlphaSort.Checked == true)
            {
                string prodalpha = "SELECT * FROM PRODUCT ORDER BY APPELATION ASC";
                Loading(prodalpha, ProductList);
                TimeProdSort.Enabled = false;
            }
            else if (AlphaSort.Checked == false)
            {
                string products = "SELECT * FROM PRODUCT";
                Loading(products, ProductList);
                TimeProdSort.Enabled = true;
            }
        }

        private void ExitAccount_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LoadCombo()
        {
            DataBaseWork.OpenCon();

            SqlCommand sc = new SqlCommand("SELECT * FROM PRODUCT", DataBaseWork.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            ProdList.DataSource = dt;
            ProdList.DisplayMember = "APPELATION";
            ProdList.ValueMember = "ID";
            ProdList.SelectedIndex = 0;

            SqlCommand sc1 = new SqlCommand("SELECT * FROM MATERIALS", DataBaseWork.Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(sc1);
            da1.Fill(dt1);
            MatList.DataSource = dt1;
            MatList.DisplayMember = "APPELATION";
            MatList.ValueMember = "ID";
            

            SqlCommand sc2 = new SqlCommand("SELECT * FROM MASTERS", DataBaseWork.Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sc2);
            da2.Fill(dt2);
            MasList.DataSource = dt2;
            MasList.DisplayMember = "MAS_SURNAME";
            MasList.ValueMember = "ID";
           

            SqlCommand sc3 = new SqlCommand("SELECT * FROM CLIENTS", DataBaseWork.Con);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(sc3);
            da3.Fill(dt3);
            CliList.DataSource = dt3;
            CliList.DisplayMember = "C_SURNAME";
            CliList.ValueMember = "ID";
            CliList.SelectedIndex = 0;

            SqlCommand sc4 = new SqlCommand("SELECT * FROM ORDERS", DataBaseWork.Con);
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(sc4);
            da4.Fill(dt4);
            OrderNum.DataSource = dt4;
            OrderNum.DisplayMember = "ID";
            OrderNum.ValueMember = "ID";
            DataBaseWork.CloseConnection();
        }

        private void OrderBut_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(ProdList.SelectedValue);
            int mat = Convert.ToInt32(MatList.SelectedValue);
            int mas = Convert.ToInt32(MasList.SelectedValue);
            decimal pr = Convert.ToDecimal(PriceEnd.Text);
            string time = TimeProd.Text;
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO ORDERS (ID_PRODUCT,ID_MATERIAL, ID_MASTER, PRICE, TIME_PROD ) VALUES (" + p + ", " + mat + ", " + mas + ", " + pr + ", '" + time + "')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Заказ успешно добавлен");
        }

        private void ContrBut_Click(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(OrderNum.SelectedValue);
            int client = Convert.ToInt32(CliList.SelectedValue);
            
            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO CONTRACTS (ID_ORDER,ID_CLIENT, ID_MANAGER, DATE_CONTR) VALUES (" + o + ", " + client + ", " + Manager.id + ", '"+ DateContr.Value.Date + "')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Договор успешно добавлен");
        }
    }
}
