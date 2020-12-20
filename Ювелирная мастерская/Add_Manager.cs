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
    public partial class Add_Manager : Form
    {
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            try
            {
                Manager.AddManager(SurnameText.Text, NameText.Text, PatronymicText.Text, AddressText.Text, PhoneText.Text, SalaryText.Text, LoginText.Text, PasswordText.Text);
                MessageBox.Show("Менеджер успешно добавлен в базу.");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления.\nПопробуйте ещё раз");
            }
        }
    }
}
