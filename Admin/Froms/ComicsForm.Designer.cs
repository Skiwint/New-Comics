namespace Admin.Froms
{
    partial class ComicsForm
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
            this.UpComics = new System.Windows.Forms.Button();
            this.DelComics = new System.Windows.Forms.Button();
            this.AddComics = new System.Windows.Forms.Button();
            this.DataComics = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SkladBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.ComName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.CountPage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Binding = new System.Windows.Forms.ComboBox();
            this.BeckForm = new System.Windows.Forms.Button();
            this.DateCom = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataComics)).BeginInit();
            this.SuspendLayout();
            // 
            // UpComics
            // 
            this.UpComics.BackColor = System.Drawing.Color.Black;
            this.UpComics.ForeColor = System.Drawing.Color.White;
            this.UpComics.Location = new System.Drawing.Point(1017, 268);
            this.UpComics.Margin = new System.Windows.Forms.Padding(2);
            this.UpComics.Name = "UpComics";
            this.UpComics.Size = new System.Drawing.Size(149, 41);
            this.UpComics.TabIndex = 26;
            this.UpComics.Text = "Изменить";
            this.UpComics.UseVisualStyleBackColor = false;
            this.UpComics.Click += new System.EventHandler(this.UpComics_Click);
            // 
            // DelComics
            // 
            this.DelComics.BackColor = System.Drawing.Color.Black;
            this.DelComics.ForeColor = System.Drawing.Color.White;
            this.DelComics.Location = new System.Drawing.Point(864, 268);
            this.DelComics.Margin = new System.Windows.Forms.Padding(2);
            this.DelComics.Name = "DelComics";
            this.DelComics.Size = new System.Drawing.Size(149, 41);
            this.DelComics.TabIndex = 25;
            this.DelComics.Text = "Удалить";
            this.DelComics.UseVisualStyleBackColor = false;
            this.DelComics.Click += new System.EventHandler(this.DelComics_Click);
            // 
            // AddComics
            // 
            this.AddComics.BackColor = System.Drawing.Color.Black;
            this.AddComics.ForeColor = System.Drawing.Color.White;
            this.AddComics.Location = new System.Drawing.Point(711, 268);
            this.AddComics.Margin = new System.Windows.Forms.Padding(2);
            this.AddComics.Name = "AddComics";
            this.AddComics.Size = new System.Drawing.Size(149, 41);
            this.AddComics.TabIndex = 24;
            this.AddComics.Text = "Добавить";
            this.AddComics.UseVisualStyleBackColor = false;
            this.AddComics.Click += new System.EventHandler(this.AddComics_Click);
            // 
            // DataComics
            // 
            this.DataComics.AllowUserToAddRows = false;
            this.DataComics.AllowUserToDeleteRows = false;
            this.DataComics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataComics.Location = new System.Drawing.Point(11, 324);
            this.DataComics.Margin = new System.Windows.Forms.Padding(2);
            this.DataComics.MultiSelect = false;
            this.DataComics.Name = "DataComics";
            this.DataComics.ReadOnly = true;
            this.DataComics.RowHeadersWidth = 62;
            this.DataComics.RowTemplate.Height = 33;
            this.DataComics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataComics.Size = new System.Drawing.Size(1196, 316);
            this.DataComics.TabIndex = 23;
            this.DataComics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataComics_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Дата выпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(572, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Склад*";
            // 
            // SkladBox
            // 
            this.SkladBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkladBox.FormattingEnabled = true;
            this.SkladBox.Location = new System.Drawing.Point(643, 96);
            this.SkladBox.Margin = new System.Windows.Forms.Padding(2);
            this.SkladBox.Name = "SkladBox";
            this.SkladBox.Size = new System.Drawing.Size(332, 28);
            this.SkladBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Автор";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Наименование";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(154, 126);
            this.Author.Margin = new System.Windows.Forms.Padding(2);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(332, 27);
            this.Author.TabIndex = 28;
            // 
            // ComName
            // 
            this.ComName.Location = new System.Drawing.Point(154, 75);
            this.ComName.Margin = new System.Windows.Forms.Padding(2);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(332, 27);
            this.ComName.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(-1, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Количество страниц";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(154, 277);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(332, 27);
            this.Price.TabIndex = 36;
            this.Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // CountPage
            // 
            this.CountPage.Location = new System.Drawing.Point(154, 226);
            this.CountPage.Margin = new System.Windows.Forms.Padding(2);
            this.CountPage.Name = "CountPage";
            this.CountPage.Size = new System.Drawing.Size(332, 27);
            this.CountPage.TabIndex = 35;
            this.CountPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountPage_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(551, 55);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Переплёт";
            // 
            // Binding
            // 
            this.Binding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Binding.FormattingEnabled = true;
            this.Binding.Location = new System.Drawing.Point(643, 51);
            this.Binding.Margin = new System.Windows.Forms.Padding(2);
            this.Binding.Name = "Binding";
            this.Binding.Size = new System.Drawing.Size(332, 28);
            this.Binding.TabIndex = 43;
            // 
            // BeckForm
            // 
            this.BeckForm.BackColor = System.Drawing.Color.Red;
            this.BeckForm.ForeColor = System.Drawing.Color.White;
            this.BeckForm.Location = new System.Drawing.Point(11, 11);
            this.BeckForm.Margin = new System.Windows.Forms.Padding(2);
            this.BeckForm.Name = "BeckForm";
            this.BeckForm.Size = new System.Drawing.Size(149, 41);
            this.BeckForm.TabIndex = 44;
            this.BeckForm.Text = "Назад";
            this.BeckForm.UseVisualStyleBackColor = false;
            this.BeckForm.Click += new System.EventHandler(this.BeckForm_Click);
            // 
            // DateCom
            // 
            this.DateCom.Location = new System.Drawing.Point(154, 171);
            this.DateCom.Name = "DateCom";
            this.DateCom.Size = new System.Drawing.Size(332, 27);
            this.DateCom.TabIndex = 45;
            // 
            // ComicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.DateCom);
            this.Controls.Add(this.BeckForm);
            this.Controls.Add(this.Binding);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CountPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SkladBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ComName);
            this.Controls.Add(this.UpComics);
            this.Controls.Add(this.DelComics);
            this.Controls.Add(this.AddComics);
            this.Controls.Add(this.DataComics);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ComicsForm";
            this.Text = "ComicsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComicsForm_FormClosed);
            this.Load += new System.EventHandler(this.ComicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataComics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpComics;
        private System.Windows.Forms.Button DelComics;
        private System.Windows.Forms.Button AddComics;
        public System.Windows.Forms.DataGridView DataComics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SkladBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox ComName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox CountPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Binding;
        private System.Windows.Forms.Button BeckForm;
        private System.Windows.Forms.DateTimePicker DateCom;
    }
}