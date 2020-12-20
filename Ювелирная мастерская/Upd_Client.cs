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
    public partial class Upd_Client : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }

        public Upd_Client()
        {
            InitializeComponent();
        }

        public Upd_Client(string ID, string Surname, string Name, string Patronymic, string Address, string Phone)
        {
            InitializeComponent();
            id = ID;
            surname = Surname;
            name = Name;
            patronymic = Patronymic;
            address = Address;
            phone = Phone;
            TextLoad();
        }

        public void TextLoad()
        {
            Surname_Client.Text = surname;
            Name_Client.Text = name;
            Patronymic_Client.Text = patronymic;
            Address_Client.Text = address;
            Phone_Client.Text = phone;
        }

        private void Save_Client_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseWork.OpenCon();
                string save = String.Format("UPDATE {0} SET C_SURNAME = '{1}', C_NAME = '{2}',C_PATRONYMIC = '{3}', C_ADDRESS = '{4}', C_NUMBER = '{5}' WHERE ID = '{6}'", "CLIENTS", Surname_Client.Text, Name_Client.Text, Patronymic_Client.Text, Address_Client.Text, Phone_Client.Text, id);
                SqlCommand com = new SqlCommand(save, DataBaseWork.Con);
                com.ExecuteNonQuery();
                MessageBox.Show("Успех!");
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
