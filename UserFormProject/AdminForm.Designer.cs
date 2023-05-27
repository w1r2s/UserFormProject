namespace UserFormProject
{
    partial class AdminForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.User_name_textbox = new System.Windows.Forms.TextBox();
            this.User_name_lable = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RevokeButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ValidCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Заявки";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(637, 395);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 43);
            this.ExitButton.TabIndex = 26;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // User_name_textbox
            // 
            this.User_name_textbox.Location = new System.Drawing.Point(250, 54);
            this.User_name_textbox.Name = "User_name_textbox";
            this.User_name_textbox.Size = new System.Drawing.Size(183, 27);
            this.User_name_textbox.TabIndex = 29;
            // 
            // User_name_lable
            // 
            this.User_name_lable.AutoSize = true;
            this.User_name_lable.Location = new System.Drawing.Point(130, 57);
            this.User_name_lable.Name = "User_name_lable";
            this.User_name_lable.Size = new System.Drawing.Size(114, 20);
            this.User_name_lable.TabIndex = 28;
            this.User_name_lable.Text = "Пользователь :";
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Location = new System.Drawing.Point(439, 53);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevokeButton.Location = new System.Drawing.Point(637, 218);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(125, 45);
            this.RevokeButton.TabIndex = 33;
            this.RevokeButton.Text = "Отозвать";
            this.RevokeButton.UseVisualStyleBackColor = true;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeclineButton.Location = new System.Drawing.Point(637, 154);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(125, 45);
            this.DeclineButton.TabIndex = 34;
            this.DeclineButton.Text = "Отклонить";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyButton.Location = new System.Drawing.Point(637, 88);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(125, 45);
            this.ApplyButton.TabIndex = 35;
            this.ApplyButton.Text = "Одобрить";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AllowUserToResizeColumns = false;
            this.GridView.AllowUserToResizeRows = false;
            this.GridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValidCheck});
            this.GridView.Location = new System.Drawing.Point(24, 88);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 50;
            this.GridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridView.RowTemplate.Height = 29;
            this.GridView.Size = new System.Drawing.Size(607, 350);
            this.GridView.TabIndex = 36;
            // 
            // ValidCheck
            // 
            this.ValidCheck.FillWeight = 10F;
            this.ValidCheck.Frozen = true;
            this.ValidCheck.HeaderText = "";
            this.ValidCheck.MinimumWidth = 6;
            this.ValidCheck.Name = "ValidCheck";
            this.ValidCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValidCheck.Width = 30;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(637, 346);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 43);
            this.BackButton.TabIndex = 37;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.User_name_textbox);
            this.Controls.Add(this.User_name_lable);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Button ExitButton;
        private TextBox User_name_textbox;
        private Label User_name_lable;
        private Button SearchButton;
        private Button RevokeButton;
        private Button DeclineButton;
        private Button ApplyButton;
        private DataGridView GridView;
        private DataGridViewCheckBoxColumn ValidCheck;
        private Button BackButton;
    }
}