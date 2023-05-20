﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserFormProject
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 32);
        }

       

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            if (FirstnameField.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (LastnameField.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }

            if (LoginField.Text == "")
            {
                MessageBox.Show("Введите имя пользователя");
                return;
            }

            if (PassField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (IsRegistredUser() == true)
            {
                return;
            }

            DB dB = new DB();
              
            MySqlCommand command = new MySqlCommand($"CREATE USER {LoginField.Text}@localhost IDENTIFIED BY @Pass", dB.GetConnection());
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@localhost";

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginField.Text;
            command.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@FName", MySqlDbType.VarChar).Value = FirstnameField.Text;
            command.Parameters.Add("@LName", MySqlDbType.VarChar).Value = LastnameField.Text;
          

            MySqlCommand command1 = new MySqlCommand($"CREATE USER {LoginField.Text}@localhost IDENTIFIED BY @Pass", dB.GetConnection());
            command1.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = PassField.Text;
            command1.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
           

            dB.Open_connection();

            command.ExecuteNonQuery();
        
            if (command1.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация прошла успешно");

            }
            else
            {
                MessageBox.Show("Ошибка регистрации");
            }

            command1.ExecuteReader();

            dB.Close_connection();

            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        public Boolean IsRegistredUser()
        {
            
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE user_name = @Login", db.GetConnection());
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return true;
            }

            return false;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
