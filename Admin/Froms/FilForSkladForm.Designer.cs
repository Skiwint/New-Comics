namespace Admin.Froms
{
    partial class FilForSkladForm
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
            this.SkladBox = new System.Windows.Forms.ComboBox();
            this.UpSfF = new System.Windows.Forms.Button();
            this.DelSfF = new System.Windows.Forms.Button();
            this.AddSfF = new System.Windows.Forms.Button();
            this.DataSfF = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilialBox = new System.Windows.Forms.ComboBox();
            this.Filialbtn = new System.Windows.Forms.Button();
            this.SkladBtn = new System.Windows.Forms.Button();
            this.PostavBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSfF)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(64, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Склад";
            // 
            // SkladBox
            // 
            this.SkladBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkladBox.FormattingEnabled = true;
            this.SkladBox.Location = new System.Drawing.Point(131, 232);
            this.SkladBox.Margin = new System.Windows.Forms.Padding(2);
            this.SkladBox.Name = "SkladBox";
            this.SkladBox.Size = new System.Drawing.Size(332, 28);
            this.SkladBox.TabIndex = 19;
            // 
            // UpSfF
            // 
            this.UpSfF.BackColor = System.Drawing.Color.Black;
            this.UpSfF.ForeColor = System.Drawing.Color.White;
            this.UpSfF.Location = new System.Drawing.Point(955, 261);
            this.UpSfF.Margin = new System.Windows.Forms.Padding(2);
            this.UpSfF.Name = "UpSfF";
            this.UpSfF.Size = new System.Drawing.Size(149, 41);
            this.UpSfF.TabIndex = 18;
            this.UpSfF.Text = "Изменить";
            this.UpSfF.UseVisualStyleBackColor = false;
            this.UpSfF.Click += new System.EventHandler(this.UpSfF_Click);
            // 
            // DelSfF
            // 
            this.DelSfF.BackColor = System.Drawing.Color.Black;
            this.DelSfF.ForeColor = System.Drawing.Color.White;
            this.DelSfF.Location = new System.Drawing.Point(801, 261);
            this.DelSfF.Margin = new System.Windows.Forms.Padding(2);
            this.DelSfF.Name = "DelSfF";
            this.DelSfF.Size = new System.Drawing.Size(149, 41);
            this.DelSfF.TabIndex = 17;
            this.DelSfF.Text = "Удалить";
            this.DelSfF.UseVisualStyleBackColor = false;
            this.DelSfF.Click += new System.EventHandler(this.DelSfF_Click);
            // 
            // AddSfF
            // 
            this.AddSfF.BackColor = System.Drawing.Color.Black;
            this.AddSfF.ForeColor = System.Drawing.Color.White;
            this.AddSfF.Location = new System.Drawing.Point(648, 261);
            this.AddSfF.Margin = new System.Windows.Forms.Padding(2);
            this.AddSfF.Name = "AddSfF";
            this.AddSfF.Size = new System.Drawing.Size(149, 41);
            this.AddSfF.TabIndex = 16;
            this.AddSfF.Text = "Добавить";
            this.AddSfF.UseVisualStyleBackColor = false;
            this.AddSfF.Click += new System.EventHandler(this.AddSfF_Click);
            // 
            // DataSfF
            // 
            this.DataSfF.AllowUserToAddRows = false;
            this.DataSfF.AllowUserToDeleteRows = false;
            this.DataSfF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSfF.Location = new System.Drawing.Point(9, 325);
            this.DataSfF.Margin = new System.Windows.Forms.Padding(2);
            this.DataSfF.MultiSelect = false;
            this.DataSfF.Name = "DataSfF";
            this.DataSfF.ReadOnly = true;
            this.DataSfF.RowHeadersWidth = 62;
            this.DataSfF.RowTemplate.Height = 33;
            this.DataSfF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSfF.Size = new System.Drawing.Size(1196, 316);
            this.DataSfF.TabIndex = 15;
            this.DataSfF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSfF_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Филал";
            // 
            // FilialBox
            // 
            this.FilialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilialBox.FormattingEnabled = true;
            this.FilialBox.Location = new System.Drawing.Point(131, 179);
            this.FilialBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilialBox.Name = "FilialBox";
            this.FilialBox.Size = new System.Drawing.Size(332, 28);
            this.FilialBox.TabIndex = 22;
            // 
            // Filialbtn
            // 
            this.Filialbtn.BackColor = System.Drawing.Color.Black;
            this.Filialbtn.ForeColor = System.Drawing.Color.White;
            this.Filialbtn.Location = new System.Drawing.Point(1055, 11);
            this.Filialbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Filialbtn.Name = "Filialbtn";
            this.Filialbtn.Size = new System.Drawing.Size(149, 41);
            this.Filialbtn.TabIndex = 33;
            this.Filialbtn.Text = "Филиал";
            this.Filialbtn.UseVisualStyleBackColor = false;
            this.Filialbtn.Click += new System.EventHandler(this.Filialbtn_Click);
            // 
            // SkladBtn
            // 
            this.SkladBtn.BackColor = System.Drawing.Color.Black;
            this.SkladBtn.ForeColor = System.Drawing.Color.White;
            this.SkladBtn.Location = new System.Drawing.Point(1055, 101);
            this.SkladBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SkladBtn.Name = "SkladBtn";
            this.SkladBtn.Size = new System.Drawing.Size(149, 41);
            this.SkladBtn.TabIndex = 32;
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
            this.PostavBtn.TabIndex = 31;
            this.PostavBtn.Text = "Поставщик";
            this.PostavBtn.UseVisualStyleBackColor = false;
            this.PostavBtn.Click += new System.EventHandler(this.PostavBtn_Click);
            // 
            // FilForSkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.Filialbtn);
            this.Controls.Add(this.SkladBtn);
            this.Controls.Add(this.PostavBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilialBox);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SkladBox);
            this.Controls.Add(this.UpSfF);
            this.Controls.Add(this.DelSfF);
            this.Controls.Add(this.AddSfF);
            this.Controls.Add(this.DataSfF);
            this.Name = "FilForSkladForm";
            this.Text = "FilForSkladForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FilForSkladForm_FormClosed);
            this.Load += new System.EventHandler(this.FilForSkladForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSfF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SkladBox;
        private System.Windows.Forms.Button UpSfF;
        private System.Windows.Forms.Button DelSfF;
        private System.Windows.Forms.Button AddSfF;
        private System.Windows.Forms.DataGridView DataSfF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FilialBox;
        public System.Windows.Forms.Button Filialbtn;
        public System.Windows.Forms.Button SkladBtn;
        public System.Windows.Forms.Button PostavBtn;
    }
}