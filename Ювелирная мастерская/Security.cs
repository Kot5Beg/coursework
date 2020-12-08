﻿using System;
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
    public partial class Security : Form
    {
        public static int id;

        public Security()
        {
            InitializeComponent();
        }

        private void Entry_Click(object sender, EventArgs e)
        {
            if (LoginText.Text == "" || PassText.Text == "")
            {
                if (MessageBox.Show("Заполните поля!") == DialogResult.OK)
                    Focus();
            }
            else
                Check();
        }

        private void Check()
        {
            DataBaseWork.OpenCon();

            string login = Convert.ToString(LoginText.Text);
            string password = Convert.ToString(PassText.Text);
            int i = 0;

            string security = "SELECT * FROM MANAGERS WHERE MANAGER_LOGIN = '" + login + "' AND MANAGER_PASSWORD = '" + password + "';";

            SqlCommand sc = new SqlCommand(security, DataBaseWork.Con);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sc);


            sda.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                if (MessageBox.Show("Ошибка авторизации\nПопробуйте ещё раз!") == DialogResult.OK)
                {
                    Focus();
                    CleanText();
                }
            }
            else
            {
                SqlDataReader read = sc.ExecuteReader();
                while (read.Read())
                {
                    id = Convert.ToInt32(read.GetValue(0).ToString());
                }
                Main main = new Main();
                main.Show();
                Hide();
            }

            DataBaseWork.CloseConnection();
        }

        private void PassEye_Click(object sender, EventArgs e)
        {
            if (PassEye.Text == "Скрыть пароль")
            {
                PassText.PasswordChar = '*';
                PassEye.Text = "Показать пароль";
            }
            else
            {
                PassText.PasswordChar = '\0';
                PassEye.Text = "Скрыть пароль";
            }
        }

        private void CleanText()
        {
            LoginText.Clear();
            PassText.Clear();
            LoginText.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            CleanText();
        }
    }
}
