namespace Admin.Froms
{
    partial class SaleForm
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
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.BackForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComicsBox = new System.Windows.Forms.ComboBox();
            this.UpSale = new System.Windows.Forms.Button();
            this.DelSale = new System.Windows.Forms.Button();
            this.AddSale = new System.Windows.Forms.Button();
            this.DataSale = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DataCheck = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Клиент*";
            // 
            // ClientBox
            // 
            this.ClientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(100, 127);
            this.ClientBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(332, 28);
            this.ClientBox.TabIndex = 31;
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(15, 10);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(149, 41);
            this.BackForm.TabIndex = 30;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Комикс*";
            // 
            // ComicsBox
            // 
            this.ComicsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComicsBox.FormattingEnabled = true;
            this.ComicsBox.Location = new System.Drawing.Point(100, 180);
            this.ComicsBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComicsBox.Name = "ComicsBox";
            this.ComicsBox.Size = new System.Drawing.Size(332, 28);
            this.ComicsBox.TabIndex = 28;
            // 
            // UpSale
            // 
            this.UpSale.BackColor = System.Drawing.Color.Black;
            this.UpSale.ForeColor = System.Drawing.Color.White;
            this.UpSale.Location = new System.Drawing.Point(997, 270);
            this.UpSale.Margin = new System.Windows.Forms.Padding(2);
            this.UpSale.Name = "UpSale";
            this.UpSale.Size = new System.Drawing.Size(149, 41);
            this.UpSale.TabIndex = 27;
            this.UpSale.Text = "Изменить";
            this.UpSale.UseVisualStyleBackColor = false;
            this.UpSale.Click += new System.EventHandler(this.UpSale_Click);
            // 
            // DelSale
            // 
            this.DelSale.BackColor = System.Drawing.Color.Black;
            this.DelSale.ForeColor = System.Drawing.Color.White;
            this.DelSale.Location = new System.Drawing.Point(843, 270);
            this.DelSale.Margin = new System.Windows.Forms.Padding(2);
            this.DelSale.Name = "DelSale";
            this.DelSale.Size = new System.Drawing.Size(149, 41);
            this.DelSale.TabIndex = 26;
            this.DelSale.Text = "Удалить";
            this.DelSale.UseVisualStyleBackColor = false;
            this.DelSale.Click += new System.EventHandler(this.DelSale_Click);
            // 
            // AddSale
            // 
            this.AddSale.BackColor = System.Drawing.Color.Black;
            this.AddSale.ForeColor = System.Drawing.Color.White;
            this.AddSale.Location = new System.Drawing.Point(686, 270);
            this.AddSale.Margin = new System.Windows.Forms.Padding(2);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(149, 41);
            this.AddSale.TabIndex = 25;
            this.AddSale.Text = "Добавить";
            this.AddSale.UseVisualStyleBackColor = false;
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // DataSale
            // 
            this.DataSale.AllowUserToAddRows = false;
            this.DataSale.AllowUserToDeleteRows = false;
            this.DataSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSale.Location = new System.Drawing.Point(9, 325);
            this.DataSale.Margin = new System.Windows.Forms.Padding(2);
            this.DataSale.MultiSelect = false;
            this.DataSale.Name = "DataSale";
            this.DataSale.ReadOnly = true;
            this.DataSale.RowHeadersWidth = 62;
            this.DataSale.RowTemplate.Height = 33;
            this.DataSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSale.Size = new System.Drawing.Size(1196, 316);
            this.DataSale.TabIndex = 24;
            this.DataSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSale_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата";
            // 
            // DataCheck
            // 
            this.DataCheck.Location = new System.Drawing.Point(100, 232);
            this.DataCheck.Name = "DataCheck";
            this.DataCheck.Size = new System.Drawing.Size(332, 27);
            this.DataCheck.TabIndex = 35;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.DataCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComicsBox);
            this.Controls.Add(this.UpSale);
            this.Controls.Add(this.DelSale);
            this.Controls.Add(this.AddSale);
            this.Controls.Add(this.DataSale);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleForm_FormClosed);
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ClientBox;
        public System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComicsBox;
        private System.Windows.Forms.Button UpSale;
        private System.Windows.Forms.Button DelSale;
        private System.Windows.Forms.Button AddSale;
        private System.Windows.Forms.DataGridView DataSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DataCheck;
    }
}