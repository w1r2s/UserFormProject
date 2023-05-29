namespace UserFormProject
{
    partial class Authorization
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelAuth = new System.Windows.Forms.Label();
            this.linkLabelRegistration = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(299, 334);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(109, 46);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.Location = new System.Drawing.Point(176, 334);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(109, 46);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // LoginField
            // 
            this.LoginField.Location = new System.Drawing.Point(193, 180);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(232, 32);
            this.LoginField.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(71, 174);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(101, 32);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин :";
            // 
            // PassField
            // 
            this.PassField.Location = new System.Drawing.Point(193, 238);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(232, 27);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPass.Location = new System.Drawing.Point(71, 233);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(116, 32);
            this.labelPass.TabIndex = 6;
            this.labelPass.Text = "Пароль :";
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuth.Location = new System.Drawing.Point(71, 50);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(413, 78);
            this.labelAuth.TabIndex = 7;
            this.labelAuth.Text = "Авторизация";
            // 
            // linkLabelRegistration
            // 
            this.linkLabelRegistration.AutoSize = true;
            this.linkLabelRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRegistration.Location = new System.Drawing.Point(193, 278);
            this.linkLabelRegistration.Name = "linkLabelRegistration";
            this.linkLabelRegistration.Size = new System.Drawing.Size(227, 20);
            this.linkLabelRegistration.TabIndex = 2;
            this.linkLabelRegistration.TabStop = true;
            this.linkLabelRegistration.Text = "Нет аккаунта? Зарегестрируйся";
            this.linkLabelRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegistration_LinkClicked);
            // 
            // Authorization
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(548, 453);
            this.Controls.Add(this.linkLabelRegistration);
            this.Controls.Add(this.labelAuth);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Button buttonEnter;
        private TextBox LoginField;
        private Label labelLogin;
        private TextBox PassField;
        private Label labelPass;
        private Label labelAuth;
        private LinkLabel linkLabelRegistration;
    }
}