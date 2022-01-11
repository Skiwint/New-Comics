namespace Admin.Froms
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.BackForm = new System.Windows.Forms.Button();
            this.UpUser = new System.Windows.Forms.Button();
            this.DelUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.DataClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "ФИО";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(92, 178);
            this.FIO.Margin = new System.Windows.Forms.Padding(2);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(332, 27);
            this.FIO.TabIndex = 33;
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(9, 11);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(149, 41);
            this.BackForm.TabIndex = 32;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // UpUser
            // 
            this.UpUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpUser.BackColor = System.Drawing.Color.Black;
            this.UpUser.ForeColor = System.Drawing.Color.White;
            this.UpUser.Location = new System.Drawing.Point(1056, 264);
            this.UpUser.Margin = new System.Windows.Forms.Padding(2);
            this.UpUser.Name = "UpUser";
            this.UpUser.Size = new System.Drawing.Size(149, 41);
            this.UpUser.TabIndex = 31;
            this.UpUser.Text = "Изменить";
            this.UpUser.UseVisualStyleBackColor = false;
            this.UpUser.Click += new System.EventHandler(this.UpUser_Click);
            // 
            // DelUser
            // 
            this.DelUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelUser.BackColor = System.Drawing.Color.Black;
            this.DelUser.ForeColor = System.Drawing.Color.White;
            this.DelUser.Location = new System.Drawing.Point(902, 264);
            this.DelUser.Margin = new System.Windows.Forms.Padding(2);
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(149, 41);
            this.DelUser.TabIndex = 30;
            this.DelUser.Text = "Удалить";
            this.DelUser.UseVisualStyleBackColor = false;
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUser.BackColor = System.Drawing.Color.Black;
            this.AddUser.ForeColor = System.Drawing.Color.White;
            this.AddUser.Location = new System.Drawing.Point(749, 264);
            this.AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(149, 41);
            this.AddUser.TabIndex = 29;
            this.AddUser.Text = "Добавить";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // DataClient
            // 
            this.DataClient.AllowUserToAddRows = false;
            this.DataClient.AllowUserToDeleteRows = false;
            this.DataClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataClient.Location = new System.Drawing.Point(11, 309);
            this.DataClient.Margin = new System.Windows.Forms.Padding(2);
            this.DataClient.MultiSelect = false;
            this.DataClient.Name = "DataClient";
            this.DataClient.ReadOnly = true;
            this.DataClient.RowHeadersWidth = 62;
            this.DataClient.RowTemplate.Height = 33;
            this.DataClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataClient.Size = new System.Drawing.Size(1196, 331);
            this.DataClient.TabIndex = 28;
            this.DataClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClient_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Телефон";
            // 
            // NumberPhone
            // 
            this.NumberPhone.Location = new System.Drawing.Point(92, 226);
            this.NumberPhone.Mask = "(999) 000-0000";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.Size = new System.Drawing.Size(332, 27);
            this.NumberPhone.TabIndex = 37;
            this.NumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberPhone_KeyPress);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.NumberPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.UpUser);
            this.Controls.Add(this.DelUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.DataClient);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Button UpUser;
        private System.Windows.Forms.Button DelUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.DataGridView DataClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox NumberPhone;
    }
}