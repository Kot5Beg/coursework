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
    public partial class UpdTP : Form
    {
        public static string id { get; set; }
        public static string appelation { get; set; }

        public UpdTP()
        {
            InitializeComponent();
        }

        public UpdTP(string ID, string Appelation)
        {
            InitializeComponent();
            id = ID;
            appelation = Appelation;
            TextLoad();
        }

        public void TextLoad()
        {
            ApText.Text = appelation;
        }

        private void UpdTypeBut_Click(object sender, EventArgs e)
        {
            DataBaseWork.OpenCon();
            string upd = String.Format("UPDATE {0} SET NAME_TYPE = '{1}' WHERE ID = '{2}'", "PRODUCT_TYPE", ApText.Text, id);
            SqlCommand sc = new SqlCommand(upd, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Данные типа изделий успешно изменены.");
            DataBaseWork.CloseConnection();
        }
    }
}
