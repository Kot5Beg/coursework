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
    public partial class AddMaster : Form
    {
        public AddMaster()
        {
            InitializeComponent();
            LoadQual();
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

        private void AddMasterBut_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(QualList.SelectedValue);

            DataBaseWork.OpenCon();
            string add = String.Format("INSERT INTO MASTERS (MAS_SURNAME, MAS_NAME, MAS_PATRONYMIC, MAS_ADDRESS, MAS_NUMBER, ID_QUAL, MAS_MONEY) VALUES ('"+SurnameText.Text+"', '"+NameText.Text+"', '"+PatronimycText.Text+"', '"+AddressText.Text+"', '"+PhoneText.Text+"', "+q+", '"+SalaryText.Text+"')");
            SqlCommand sc = new SqlCommand(add, DataBaseWork.Con);
            sc.ExecuteNonQuery();
            DataBaseWork.CloseConnection();
            MessageBox.Show("Мастер успешно добавлен");
        }
    }
}
