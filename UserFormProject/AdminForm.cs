using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UserFormProject
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            BaseFillGrid();
            }
        public AdminForm(string admin_name)
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

        }

       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (User_name_textbox.Text == "")
            {
                BaseFillGrid();
                return;
            }

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable table = new DataTable();

            string sqlexpression = $"SELECT * FROM user_priv_form WHERE user_name = @user_input";

            MySqlCommand command = new MySqlCommand(sqlexpression, db.GetConnection());
            command.Parameters.Add("@user_input", MySqlDbType.VarChar).Value = User_name_textbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.Fill(ds);

            db.Open_connection();


            MessageBox.Show("Соединение");

                if (table.Rows.Count >= 1)
                {
                MessageBox.Show("Совпадение");

                    GridView.DataSource = ds.Tables[0];
                    GridView.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Совпадений нет");
                }

            
            db.Close_connection();
        }

        public void BaseFillGrid()
        {
            DB db = new DB();

            string sqlexpression = "SELECT record_id, user_name, dafeOfApply, completed, Additional_info  FROM user_priv_form";

            MySqlCommand command = new MySqlCommand(sqlexpression, db.GetConnection());

            db.Open_connection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexpression, db.GetConnection());

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            GridView.DataSource = ds.Tables[0];
            GridView.ReadOnly = true;

            db.Close_connection();
            
        }
        
    }
    
}
