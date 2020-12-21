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
    public partial class UpdMaster : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string qual { get; set; }
        public static string salary { get; set; }

        public UpdMaster()
        {
            InitializeComponent();
        }

        public UpdMaster(string ID, string Surname, string Name, string Patronymic, string Address, string Phone, string Qual, string Salary)
        {
            InitializeComponent();
            id = ID;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            address = Address;
            phone = Phone;
            qual = Qual;
            salary = Salary;
            LoadText();
            LoadQual();
        }

        public void LoadText()
        {
            SurnameText.Text = surname;
            NameText.Text = name;
            PatronimycText.Text = patronymic;
            AddressText.Text = address;
            PhoneText.Text = phone;
            QualList.DisplayMember = qual;
            SalaryText.Text = salary;
        }

        private void LoadQual()
        {
            SqlCommand sc = new SqlCommand("SELECT * FROM QUALIFICATION", DataBaseWork.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            QualList.DataSource = dt;
            QualList.DisplayMember = "APPELATION";
            QualList.ValueMember = "ID";
        }

        private void UpdMasterBut_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(QualList.SelectedValue);

            DataBaseWork.OpenCon();
            string save = String.Format("UPDATE {0} SET MAS_SURNAME = '{1}', MAS_NAME = '{2}',MAS_PATRONYMIC = '{3}', MAS_ADDRESS = '{4}', MAS_NUMBER = '{5}',ID_QUAL = {6},MAS_MONEY = '{7}'  WHERE ID = '{8}'", "MASTERS", SurnameText.Text, NameText.Text, PatronimycText.Text, AddressText.Text, PhoneText.Text,q,SalaryText.Text, id);
            SqlCommand com = new SqlCommand(save, DataBaseWork.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные о мастере успешно изменены");
        }
    }
}
