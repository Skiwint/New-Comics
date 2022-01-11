namespace Admin.Froms
{
    partial class FilialForm
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
            this.UpFilial = new System.Windows.Forms.Button();
            this.DelFilial = new System.Windows.Forms.Button();
            this.AddFilial = new System.Windows.Forms.Button();
            this.DataFilial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilName = new System.Windows.Forms.TextBox();
            this.FilPoSklad = new System.Windows.Forms.Button();
            this.SkladBtn = new System.Windows.Forms.Button();
            this.PostavBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataFilial)).BeginInit();
            this.SuspendLayout();
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(11, 11);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(149, 41);
            this.BackForm.TabIndex = 25;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // UpFilial
            // 
            this.UpFilial.BackColor = System.Drawing.Color.Black;
            this.UpFilial.ForeColor = System.Drawing.Color.White;
            this.UpFilial.Location = new System.Drawing.Point(1036, 266);
            this.UpFilial.Margin = new System.Windows.Forms.Padding(2);
            this.UpFilial.Name = "UpFilial";
            this.UpFilial.Size = new System.Drawing.Size(149, 41);
            this.UpFilial.TabIndex = 22;
            this.UpFilial.Text = "Изменить";
            this.UpFilial.UseVisualStyleBackColor = false;
            this.UpFilial.Click += new System.EventHandler(this.UpFilial_Click);
            // 
            // DelFilial
            // 
            this.DelFilial.BackColor = System.Drawing.Color.Black;
            this.DelFilial.ForeColor = System.Drawing.Color.White;
            this.DelFilial.Location = new System.Drawing.Point(882, 266);
            this.DelFilial.Margin = new System.Windows.Forms.Padding(2);
            this.DelFilial.Name = "DelFilial";
            this.DelFilial.Size = new System.Drawing.Size(149, 41);
            this.DelFilial.TabIndex = 21;
            this.DelFilial.Text = "Удалить";
            this.DelFilial.UseVisualStyleBackColor = false;
            this.DelFilial.Click += new System.EventHandler(this.DelFilial_Click);
            // 
            // AddFilial
            // 
            this.AddFilial.BackColor = System.Drawing.Color.Black;
            this.AddFilial.ForeColor = System.Drawing.Color.White;
            this.AddFilial.Location = new System.Drawing.Point(729, 266);
            this.AddFilial.Margin = new System.Windows.Forms.Padding(2);
            this.AddFilial.Name = "AddFilial";
            this.AddFilial.Size = new System.Drawing.Size(149, 41);
            this.AddFilial.TabIndex = 20;
            this.AddFilial.Text = "Добавить";
            this.AddFilial.UseVisualStyleBackColor = false;
            this.AddFilial.Click += new System.EventHandler(this.AddFilial_Click);
            // 
            // DataFilial
            // 
            this.DataFilial.AllowUserToAddRows = false;
            this.DataFilial.AllowUserToDeleteRows = false;
            this.DataFilial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFilial.Location = new System.Drawing.Point(11, 324);
            this.DataFilial.Margin = new System.Windows.Forms.Padding(2);
            this.DataFilial.MultiSelect = false;
            this.DataFilial.Name = "DataFilial";
            this.DataFilial.ReadOnly = true;
            this.DataFilial.RowHeadersWidth = 62;
            this.DataFilial.RowTemplate.Height = 33;
            this.DataFilial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFilial.Size = new System.Drawing.Size(1196, 316);
            this.DataFilial.TabIndex = 19;
            this.DataFilial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFilial_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Адрес";
            // 
            // FilName
            // 
            this.FilName.Location = new System.Drawing.Point(94, 178);
            this.FilName.Margin = new System.Windows.Forms.Padding(2);
            this.FilName.Name = "FilName";
            this.FilName.Size = new System.Drawing.Size(332, 27);
            this.FilName.TabIndex = 26;
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
            // SkladBtn
            // 
            this.SkladBtn.BackColor = System.Drawing.Color.Black;
            this.SkladBtn.ForeColor = System.Drawing.Color.White;
            this.SkladBtn.Location = new System.Drawing.Point(1055, 101);
            this.SkladBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SkladBtn.Name = "SkladBtn";
            this.SkladBtn.Size = new System.Drawing.Size(149, 41);
            this.SkladBtn.TabIndex = 29;
            this.SkladBtn.Text = "Склад";
            this.SkladBtn.UseVisualStyleBackColor = false;
            this.SkladBtn.Click += new System.EventHandler(this.SkladBtn_Click);
            // 
            // PostavBtn
            // 
            this.PostavBtn.BackColor = System.Drawing.Color.Black;
            this.PostavBtn.ForeColor = System.Drawing.Color.White;
            this.PostavBtn.Location = new System.Drawing.Point(1055, 56);
            this.PostavBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PostavBtn.Name = "PostavBtn";
            this.PostavBtn.Size = new System.Drawing.Size(149, 41);
            this.PostavBtn.TabIndex = 28;
            this.PostavBtn.Text = "Поставщик";
            this.PostavBtn.UseVisualStyleBackColor = false;
            this.PostavBtn.Click += new System.EventHandler(this.PostavBtn_Click);
            // 
            // FilialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.FilPoSklad);
            this.Controls.Add(this.SkladBtn);
            this.Controls.Add(this.PostavBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilName);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.UpFilial);
            this.Controls.Add(this.DelFilial);
            this.Controls.Add(this.AddFilial);
            this.Controls.Add(this.DataFilial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FilialForm";
            this.Text = "FilialForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilialForm_FormClosed);
            this.Load += new System.EventHandler(this.FilialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataFilial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Button UpFilial;
        private System.Windows.Forms.Button DelFilial;
        private System.Windows.Forms.Button AddFilial;
        private System.Windows.Forms.DataGridView DataFilial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilName;
        public System.Windows.Forms.Button FilPoSklad;
        public System.Windows.Forms.Button SkladBtn;
        public System.Windows.Forms.Button PostavBtn;
    }
}