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
    public partial class UserForm : Form
    {
       public string login { get; set; }
        public UserForm(string user_name)
        {
            InitializeComponent();
            login = user_name;
            User_name_textbox.Text = login;
            
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            char Select = 'N';
            char Insert = 'N';
            char Update = 'N';
            char Delete = 'N';
            char Create = 'N';
            char Drop = 'N';
            char Grant = 'N';
            char References = 'N';
            char Index = 'N';
            char Alter = 'N';
            char Create_tmp_table = 'N';
            char Lock_tables = 'N';
            char Create_view = 'N';
            char Show_view = 'N';
            char Create_routine = 'N';
            char Alter_routine = 'N';
            char Execute = 'N';
            char Event = 'N';
            char Trigger = 'N';

            if (SelectBox.Checked) Select = 'Y';
            if (InsertBox.Checked) Insert = 'Y';
            if (UpdateBox.Checked) Update = 'Y';
            if (DeleteBox.Checked) Delete = 'Y';
            if (CreateBox.Checked) Create = 'Y';
            if (DropBox.Checked) Drop = 'Y';
            if (GrantBox.Checked) Grant = 'Y';
            if (ReferencesBox.Checked) References = 'Y';
            if (IndexBox.Checked) Index = 'Y';
            if (AlterBox.Checked) Alter = 'Y';
            if (Create_tmp_tableBox.Checked) Create_tmp_table = 'Y';
            if (Lock_tablesBox.Checked) Lock_tables = 'Y';
            if (Create_viewBox.Checked) Create_view = 'Y';
            if (Show_viewBox.Checked) Show_view = 'Y';
            if (Create_routineBox.Checked) Create_routine = 'Y';
            if (Alter_routineBox.Checked) Alter_routine = 'Y';
            if (ExecuteBox.Checked) Execute = 'Y';
            if (EventBox.Checked) Event = 'Y';
            if (TriggerBox.Checked) Trigger = 'Y';


            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO user_priv_form (user_name,Additional_info,Select_priv,Insert_priv,Update_priv,Delete_priv," +
                "Create_priv,Drop_priv,Grant_priv,References_priv,Index_priv,Alter_priv,Create_tmp_table_priv,Lock_tables_priv,Create_view_priv," +
                "Show_view_priv,Create_routine_priv,Alter_routine_priv,Execute_priv,Event_priv,Trigger_priv) " +
                "VALUES (@Login, @AddText, @Select, @Insert, @Update," +
                "@Delete, @Create, @Drop, @Grant, @References, @Index, @Alter, @Create_tmp_table, @Lock_tables, @Create_view," +
                "@Show_view, @Create_routine, @Alter_routine, @Execute, @Event, @Trigger)", dB.GetConnection());

            
            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = $"{login}"; 
            command.Parameters.Add("@AddText", MySqlDbType.VarChar).Value = AdditionalText.Text;
            command.Parameters.Add("@Select", MySqlDbType.Enum).Value = Select; 
            command.Parameters.Add("@Insert", MySqlDbType.Enum).Value = Insert; 
            command.Parameters.Add("@Update", MySqlDbType.Enum).Value = Update; 
            command.Parameters.Add("@Delete", MySqlDbType.Enum).Value = Delete; 
            command.Parameters.Add("@Create", MySqlDbType.Enum).Value = Create; 
            command.Parameters.Add("@Drop", MySqlDbType.Enum).Value = Drop;
            command.Parameters.Add("@Grant", MySqlDbType.Enum).Value = Grant; 
            command.Parameters.Add("@References", MySqlDbType.Enum).Value = References; 
            command.Parameters.Add("@Index", MySqlDbType.Enum).Value = Index; 
            command.Parameters.Add("@Alter", MySqlDbType.Enum).Value = Alter;  
            command.Parameters.Add("@Create_tmp_table", MySqlDbType.Enum).Value = Create_tmp_table;
            command.Parameters.Add("@Lock_tables", MySqlDbType.Enum).Value = Lock_tables; 
            command.Parameters.Add("@Create_view", MySqlDbType.Enum).Value = Create_view; 
            command.Parameters.Add("@Show_view", MySqlDbType.Enum).Value = Show_view; 
            command.Parameters.Add("@Create_routine", MySqlDbType.Enum).Value = Create_routine; 
            command.Parameters.Add("@Alter_routine", MySqlDbType.Enum).Value = Alter_routine; 
            command.Parameters.Add("@Execute", MySqlDbType.Enum).Value = Execute; 
            command.Parameters.Add("@Event", MySqlDbType.Enum).Value = Event; 
            command.Parameters.Add("@Trigger", MySqlDbType.Enum).Value = Trigger;

        
            dB.Open_connection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка успешно отправлена.");
                
            }
            else
            {
                MessageBox.Show("Ошибка отправки заявки.");
            }
            dB.Close_connection();
            
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
            
        }
    }
}
