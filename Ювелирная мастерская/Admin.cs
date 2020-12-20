using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ювелирная_мастерская
{
    public partial class Admin : Form
    {
        public static DataTable res;
        string manager = "SELECT * FROM MANAGERS";
        string master = "SELECT * FROM MASTERS";
        string qual = "SELECT * FROM QUALIFICATION";
        string product = "SELECT * FROM PRODUCT";
        string material = "SELECT * FROM MATERIALS";
        string type = "SELECT * FROM PRODUCT_TYPE";

        public Admin()
        {
            InitializeComponent();
            Main.Loading(manager, ManagerList);
        }

        private void AdminPanel_Selected(object sender, TabControlEventArgs e)
        {
            if (AdminPanel.SelectedTab == Managers)
            {
                Main.Loading(manager, ManagerList);
            }
            else if (AdminPanel.SelectedTab == Masters)
            {
                Main.Loading(master, MasterList);
            }
            else if (AdminPanel.SelectedTab == Qualification)
            {
                Main.Loading(qual, QualList);
            }
            else if (AdminPanel.SelectedTab == Products)
            {
                Main.Loading(product, ProductList);
            }
            else if (AdminPanel.SelectedTab == Products_Type)
            {
                Main.Loading(type, TypeList);
            }
            else if (AdminPanel.SelectedTab == Materials)
            {
                Main.Loading(material, MaterialList);
            }
        }

        private void Add_Manager_Click(object sender, EventArgs e)
        {
            Add_Manager am = new Add_Manager();
            am.ShowDialog();
        }

        private void Update_Manager_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = ManagerList.CurrentCell.RowIndex;
            DataGridViewRow row = ManagerList.Rows[number];
            UpdManager um = new UpdManager(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                row.Cells[7].Value.ToString(),
                row.Cells[8].Value.ToString());
            um.ShowDialog();
        }

        private void Delete_Manager_Click(object sender, EventArgs e)
        {
            Manager.DeleteManager(ManagerList);
            MessageBox.Show("Данные менеджера удалены из базы");
        }
    }
}
