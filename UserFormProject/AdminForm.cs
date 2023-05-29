using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace UserFormProject
{
    public partial class AdminForm : Form
    {
        // TODO: Сделать поле "Дата обработки заявки" в бд и добавить логику в кнопки. 
        public AdminForm()
        {
            InitializeComponent();
            BaseFillGrid();
            GridView.Columns[0].Frozen = true; // замораживаем колонку с checkbox
            GridView.Columns["record_id"].Frozen = true; // замораживаем колонку с номером записи
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; // запрещает растягивать форму
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (User_name_textbox.Text == "")
            {
                BaseFillGrid();
                return;
            }

            UserFillAllGrid();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            int record_id = 0;
            string user_name = User_name_textbox.Text;
            List<string> YPrivList = new List<string>();
            DB dB = new DB();

            foreach (DataGridViewRow row in GridView.Rows) // перебор всех записей в гриде
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true) // если галочка стоит, то
                {

                    if (row.Cells["status"].Value.ToString() == "В обработке") // если совпадают значения
                    {
                        user_name = row.Cells["user_name"].Value.ToString();
                        record_id = Convert.ToInt32(row.Cells["record_id"].Value);

                        for (int i = 7; i < row.Cells.Count; i++) // Проверяем на наличие 'Y' в привилегиях
                        {
                            if (Convert.ToChar(row.Cells[i].Value) == 'Y')
                            {
                                YPrivList.Add(GridView.Columns[i].Name);
                            }
                        }
                    }

                }
            }

            PrivelegeAction("GRANT", "TO", user_name, YPrivList); // выдача привилегий

            // изменение статуса заявки
            
            MySqlCommand command = new MySqlCommand($"UPDATE user_priv_form SET status = 'Выполнено', dateOfAnswear = @time WHERE record_id = {record_id}", dB.GetConnection());
            command.Parameters.Add("@time", MySqlDbType.DateTime).Value = DateTime.Now;
            dB.Open_connection();

            command.ExecuteNonQuery();

            dB.Close_connection();

            UserFillAllGrid();
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            int record_id = 0;
            List<string> YPrivList = new List<string>();

            foreach (DataGridViewRow row in GridView.Rows) // перебор всех записей в гриде
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true) // если галочка стоит, то
                {

                    if (row.Cells["status"].Value.ToString() == "В обработке") // если совпадают значения
                    {
                        record_id = Convert.ToInt32(row.Cells["record_id"].Value);

                    }

                }
            }

            // изменение статуса заявки
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand($"UPDATE user_priv_form SET status = 'Отклонено', dateOfAnswear = @time WHERE record_id = {record_id}", dB.GetConnection());
            command.Parameters.Add("@time", MySqlDbType.DateTime);
            dB.Open_connection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменение внесено");
            }
            else
            {
                MessageBox.Show("Нет изменений");
            }

            dB.Close_connection();

            UserFillAllGrid();
        }

        private void RevokeButton_Click(object sender, EventArgs e)
        {
            int record_id = 0;
            string user_name = User_name_textbox.Text;
            List<string> YPrivList = new List<string>();
            DB dB = new DB();
            dB.Open_connection();
            foreach (DataGridViewRow row in GridView.Rows) // перебор всех записей в гриде
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true) // если галочка стоит, то
                {

                    if (row.Cells["status"].Value.ToString() == "Выполнено") // если совпадают значения
                    {
                        user_name = row.Cells["user_name"].Value.ToString();
                        record_id = Convert.ToInt32(row.Cells["record_id"].Value);

                        for (int i = 7; i < row.Cells.Count; i++) // Проверяем на наличие 'Y' в привилегиях
                        {
                            if (Convert.ToChar(row.Cells[i].Value) == 'Y')
                            {
                                YPrivList.Add(GridView.Columns[i].Name);

                            }
                        }
                      
                    }

                }
            }
            PrivelegeAction("GRANT", "TO", user_name, YPrivList); // выдача на случай отсутствия этих привилегий. Если такие есть, ничего не изменится.
            PrivelegeAction("REVOKE", "FROM", user_name, YPrivList); // отзыв привилегий

         //   изменение статуса заявки
            MySqlCommand command = new MySqlCommand($"UPDATE user_priv_form SET status = 'Отозвано', dateOfAnswear = @time WHERE record_id = {record_id}", dB.GetConnection());
            command.Parameters.Add("@time", MySqlDbType.DateTime).Value = DateTime.Now;
            dB.Open_connection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Изменение внесено");
            }
            else
            {
                MessageBox.Show("Нет изменений");
            }

            dB.Close_connection();

            UserFillAllGrid();
        }

        public void BaseFillGrid() // заполнение грида всеми доступными записями из таблицы user_priv_form
        {
            DB db = new DB();
            DataTable table = new DataTable();

            string sqlexpression = "SELECT record_id, user_name, dateOfApply, status, Additional_info  FROM user_priv_form";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlexpression, db.GetConnection());
            MySqlCommand command = new MySqlCommand(sqlexpression, db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.Open_connection();

            GridView.DataSource = table;

            GridView.Columns[0].Visible = false; // отключаем checkbox
            GridView.Columns[1].ReadOnly = true; // запрещаем изменение поля
            GridView.Columns[2].ReadOnly = true;
            GridView.Columns[3].ReadOnly = true;
            GridView.Columns[4].ReadOnly = true;
            GridView.Columns[5].ReadOnly = true;

            db.Close_connection();

        }
        public void UserFillAllGrid()
        {

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            string sqlexpression = $"SELECT * FROM user_priv_form WHERE user_name = @user_input";

            MySqlCommand command = new MySqlCommand(sqlexpression, db.GetConnection());
            command.Parameters.Add("@user_input", MySqlDbType.VarChar).Value = User_name_textbox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.Open_connection();

            if (table.Rows.Count >= 1) // если селект показал хотя бы 1 строку
            {
                GridView.DataSource = table;    // заполняем грид 
                GridView.Columns[0].Visible = true; // включаем checkbox 
                
                for (int i = 1; i < GridView.Columns.Count; i++)
                {
                    GridView.Columns[i].ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден.");
            }

            db.Close_connection();

        } // Обновление грида выбранного пользователя

        public void PrivelegeAction(string PrivCommand, string PrivPointer, string user_name, List<string> Ystrings) // действия с привилегиями по заявке (Выдача или Отзыв)
        {
            DB dB = new DB();
            foreach (var Priv in Ystrings) // перебор листа
            {
                switch (Priv) // выбор привилегии из листа Ystrings
                {
                    case "Select_priv":
                        {
                            MySqlCommand command1 = new MySqlCommand($"{PrivCommand} SELECT ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command1.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command1.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Insert_priv":
                        {
                            MySqlCommand command2 = new MySqlCommand($"{PrivCommand} INSERT ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command2.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command2.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Update_priv":
                        {
                            MySqlCommand command3 = new MySqlCommand($"{PrivCommand} UPDATE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command3.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command3.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Delete_priv":
                        {
                            MySqlCommand command4 = new MySqlCommand($"{PrivCommand} DELETE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command4.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command4.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Create_priv":
                        {
                            MySqlCommand command5 = new MySqlCommand($"{PrivCommand} CREATE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command5.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command5.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Drop_priv":
                        {
                            MySqlCommand command6 = new MySqlCommand($"{PrivCommand} DROP ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command6.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command6.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Grant_priv":
                        {
                            MySqlCommand command7 = new MySqlCommand($"{PrivCommand} GRANT OPTION ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command7.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command7.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "References_priv":
                        {
                            MySqlCommand command8 = new MySqlCommand($"{PrivCommand} REFERENCES ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command8.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command8.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Index_priv":
                        {
                            MySqlCommand command9 = new MySqlCommand($"{PrivCommand} INDEX ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command9.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command9.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Alter_priv":
                        {
                            MySqlCommand command10 = new MySqlCommand($"{PrivCommand} ALTER ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command10.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command10.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Create_tmp_table_priv":
                        {
                            MySqlCommand command11 = new MySqlCommand($"{PrivCommand} CREATE TEMPORARY TABLES ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command11.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command11.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Lock_tables_priv":
                        {
                            MySqlCommand command12 = new MySqlCommand($"{PrivCommand} LOCK TABLES ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command12.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command12.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Create_view_priv":
                        {
                            MySqlCommand command13 = new MySqlCommand($"{PrivCommand} CREATE VIEW ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command13.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command13.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Show_view_priv":
                        {
                            MySqlCommand command14 = new MySqlCommand($"{PrivCommand} SHOW VIEW ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command14.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command14.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Create_routine_priv":
                        {
                            MySqlCommand command15 = new MySqlCommand($"{PrivCommand} CREATE ROUTINE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command15.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command15.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Alter_routine_priv":
                        {
                            MySqlCommand command16 = new MySqlCommand($"{PrivCommand} ALTER ROUTINE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command16.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command16.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Execute_priv":
                        {
                            MySqlCommand command17 = new MySqlCommand($"{PrivCommand} EXECUTE ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command17.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command17.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Event_priv":
                        {
                            MySqlCommand command18 = new MySqlCommand($"{PrivCommand} EVENT ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command18.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command18.ExecuteNonQuery();
                            dB.Close_connection();
                            break;
                        }

                    case "Trigger_priv":
                        {
                            MySqlCommand command19 = new MySqlCommand($"{PrivCommand} TRIGGER ON kursach.* {PrivPointer} {user_name}@localhost", dB.GetConnection());
                            command19.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                            dB.Open_connection();

                            command19.ExecuteNonQuery();

                            dB.Close_connection();
                            break;
                        }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BaseFillGrid();
        }

        private void GridView_CurrentCellChanged(object sender, EventArgs e)
        {
            
                for (int i = 0; i < GridView.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(GridView.Rows[i].Cells[0].Value) == true)
                        GridView.Rows[i].Cells[0].Value = false;
                }
            
        }
    }
}
