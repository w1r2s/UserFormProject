namespace UserFormProject
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.AdditionalText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectBox = new System.Windows.Forms.CheckBox();
            this.InsertBox = new System.Windows.Forms.CheckBox();
            this.UpdateBox = new System.Windows.Forms.CheckBox();
            this.User_name_lable = new System.Windows.Forms.Label();
            this.User_name_textbox = new System.Windows.Forms.TextBox();
            this.DeleteBox = new System.Windows.Forms.CheckBox();
            this.CreateBox = new System.Windows.Forms.CheckBox();
            this.DropBox = new System.Windows.Forms.CheckBox();
            this.GrantBox = new System.Windows.Forms.CheckBox();
            this.ReferencesBox = new System.Windows.Forms.CheckBox();
            this.IndexBox = new System.Windows.Forms.CheckBox();
            this.AlterBox = new System.Windows.Forms.CheckBox();
            this.TriggerBox = new System.Windows.Forms.CheckBox();
            this.EventBox = new System.Windows.Forms.CheckBox();
            this.ExecuteBox = new System.Windows.Forms.CheckBox();
            this.Alter_routineBox = new System.Windows.Forms.CheckBox();
            this.Create_routineBox = new System.Windows.Forms.CheckBox();
            this.Show_viewBox = new System.Windows.Forms.CheckBox();
            this.Create_viewBox = new System.Windows.Forms.CheckBox();
            this.Lock_tablesBox = new System.Windows.Forms.CheckBox();
            this.Create_tmp_tableBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(662, 391);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(555, 391);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(101, 29);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Отправить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AdditionalText
            // 
            this.AdditionalText.Location = new System.Drawing.Point(39, 178);
            this.AdditionalText.Multiline = true;
            this.AdditionalText.Name = "AdditionalText";
            this.AdditionalText.Size = new System.Drawing.Size(448, 242);
            this.AdditionalText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Опишите причину заявки";
            // 
            // SelectBox
            // 
            this.SelectBox.AutoSize = true;
            this.SelectBox.Location = new System.Drawing.Point(524, 85);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(71, 24);
            this.SelectBox.TabIndex = 4;
            this.SelectBox.Text = "Select";
            this.SelectBox.UseVisualStyleBackColor = true;
            // 
            // InsertBox
            // 
            this.InsertBox.AutoSize = true;
            this.InsertBox.Location = new System.Drawing.Point(524, 115);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(67, 24);
            this.InsertBox.TabIndex = 5;
            this.InsertBox.Text = "Insert";
            this.InsertBox.UseVisualStyleBackColor = true;
            // 
            // UpdateBox
            // 
            this.UpdateBox.AutoSize = true;
            this.UpdateBox.Location = new System.Drawing.Point(524, 145);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(80, 24);
            this.UpdateBox.TabIndex = 6;
            this.UpdateBox.Text = "Update";
            this.UpdateBox.UseVisualStyleBackColor = true;
            // 
            // User_name_lable
            // 
            this.User_name_lable.AutoSize = true;
            this.User_name_lable.Location = new System.Drawing.Point(104, 58);
            this.User_name_lable.Name = "User_name_lable";
            this.User_name_lable.Size = new System.Drawing.Size(114, 20);
            this.User_name_lable.TabIndex = 24;
            this.User_name_lable.Text = "Пользователь :";
            // 
            // User_name_textbox
            // 
            this.User_name_textbox.Location = new System.Drawing.Point(224, 55);
            this.User_name_textbox.Name = "User_name_textbox";
            this.User_name_textbox.ReadOnly = true;
            this.User_name_textbox.Size = new System.Drawing.Size(183, 27);
            this.User_name_textbox.TabIndex = 25;
            // 
            // DeleteBox
            // 
            this.DeleteBox.AutoSize = true;
            this.DeleteBox.Location = new System.Drawing.Point(524, 175);
            this.DeleteBox.Name = "DeleteBox";
            this.DeleteBox.Size = new System.Drawing.Size(75, 24);
            this.DeleteBox.TabIndex = 7;
            this.DeleteBox.Text = "Delete";
            this.DeleteBox.UseVisualStyleBackColor = true;
            // 
            // CreateBox
            // 
            this.CreateBox.AutoSize = true;
            this.CreateBox.Location = new System.Drawing.Point(524, 205);
            this.CreateBox.Name = "CreateBox";
            this.CreateBox.Size = new System.Drawing.Size(74, 24);
            this.CreateBox.TabIndex = 8;
            this.CreateBox.Text = "Create";
            this.CreateBox.UseVisualStyleBackColor = true;
            // 
            // DropBox
            // 
            this.DropBox.AutoSize = true;
            this.DropBox.Location = new System.Drawing.Point(524, 235);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(65, 24);
            this.DropBox.TabIndex = 9;
            this.DropBox.Text = "Drop";
            this.DropBox.UseVisualStyleBackColor = true;
            // 
            // GrantBox
            // 
            this.GrantBox.AutoSize = true;
            this.GrantBox.Location = new System.Drawing.Point(524, 265);
            this.GrantBox.Name = "GrantBox";
            this.GrantBox.Size = new System.Drawing.Size(67, 24);
            this.GrantBox.TabIndex = 10;
            this.GrantBox.Text = "Grant";
            this.GrantBox.UseVisualStyleBackColor = true;
            // 
            // ReferencesBox
            // 
            this.ReferencesBox.AutoSize = true;
            this.ReferencesBox.Location = new System.Drawing.Point(524, 295);
            this.ReferencesBox.Name = "ReferencesBox";
            this.ReferencesBox.Size = new System.Drawing.Size(103, 24);
            this.ReferencesBox.TabIndex = 11;
            this.ReferencesBox.Text = "References";
            this.ReferencesBox.UseVisualStyleBackColor = true;
            // 
            // IndexBox
            // 
            this.IndexBox.AutoSize = true;
            this.IndexBox.Location = new System.Drawing.Point(524, 325);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(67, 24);
            this.IndexBox.TabIndex = 12;
            this.IndexBox.Text = "Index";
            this.IndexBox.UseVisualStyleBackColor = true;
            // 
            // AlterBox
            // 
            this.AlterBox.AutoSize = true;
            this.AlterBox.Location = new System.Drawing.Point(524, 353);
            this.AlterBox.Name = "AlterBox";
            this.AlterBox.Size = new System.Drawing.Size(63, 24);
            this.AlterBox.TabIndex = 13;
            this.AlterBox.Text = "Alter";
            this.AlterBox.UseVisualStyleBackColor = true;
            // 
            // TriggerBox
            // 
            this.TriggerBox.AutoSize = true;
            this.TriggerBox.Location = new System.Drawing.Point(639, 325);
            this.TriggerBox.Name = "TriggerBox";
            this.TriggerBox.Size = new System.Drawing.Size(78, 24);
            this.TriggerBox.TabIndex = 22;
            this.TriggerBox.Text = "Trigger";
            this.TriggerBox.UseVisualStyleBackColor = true;
            // 
            // EventBox
            // 
            this.EventBox.AutoSize = true;
            this.EventBox.Location = new System.Drawing.Point(639, 295);
            this.EventBox.Name = "EventBox";
            this.EventBox.Size = new System.Drawing.Size(67, 24);
            this.EventBox.TabIndex = 21;
            this.EventBox.Text = "Event";
            this.EventBox.UseVisualStyleBackColor = true;
            // 
            // ExecuteBox
            // 
            this.ExecuteBox.AutoSize = true;
            this.ExecuteBox.Location = new System.Drawing.Point(639, 265);
            this.ExecuteBox.Name = "ExecuteBox";
            this.ExecuteBox.Size = new System.Drawing.Size(82, 24);
            this.ExecuteBox.TabIndex = 20;
            this.ExecuteBox.Text = "Execute";
            this.ExecuteBox.UseVisualStyleBackColor = true;
            // 
            // Alter_routineBox
            // 
            this.Alter_routineBox.AutoSize = true;
            this.Alter_routineBox.Location = new System.Drawing.Point(639, 235);
            this.Alter_routineBox.Name = "Alter_routineBox";
            this.Alter_routineBox.Size = new System.Drawing.Size(116, 24);
            this.Alter_routineBox.TabIndex = 19;
            this.Alter_routineBox.Text = "Alter_routine";
            this.Alter_routineBox.UseVisualStyleBackColor = true;
            // 
            // Create_routineBox
            // 
            this.Create_routineBox.AutoSize = true;
            this.Create_routineBox.Location = new System.Drawing.Point(639, 205);
            this.Create_routineBox.Name = "Create_routineBox";
            this.Create_routineBox.Size = new System.Drawing.Size(127, 24);
            this.Create_routineBox.TabIndex = 18;
            this.Create_routineBox.Text = "Create_routine";
            this.Create_routineBox.UseVisualStyleBackColor = true;
            // 
            // Show_viewBox
            // 
            this.Show_viewBox.AutoSize = true;
            this.Show_viewBox.Location = new System.Drawing.Point(639, 175);
            this.Show_viewBox.Name = "Show_viewBox";
            this.Show_viewBox.Size = new System.Drawing.Size(103, 24);
            this.Show_viewBox.TabIndex = 17;
            this.Show_viewBox.Text = "Show_view";
            this.Show_viewBox.UseVisualStyleBackColor = true;
            // 
            // Create_viewBox
            // 
            this.Create_viewBox.AutoSize = true;
            this.Create_viewBox.Location = new System.Drawing.Point(639, 145);
            this.Create_viewBox.Name = "Create_viewBox";
            this.Create_viewBox.Size = new System.Drawing.Size(110, 24);
            this.Create_viewBox.TabIndex = 16;
            this.Create_viewBox.Text = "Create_view";
            this.Create_viewBox.UseVisualStyleBackColor = true;
            // 
            // Lock_tablesBox
            // 
            this.Lock_tablesBox.AutoSize = true;
            this.Lock_tablesBox.Location = new System.Drawing.Point(639, 115);
            this.Lock_tablesBox.Name = "Lock_tablesBox";
            this.Lock_tablesBox.Size = new System.Drawing.Size(107, 24);
            this.Lock_tablesBox.TabIndex = 15;
            this.Lock_tablesBox.Text = "Lock_tables";
            this.Lock_tablesBox.UseVisualStyleBackColor = true;
            // 
            // Create_tmp_tableBox
            // 
            this.Create_tmp_tableBox.AutoSize = true;
            this.Create_tmp_tableBox.Location = new System.Drawing.Point(639, 85);
            this.Create_tmp_tableBox.Name = "Create_tmp_tableBox";
            this.Create_tmp_tableBox.Size = new System.Drawing.Size(147, 24);
            this.Create_tmp_tableBox.TabIndex = 14;
            this.Create_tmp_tableBox.Text = "Create_tmp_table";
            this.Create_tmp_tableBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Укажите привилегии из списка";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TriggerBox);
            this.Controls.Add(this.EventBox);
            this.Controls.Add(this.ExecuteBox);
            this.Controls.Add(this.Alter_routineBox);
            this.Controls.Add(this.Create_routineBox);
            this.Controls.Add(this.Show_viewBox);
            this.Controls.Add(this.Create_viewBox);
            this.Controls.Add(this.Lock_tablesBox);
            this.Controls.Add(this.Create_tmp_tableBox);
            this.Controls.Add(this.AlterBox);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.ReferencesBox);
            this.Controls.Add(this.GrantBox);
            this.Controls.Add(this.DropBox);
            this.Controls.Add(this.CreateBox);
            this.Controls.Add(this.DeleteBox);
            this.Controls.Add(this.User_name_textbox);
            this.Controls.Add(this.User_name_lable);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.InsertBox);
            this.Controls.Add(this.SelectBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdditionalText);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заполните форму";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button ExitButton;
        private Button ApplyButton;
        private TextBox AdditionalText;
        private Label label2;
        private CheckBox SelectBox;
        private CheckBox InsertBox;
        private CheckBox UpdateBox;
        private Label User_name_lable;
        private TextBox User_name_textbox;
        private CheckBox DeleteBox;
        private CheckBox CreateBox;
        private CheckBox DropBox;
        private CheckBox GrantBox;
        private CheckBox ReferencesBox;
        private CheckBox IndexBox;
        private CheckBox AlterBox;
        private CheckBox TriggerBox;
        private CheckBox EventBox;
        private CheckBox ExecuteBox;
        private CheckBox Alter_routineBox;
        private CheckBox Create_routineBox;
        private CheckBox Show_viewBox;
        private CheckBox Create_viewBox;
        private CheckBox Lock_tablesBox;
        private CheckBox Create_tmp_tableBox;
        private Label label1;
    }
}