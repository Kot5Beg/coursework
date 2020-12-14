using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Main()
        {
            InitializeComponent();
            label6.Text = Manager.surname;
            label7.Text = Manager.name;
            label8.Text = Manager.patronymic;
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = DataBaseWork.Load(query);
            grid.DataSource = res;
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
            
        }

        private void ProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var image = ProductList.Rows[e.RowIndex].Cells[4].Value.ToString();
            ProductImage.ImageLocation = image;
            ProductImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Console.WriteLine(image);
        }
    }
}
