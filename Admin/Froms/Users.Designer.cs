
namespace Admin
{
    partial class Users
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataUser = new System.Windows.Forms.DataGridView();
            this.AddUser = new System.Windows.Forms.Button();
            this.DelUser = new System.Windows.Forms.Button();
            this.UpUser = new System.Windows.Forms.Button();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BackForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(92, 139);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(332, 27);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(92, 190);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(332, 27);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // DataUser
            // 
            this.DataUser.AllowUserToAddRows = false;
            this.DataUser.AllowUserToDeleteRows = false;
            this.DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUser.Location = new System.Drawing.Point(10, 326);
            this.DataUser.Margin = new System.Windows.Forms.Padding(2);
            this.DataUser.MultiSelect = false;
            this.DataUser.Name = "DataUser";
            this.DataUser.ReadOnly = true;
            this.DataUser.RowHeadersWidth = 62;
            this.DataUser.RowTemplate.Height = 33;
            this.DataUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataUser.Size = new System.Drawing.Size(1196, 316);
            this.DataUser.TabIndex = 4;
            this.DataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUser_CellContentClick);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.Black;
            this.AddUser.ForeColor = System.Drawing.Color.White;
            this.AddUser.Location = new System.Drawing.Point(649, 262);
            this.AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(149, 41);
            this.AddUser.TabIndex = 5;
            this.AddUser.Text = "Добавить";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // DelUser
            // 
            this.DelUser.BackColor = System.Drawing.Color.Black;
            this.DelUser.ForeColor = System.Drawing.Color.White;
            this.DelUser.Location = new System.Drawing.Point(802, 262);
            this.DelUser.Margin = new System.Windows.Forms.Padding(2);
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(149, 41);
            this.DelUser.TabIndex = 6;
            this.DelUser.Text = "Удалить";
            this.DelUser.UseVisualStyleBackColor = false;
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // UpUser
            // 
            this.UpUser.BackColor = System.Drawing.Color.Black;
            this.UpUser.ForeColor = System.Drawing.Color.White;
            this.UpUser.Location = new System.Drawing.Point(956, 262);
            this.UpUser.Margin = new System.Windows.Forms.Padding(2);
            this.UpUser.Name = "UpUser";
            this.UpUser.Size = new System.Drawing.Size(149, 41);
            this.UpUser.TabIndex = 7;
            this.UpUser.Text = "Изменить";
            this.UpUser.UseVisualStyleBackColor = false;
            this.UpUser.Click += new System.EventHandler(this.UpUser_Click);
            // 
            // RoleBox
            // 
            this.RoleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Location = new System.Drawing.Point(92, 234);
            this.RoleBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(332, 28);
            this.RoleBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Role*";
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(16, 11);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(149, 41);
            this.BackForm.TabIndex = 10;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.UpUser);
            this.Controls.Add(this.DelUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.DataUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Users";
            this.Text = "Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Users_FormClosed);
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button DelUser;
        private System.Windows.Forms.Button UpUser;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackForm;
    }
}