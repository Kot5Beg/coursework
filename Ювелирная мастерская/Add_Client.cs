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
    public partial class Add_Client : Form
    {
        public Add_Client()
        {
            InitializeComponent();
        }

        private void Save_Client_Click(object sender, EventArgs e)
        {
            try
            {
                Client.AddClient(Surname_Client.Text, Name_Client.Text, Patronymic_Client.Text, Address_Client.Text, Phone_Client.Text);
                MessageBox.Show("Клиент успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления.\nПопробуйте ещё раз");
            }
        }
    }
}
