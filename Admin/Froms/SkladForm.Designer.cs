namespace Admin.Froms
{
    partial class SkladForm
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
            this.BackForm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PostavBox = new System.Windows.Forms.ComboBox();
            this.UpSklad = new System.Windows.Forms.Button();
            this.DelSklad = new System.Windows.Forms.Button();
            this.AddSklad = new System.Windows.Forms.Button();
            this.DataSklad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vmest = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTB1 = new System.Windows.Forms.MaskedTextBox();
            this.PostavBtn = new System.Windows.Forms.Button();
            this.FilialBtn = new System.Windows.Forms.Button();
            this.FilPoSklad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSklad)).BeginInit();
            this.SuspendLayout();
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(15, 10);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(149, 41);
            this.BackForm.TabIndex = 21;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Поставщик*";
            // 
            // PostavBox
            // 
            this.PostavBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostavBox.FormattingEnabled = true;
            this.PostavBox.Location = new System.Drawing.Point(165, 233);
            this.PostavBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostavBox.Name = "PostavBox";
            this.PostavBox.Size = new System.Drawing.Size(332, 28);
            this.PostavBox.TabIndex = 19;
            // 
            // UpSklad
            // 
            this.UpSklad.BackColor = System.Drawing.Color.Black;
            this.UpSklad.ForeColor = System.Drawing.Color.White;
            this.UpSklad.Location = new System.Drawing.Point(955, 261);
            this.UpSklad.Margin = new System.Windows.Forms.Padding(2);
            this.UpSklad.Name = "UpSklad";
            this.UpSklad.Size = new System.Drawing.Size(149, 41);
            this.UpSklad.TabIndex = 18;
            this.UpSklad.Text = "Изменить";
            this.UpSklad.UseVisualStyleBackColor = false;
            this.UpSklad.Click += new System.EventHandler(this.UpSklad_Click);
            // 
            // DelSklad
            // 
            this.DelSklad.BackColor = System.Drawing.Color.Black;
            this.DelSklad.ForeColor = System.Drawing.Color.White;
            this.DelSklad.Location = new System.Drawing.Point(801, 261);
            this.DelSklad.Margin = new System.Windows.Forms.Padding(2);
            this.DelSklad.Name = "DelSklad";
            this.DelSklad.Size = new System.Drawing.Size(149, 41);
            this.DelSklad.TabIndex = 17;
            this.DelSklad.Text = "Удалить";
            this.DelSklad.UseVisualStyleBackColor = false;
            this.DelSklad.Click += new System.EventHandler(this.DelSklad_Click);
            // 
            // AddSklad
            // 
            this.AddSklad.BackColor = System.Drawing.Color.Black;
            this.AddSklad.ForeColor = System.Drawing.Color.White;
            this.AddSklad.Location = new System.Drawing.Point(648, 261);
            this.AddSklad.Margin = new System.Windows.Forms.Padding(2);
            this.AddSklad.Name = "AddSklad";
            this.AddSklad.Size = new System.Drawing.Size(149, 41);
            this.AddSklad.TabIndex = 16;
            this.AddSklad.Text = "Добавить";
            this.AddSklad.UseVisualStyleBackColor = false;
            this.AddSklad.Click += new System.EventHandler(this.AddSklad_Click);
            // 
            // DataSklad
            // 
            this.DataSklad.AllowUserToAddRows = false;
            this.DataSklad.AllowUserToDeleteRows = false;
            this.DataSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSklad.Location = new System.Drawing.Point(9, 325);
            this.DataSklad.Margin = new System.Windows.Forms.Padding(2);
            this.DataSklad.MultiSelect = false;
            this.DataSklad.Name = "DataSklad";
            this.DataSklad.ReadOnly = true;
            this.DataSklad.RowHeadersWidth = 62;
            this.DataSklad.RowTemplate.Height = 33;
            this.DataSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSklad.Size = new System.Drawing.Size(1196, 316);
            this.DataSklad.TabIndex = 15;
            this.DataSklad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSklad_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вместимость(км\"2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Адрес";
            // 
            // Vmest
            // 
            this.Vmest.Location = new System.Drawing.Point(165, 137);
            this.Vmest.Margin = new System.Windows.Forms.Padding(2);
            this.Vmest.Name = "Vmest";
            this.Vmest.Size = new System.Drawing.Size(332, 27);
            this.Vmest.TabIndex = 12;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(165, 86);
            this.Adres.Margin = new System.Windows.Forms.Padding(2);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(332, 27);
            this.Adres.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Телефон";
            // 
            // PhoneTB1
            // 
            this.PhoneTB1.Location = new System.Drawing.Point(165, 180);
            this.PhoneTB1.Mask = "(999) 000-0000";
            this.PhoneTB1.Name = "PhoneTB1";
            this.PhoneTB1.Size = new System.Drawing.Size(332, 27);
            this.PhoneTB1.TabIndex = 24;
            this.PhoneTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB1_KeyPress);
            // 
            // PostavBtn
            // 
            this.PostavBtn.BackColor = System.Drawing.Color.Black;
            this.PostavBtn.ForeColor = System.Drawing.Color.White;
            this.PostavBtn.Location = new System.Drawing.Point(1055, 56);
            this.PostavBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PostavBtn.Name = "PostavBtn";
            this.PostavBtn.Size = new System.Drawing.Size(149, 41);
            this.PostavBtn.TabIndex = 25;
            this.PostavBtn.Text = "Поставщик";
            this.PostavBtn.UseVisualStyleBackColor = false;
            this.PostavBtn.Click += new System.EventHandler(this.PostavBtn_Click);
            // 
            // FilialBtn
            // 
            this.FilialBtn.BackColor = System.Drawing.Color.Black;
            this.FilialBtn.ForeColor = System.Drawing.Color.White;
            this.FilialBtn.Location = new System.Drawing.Point(1055, 101);
            this.FilialBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FilialBtn.Name = "FilialBtn";
            this.FilialBtn.Size = new System.Drawing.Size(149, 41);
            this.FilialBtn.TabIndex = 26;
            this.FilialBtn.Text = "Филиал";
            this.FilialBtn.UseVisualStyleBackColor = false;
            this.FilialBtn.Click += new System.EventHandler(this.FilialBtn_Click);
            // 
            // FilPoSklad
            // 
            this.FilPoSklad.BackColor = System.Drawing.Color.Black;
            this.FilPoSklad.ForeColor = System.Drawing.Color.White;
            this.FilPoSklad.Location = new System.Drawing.Point(1055, 11);
            this.FilPoSklad.Margin = new System.Windows.Forms.Padding(2);
            this.FilPoSklad.Name = "FilPoSklad";
            this.FilPoSklad.Size = new System.Drawing.Size(149, 41);
            this.FilPoSklad.TabIndex = 27;
            this.FilPoSklad.Text = "Филиал по складу";
            this.FilPoSklad.UseVisualStyleBackColor = false;
            this.FilPoSklad.Click += new System.EventHandler(this.FilPoSklad_Click);
            // 
            // SkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.FilPoSklad);
            this.Controls.Add(this.FilialBtn);
            this.Controls.Add(this.PostavBtn);
            this.Controls.Add(this.PhoneTB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PostavBox);
            this.Controls.Add(this.UpSklad);
            this.Controls.Add(this.DelSklad);
            this.Controls.Add(this.AddSklad);
            this.Controls.Add(this.DataSklad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vmest);
            this.Controls.Add(this.Adres);
            this.Name = "SkladForm";
            this.Text = "SkladForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkladForm_FormClosed);
            this.Load += new System.EventHandler(this.SkladForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSklad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PostavBox;
        private System.Windows.Forms.Button UpSklad;
        private System.Windows.Forms.Button DelSklad;
        private System.Windows.Forms.Button AddSklad;
        private System.Windows.Forms.DataGridView DataSklad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Vmest;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PhoneTB1;
        public System.Windows.Forms.Button PostavBtn;
        public System.Windows.Forms.Button FilialBtn;
        public System.Windows.Forms.Button FilPoSklad;
    }
}