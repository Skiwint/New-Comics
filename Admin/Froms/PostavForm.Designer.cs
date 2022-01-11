namespace Admin.Froms
{
    partial class PostavForm
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
            this.UpPostav = new System.Windows.Forms.Button();
            this.DelPostav = new System.Windows.Forms.Button();
            this.AddPostav = new System.Windows.Forms.Button();
            this.DataPostav = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.NameSup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneTB1 = new System.Windows.Forms.MaskedTextBox();
            this.FilPoSklad = new System.Windows.Forms.Button();
            this.FilialBtn = new System.Windows.Forms.Button();
            this.SkladBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataPostav)).BeginInit();
            this.SuspendLayout();
            // 
            // UpPostav
            // 
            this.UpPostav.BackColor = System.Drawing.Color.Black;
            this.UpPostav.ForeColor = System.Drawing.Color.White;
            this.UpPostav.Location = new System.Drawing.Point(957, 260);
            this.UpPostav.Margin = new System.Windows.Forms.Padding(2);
            this.UpPostav.Name = "UpPostav";
            this.UpPostav.Size = new System.Drawing.Size(149, 41);
            this.UpPostav.TabIndex = 11;
            this.UpPostav.Text = "Изменить";
            this.UpPostav.UseVisualStyleBackColor = false;
            this.UpPostav.Click += new System.EventHandler(this.UpPostav_Click);
            // 
            // DelPostav
            // 
            this.DelPostav.BackColor = System.Drawing.Color.Black;
            this.DelPostav.ForeColor = System.Drawing.Color.White;
            this.DelPostav.Location = new System.Drawing.Point(803, 260);
            this.DelPostav.Margin = new System.Windows.Forms.Padding(2);
            this.DelPostav.Name = "DelPostav";
            this.DelPostav.Size = new System.Drawing.Size(149, 41);
            this.DelPostav.TabIndex = 10;
            this.DelPostav.Text = "Удалить";
            this.DelPostav.UseVisualStyleBackColor = false;
            this.DelPostav.Click += new System.EventHandler(this.DelPostav_Click);
            // 
            // AddPostav
            // 
            this.AddPostav.BackColor = System.Drawing.Color.Black;
            this.AddPostav.ForeColor = System.Drawing.Color.White;
            this.AddPostav.Location = new System.Drawing.Point(650, 260);
            this.AddPostav.Margin = new System.Windows.Forms.Padding(2);
            this.AddPostav.Name = "AddPostav";
            this.AddPostav.Size = new System.Drawing.Size(149, 41);
            this.AddPostav.TabIndex = 9;
            this.AddPostav.Text = "Добавить";
            this.AddPostav.UseVisualStyleBackColor = false;
            this.AddPostav.Click += new System.EventHandler(this.AddPostav_Click);
            // 
            // DataPostav
            // 
            this.DataPostav.AllowUserToAddRows = false;
            this.DataPostav.AllowUserToDeleteRows = false;
            this.DataPostav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPostav.Location = new System.Drawing.Point(11, 324);
            this.DataPostav.Margin = new System.Windows.Forms.Padding(2);
            this.DataPostav.MultiSelect = false;
            this.DataPostav.Name = "DataPostav";
            this.DataPostav.ReadOnly = true;
            this.DataPostav.RowHeadersWidth = 62;
            this.DataPostav.RowTemplate.Height = 33;
            this.DataPostav.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataPostav.Size = new System.Drawing.Size(1196, 316);
            this.DataPostav.TabIndex = 8;
            this.DataPostav.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPostav_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Адресс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(141, 155);
            this.Adres.Margin = new System.Windows.Forms.Padding(2);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(332, 27);
            this.Adres.TabIndex = 13;
            // 
            // NameSup
            // 
            this.NameSup.Location = new System.Drawing.Point(141, 104);
            this.NameSup.Margin = new System.Windows.Forms.Padding(2);
            this.NameSup.Name = "NameSup";
            this.NameSup.Size = new System.Drawing.Size(332, 27);
            this.NameSup.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Телефон";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneTB1
            // 
            this.PhoneTB1.Location = new System.Drawing.Point(142, 202);
            this.PhoneTB1.Mask = "(999) 000-0000";
            this.PhoneTB1.Name = "PhoneTB1";
            this.PhoneTB1.Size = new System.Drawing.Size(332, 27);
            this.PhoneTB1.TabIndex = 19;
            this.PhoneTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB1_KeyPress);
            // 
            // FilPoSklad
            // 
            this.FilPoSklad.BackColor = System.Drawing.Color.Black;
            this.FilPoSklad.ForeColor = System.Drawing.Color.White;
            this.FilPoSklad.Location = new System.Drawing.Point(1055, 11);
            this.FilPoSklad.Margin = new System.Windows.Forms.Padding(2);
            this.FilPoSklad.Name = "FilPoSklad";
            this.FilPoSklad.Size = new System.Drawing.Size(149, 41);
            this.FilPoSklad.TabIndex = 30;
            this.FilPoSklad.Text = "Филиал по складу";
            this.FilPoSklad.UseVisualStyleBackColor = false;
            this.FilPoSklad.Click += new System.EventHandler(this.FilPoSklad_Click);
            // 
            // FilialBtn
            // 
            this.FilialBtn.BackColor = System.Drawing.Color.Black;
            this.FilialBtn.ForeColor = System.Drawing.Color.White;
            this.FilialBtn.Location = new System.Drawing.Point(1055, 101);
            this.FilialBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FilialBtn.Name = "FilialBtn";
            this.FilialBtn.Size = new System.Drawing.Size(149, 41);
            this.FilialBtn.TabIndex = 29;
            this.FilialBtn.Text = "Филиал";
            this.FilialBtn.UseVisualStyleBackColor = false;
            this.FilialBtn.Click += new System.EventHandler(this.FilialBtn_Click);
            // 
            // SkladBtn
            // 
            this.SkladBtn.BackColor = System.Drawing.Color.Black;
            this.SkladBtn.ForeColor = System.Drawing.Color.White;
            this.SkladBtn.Location = new System.Drawing.Point(1055, 56);
            this.SkladBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SkladBtn.Name = "SkladBtn";
            this.SkladBtn.Size = new System.Drawing.Size(149, 41);
            this.SkladBtn.TabIndex = 28;
            this.SkladBtn.Text = "Склад";
            this.SkladBtn.UseVisualStyleBackColor = false;
            this.SkladBtn.Click += new System.EventHandler(this.SkladBtn_Click);
            // 
            // PostavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.FilPoSklad);
            this.Controls.Add(this.FilialBtn);
            this.Controls.Add(this.SkladBtn);
            this.Controls.Add(this.PhoneTB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.NameSup);
            this.Controls.Add(this.UpPostav);
            this.Controls.Add(this.DelPostav);
            this.Controls.Add(this.AddPostav);
            this.Controls.Add(this.DataPostav);
            this.Name = "PostavForm";
            this.Text = "Поставщики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostavForm_FormClosed);
            this.Load += new System.EventHandler(this.PostavForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPostav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpPostav;
        private System.Windows.Forms.Button DelPostav;
        private System.Windows.Forms.Button AddPostav;
        private System.Windows.Forms.DataGridView DataPostav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox NameSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox PhoneTB1;
        public System.Windows.Forms.Button FilPoSklad;
        public System.Windows.Forms.Button FilialBtn;
        public System.Windows.Forms.Button SkladBtn;
    }
}