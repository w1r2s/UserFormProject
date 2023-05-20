using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
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

            MySqlCommand command = new MySqlCommand("INSERT INTO user_priv_form VALUES (NULL, @Login, @AddText, @Select, @Insert, @Update," +
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

            MessageBox.Show("Заявка отппрравлена");

            if (Select == 'Y')
            {
                MySqlCommand command1 = new MySqlCommand($"GRANT SELECT ON kursach.* TO {login}@localhost",dB.GetConnection());
                command1.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command1.ExecuteReader();

                dB.Close_connection();
            }

            if (Insert == 'Y')
            {
                MySqlCommand command2 = new MySqlCommand($"GRANT INSERT ON kursach.* TO {login}@localhost", dB.GetConnection());
                command2.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command2.ExecuteReader();

                dB.Close_connection();
            }

            if (Update == 'Y')
            {
                MySqlCommand command3 = new MySqlCommand($"GRANT UPDATE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command3.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command3.ExecuteReader();

                dB.Close_connection();
            }

            if (Delete == 'Y')
            {
                MySqlCommand command4 = new MySqlCommand($"GRANT DELETE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command4.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command4.ExecuteReader();

                dB.Close_connection();
            }

            if (Create == 'Y')
            {
                MySqlCommand command5 = new MySqlCommand($"GRANT CREATE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command5.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command5.ExecuteReader();

                dB.Close_connection();
            }

            if (Drop == 'Y')
            {
                MySqlCommand command6 = new MySqlCommand($"GRANT DROP ON kursach.* TO {login}@localhost", dB.GetConnection());
                command6.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command6.ExecuteReader();

                dB.Close_connection();
            }

            if (Grant == 'Y')
            {
                MySqlCommand command7 = new MySqlCommand($"GRANT GRANT ON kursach.* TO {login}@localhost", dB.GetConnection());
                command7.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command7.ExecuteReader();

                dB.Close_connection();
            }

            if (References == 'Y')
            {
                MySqlCommand command8 = new MySqlCommand($"GRANT REFERENCES ON kursach.* TO {login}@localhost", dB.GetConnection());
                command8.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command8.ExecuteReader();

                dB.Close_connection();
            }

            if (Index == 'Y')
            {
                MySqlCommand command9 = new MySqlCommand($"GRANT INDEX ON kursach.* TO {login}@localhost", dB.GetConnection());
                command9.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command9.ExecuteReader();

                dB.Close_connection();
            }

            if (Alter == 'Y')
            {
                MySqlCommand command10 = new MySqlCommand($"GRANT ALTER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command10.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command10.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_tmp_table == 'Y')
            {
                MySqlCommand command11 = new MySqlCommand($"GRANT ALTER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command11.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command11.ExecuteReader();

                dB.Close_connection();
            }

            if (Lock_tables == 'Y')
            {
                MySqlCommand command12 = new MySqlCommand($"GRANT LOCK TABLES ON kursach.* TO {login}@localhost", dB.GetConnection());
                command12.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command12.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_view == 'Y')
            {
                MySqlCommand command13 = new MySqlCommand($"GRANT CREATE VIEW ON kursach.* TO {login}@localhost", dB.GetConnection());
                command13.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command13.ExecuteReader();

                dB.Close_connection();
            }

            if (Show_view == 'Y')
            {
                MySqlCommand command14 = new MySqlCommand($"GRANT SHOW VIEW ON kursach.* TO {login}@localhost", dB.GetConnection());
                command14.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command14.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_routine == 'Y')
            {
                MySqlCommand command15 = new MySqlCommand($"GRANT CREATE ROUTINE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command15.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command15.ExecuteReader();

                dB.Close_connection();
            }

            if (Alter_routine == 'Y')
            {
                MySqlCommand command16 = new MySqlCommand($"GRANT ALTER ROUTINE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command16.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command16.ExecuteReader();

                dB.Close_connection();
            }

            if (Execute == 'Y')
            {
                MySqlCommand command17 = new MySqlCommand($"GRANT EXECUTE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command17.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command17.ExecuteReader();

                dB.Close_connection();
            }

            if (Event == 'Y')
            {
                MySqlCommand command18 = new MySqlCommand($"GRANT EVENT ON kursach.* TO {login}@localhost", dB.GetConnection());
                command18.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command18.ExecuteReader();

                dB.Close_connection();
            }

            if (Trigger == 'Y')
            {
                MySqlCommand command19 = new MySqlCommand($"GRANT TRIGGER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command19.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command19.ExecuteReader();

                dB.Close_connection();
            }
            command.Parameters.Add("@Trigger", MySqlDbType.Enum).Value = Trigger;


            if (Select == 'Y')
            {
                MySqlCommand command1 = new MySqlCommand($"GRANT SELECT ON kursach.* TO {login}@localhost",dB.GetConnection());
                command1.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command1.ExecuteReader();

                dB.Close_connection();
            }

            if (Insert == 'Y')
            {
                MySqlCommand command2 = new MySqlCommand($"GRANT INSERT ON kursach.* TO {login}@localhost", dB.GetConnection());
                command2.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command2.ExecuteReader();

                dB.Close_connection();
            }

            if (Update == 'Y')
            {
                MySqlCommand command3 = new MySqlCommand($"GRANT UPDATE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command3.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command3.ExecuteReader();

                dB.Close_connection();
            }

            if (Delete == 'Y')
            {
                MySqlCommand command4 = new MySqlCommand($"GRANT DELETE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command4.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command4.ExecuteReader();

                dB.Close_connection();
            }

            if (Create == 'Y')
            {
                MySqlCommand command5 = new MySqlCommand($"GRANT CREATE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command5.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command5.ExecuteReader();

                dB.Close_connection();
            }

            if (Drop == 'Y')
            {
                MySqlCommand command6 = new MySqlCommand($"GRANT DROP ON kursach.* TO {login}@localhost", dB.GetConnection());
                command6.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command6.ExecuteReader();

                dB.Close_connection();
            }

            if (Grant == 'Y')
            {
                MySqlCommand command7 = new MySqlCommand($"GRANT GRANT OPTION ON kursach.* TO {login}@localhost", dB.GetConnection());
                command7.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command7.ExecuteReader();

                dB.Close_connection();
            }

            if (References == 'Y')
            {
                MySqlCommand command8 = new MySqlCommand($"GRANT REFERENCES ON kursach.* TO {login}@localhost", dB.GetConnection());
                command8.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command8.ExecuteReader();

                dB.Close_connection();
            }

            if (Index == 'Y')
            {
                MySqlCommand command9 = new MySqlCommand($"GRANT INDEX ON kursach.* TO {login}@localhost", dB.GetConnection());
                command9.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command9.ExecuteReader();

                dB.Close_connection();
            }

            if (Alter == 'Y')
            {
                MySqlCommand command10 = new MySqlCommand($"GRANT ALTER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command10.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command10.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_tmp_table == 'Y')
            {
                MySqlCommand command11 = new MySqlCommand($"GRANT ALTER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command11.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command11.ExecuteReader();

                dB.Close_connection();
            }

            if (Lock_tables == 'Y')
            {
                MySqlCommand command12 = new MySqlCommand($"GRANT LOCK TABLES ON kursach.* TO {login}@localhost", dB.GetConnection());
                command12.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command12.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_view == 'Y')
            {
                MySqlCommand command13 = new MySqlCommand($"GRANT CREATE VIEW ON kursach.* TO {login}@localhost", dB.GetConnection());
                command13.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command13.ExecuteReader();

                dB.Close_connection();
            }

            if (Show_view == 'Y')
            {
                MySqlCommand command14 = new MySqlCommand($"GRANT SHOW VIEW ON kursach.* TO {login}@localhost", dB.GetConnection());
                command14.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command14.ExecuteReader();

                dB.Close_connection();
            }

            if (Create_routine == 'Y')
            {
                MySqlCommand command15 = new MySqlCommand($"GRANT CREATE ROUTINE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command15.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command15.ExecuteReader();

                dB.Close_connection();
            }

            if (Alter_routine == 'Y')
            {
                MySqlCommand command16 = new MySqlCommand($"GRANT ALTER ROUTINE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command16.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command16.ExecuteReader();

                dB.Close_connection();
            }

            if (Execute == 'Y')
            {
                MySqlCommand command17 = new MySqlCommand($"GRANT EXECUTE ON kursach.* TO {login}@localhost", dB.GetConnection());
                command17.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command17.ExecuteReader();

                dB.Close_connection();
            }

            if (Event == 'Y')
            {
                MySqlCommand command18 = new MySqlCommand($"GRANT EVENT ON kursach.* TO {login}@localhost", dB.GetConnection());
                command18.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command18.ExecuteReader();

                dB.Close_connection();
            }

            if (Trigger == 'Y')
            {
                MySqlCommand command19 = new MySqlCommand($"GRANT TRIGGER ON kursach.* TO {login}@localhost", dB.GetConnection());
                command19.Parameters.Add("@localhost", MySqlDbType.VarChar).Value = "@'localhost'";
                dB.Open_connection();

                command19.ExecuteReader();

                dB.Close_connection();
            }

            dB.Open_connection();



            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка успешно отправлена.");
                

                authorization.Show();

            }
            else
            {
                MessageBox.Show("Ошибка отправки заявки.");
            }
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
            
            dB.Close_connection();
        }

        
    }
}
