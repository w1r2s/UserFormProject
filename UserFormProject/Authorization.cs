using MySql.Data.MySqlClient;
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
    public partial class Authorization : Form
    {
       
        public Authorization()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width,32);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login_user = LoginField.Text;
            string pass_user = PassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE user_name = @uL AND user_pass = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_user;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass_user;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                UserForm userForm = new UserForm(login_user);
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
