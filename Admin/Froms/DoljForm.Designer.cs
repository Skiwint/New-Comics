namespace Admin.Froms
{
    partial class DoljForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Grarph = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostOklad = new System.Windows.Forms.TextBox();
            this.NamePost = new System.Windows.Forms.TextBox();
            this.UpDol = new System.Windows.Forms.Button();
            this.DelDol = new System.Windows.Forms.Button();
            this.AddDol = new System.Windows.Forms.Button();
            this.DataDol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataDol)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "График";
            // 
            // Grarph
            // 
            this.Grarph.Location = new System.Drawing.Point(139, 202);
            this.Grarph.Margin = new System.Windows.Forms.Padding(2);
            this.Grarph.Name = "Grarph";
            this.Grarph.Size = new System.Drawing.Size(332, 27);
            this.Grarph.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Оклад";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Наименование";
            // 
            // PostOklad
            // 
            this.PostOklad.Location = new System.Drawing.Point(139, 155);
            this.PostOklad.Margin = new System.Windows.Forms.Padding(2);
            this.PostOklad.Name = "PostOklad";
            this.PostOklad.Size = new System.Drawing.Size(332, 27);
            this.PostOklad.TabIndex = 24;
            // 
            // NamePost
            // 
            this.NamePost.Location = new System.Drawing.Point(139, 104);
            this.NamePost.Margin = new System.Windows.Forms.Padding(2);
            this.NamePost.Name = "NamePost";
            this.NamePost.Size = new System.Drawing.Size(332, 27);
            this.NamePost.TabIndex = 23;
            // 
            // UpDol
            // 
            this.UpDol.BackColor = System.Drawing.Color.Black;
            this.UpDol.ForeColor = System.Drawing.Color.White;
            this.UpDol.Location = new System.Drawing.Point(955, 260);
            this.UpDol.Margin = new System.Windows.Forms.Padding(2);
            this.UpDol.Name = "UpDol";
            this.UpDol.Size = new System.Drawing.Size(149, 41);
            this.UpDol.TabIndex = 22;
            this.UpDol.Text = "Изменить";
            this.UpDol.UseVisualStyleBackColor = false;
            this.UpDol.Click += new System.EventHandler(this.UpDol_Click);
            // 
            // DelDol
            // 
            this.DelDol.BackColor = System.Drawing.Color.Black;
            this.DelDol.ForeColor = System.Drawing.Color.White;
            this.DelDol.Location = new System.Drawing.Point(801, 260);
            this.DelDol.Margin = new System.Windows.Forms.Padding(2);
            this.DelDol.Name = "DelDol";
            this.DelDol.Size = new System.Drawing.Size(149, 41);
            this.DelDol.TabIndex = 21;
            this.DelDol.Text = "Удалить";
            this.DelDol.UseVisualStyleBackColor = false;
            this.DelDol.Click += new System.EventHandler(this.DelDol_Click);
            // 
            // AddDol
            // 
            this.AddDol.BackColor = System.Drawing.Color.Black;
            this.AddDol.ForeColor = System.Drawing.Color.White;
            this.AddDol.Location = new System.Drawing.Point(648, 260);
            this.AddDol.Margin = new System.Windows.Forms.Padding(2);
            this.AddDol.Name = "AddDol";
            this.AddDol.Size = new System.Drawing.Size(149, 41);
            this.AddDol.TabIndex = 20;
            this.AddDol.Text = "Добавить";
            this.AddDol.UseVisualStyleBackColor = false;
            this.AddDol.Click += new System.EventHandler(this.AddDol_Click);
            // 
            // DataDol
            // 
            this.DataDol.AllowUserToAddRows = false;
            this.DataDol.AllowUserToDeleteRows = false;
            this.DataDol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDol.Location = new System.Drawing.Point(9, 324);
            this.DataDol.Margin = new System.Windows.Forms.Padding(2);
            this.DataDol.MultiSelect = false;
            this.DataDol.Name = "DataDol";
            this.DataDol.ReadOnly = true;
            this.DataDol.RowHeadersWidth = 62;
            this.DataDol.RowTemplate.Height = 33;
            this.DataDol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataDol.Size = new System.Drawing.Size(1196, 316);
            this.DataDol.TabIndex = 19;
            this.DataDol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDol_CellContentClick);
            // 
            // DoljForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grarph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostOklad);
            this.Controls.Add(this.NamePost);
            this.Controls.Add(this.UpDol);
            this.Controls.Add(this.DelDol);
            this.Controls.Add(this.AddDol);
            this.Controls.Add(this.DataDol);
            this.Name = "DoljForm";
            this.Text = "DoljForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoljForm_FormClosed);
            this.Load += new System.EventHandler(this.DoljForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Grarph;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostOklad;
        private System.Windows.Forms.TextBox NamePost;
        private System.Windows.Forms.Button UpDol;
        private System.Windows.Forms.Button DelDol;
        private System.Windows.Forms.Button AddDol;
        private System.Windows.Forms.DataGridView DataDol;
    }
}