namespace UserFormProject
{
    partial class Registration
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
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelUsSur = new System.Windows.Forms.Label();
            this.labelUsName = new System.Windows.Forms.Label();
            this.FirstnameField = new System.Windows.Forms.TextBox();
            this.ButtonDone = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.LastnameField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuth.Location = new System.Drawing.Point(203, 41);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(392, 78);
            this.labelAuth.TabIndex = 8;
            this.labelAuth.Text = "Регистрация";
            // 
            // labelUsSur
            // 
            this.labelUsSur.AutoSize = true;
            this.labelUsSur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsSur.Location = new System.Drawing.Point(394, 178);
            this.labelUsSur.Name = "labelUsSur";
            this.labelUsSur.Size = new System.Drawing.Size(138, 32);
            this.labelUsSur.TabIndex = 11;
            this.labelUsSur.Text = "Фамилия :";
            // 
            // labelUsName
            // 
            this.labelUsName.AutoSize = true;
            this.labelUsName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsName.Location = new System.Drawing.Point(43, 178);
            this.labelUsName.Name = "labelUsName";
            this.labelUsName.Size = new System.Drawing.Size(80, 32);
            this.labelUsName.TabIndex = 9;
            this.labelUsName.Text = "Имя :";
            // 
            // FirstnameField
            // 
            this.FirstnameField.Location = new System.Drawing.Point(144, 178);
            this.FirstnameField.Multiline = true;
            this.FirstnameField.Name = "FirstnameField";
            this.FirstnameField.Size = new System.Drawing.Size(232, 32);
            this.FirstnameField.TabIndex = 10;
            // 
            // ButtonDone
            // 
            this.ButtonDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDone.Location = new System.Drawing.Point(144, 330);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(221, 46);
            this.ButtonDone.TabIndex = 17;
            this.ButtonDone.Text = "Зарегестрироваться";
            this.ButtonDone.UseVisualStyleBackColor = true;
            this.ButtonDone.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(486, 330);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(109, 46);
            this.ButtonExit.TabIndex = 19;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(371, 330);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(109, 46);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(416, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пароль :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Логин :";
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(144, 231);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(232, 32);
            this.LoginField.TabIndex = 14;
            // 
            // LastnameField
            // 
            this.LastnameField.Location = new System.Drawing.Point(538, 178);
            this.LastnameField.Multiline = true;
            this.LastnameField.Name = "LastnameField";
            this.LastnameField.Size = new System.Drawing.Size(232, 32);
            this.LastnameField.TabIndex = 12;
            // 
            // PassField
            // 
            this.PassField.Location = new System.Drawing.Point(538, 231);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(232, 27);
            this.PassField.TabIndex = 16;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LastnameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.labelUsSur);
            this.Controls.Add(this.labelUsName);
            this.Controls.Add(this.FirstnameField);
            this.Controls.Add(this.ButtonDone);
            this.Controls.Add(this.ButtonExit);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAuth;
        private Label labelUsSur;
        private Label labelUsName;
        private TextBox FirstnameField;
        private Button ButtonDone;
        private Button ButtonExit;
        private Button BackButton;
        private Label label1;
        private Label label2;
        private TextBox LoginField;
        private TextBox LastnameField;
        private TextBox PassField;
    }
}