namespace Admin.Froms
{
    partial class SearchForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExportSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SortExport = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SortirBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTableSort = new System.Windows.Forms.Button();
            this.SorTablBox = new System.Windows.Forms.ComboBox();
            this.SearchTB = new System.Windows.Forms.TextBox();
            this.DataSort = new System.Windows.Forms.DataGridView();
            this.SortableBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VidBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectVidSearch = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.DataSearchSh = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectExp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectTabel = new System.Windows.Forms.Button();
            this.ExBtn = new System.Windows.Forms.Button();
            this.TablEx = new System.Windows.Forms.ComboBox();
            this.DataExp = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.м = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSort)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchSh)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataExp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 623);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.SelectTabel_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ExportSort);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.SortExport);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.SortirBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.SelectTableSort);
            this.tabPage1.Controls.Add(this.SorTablBox);
            this.tabPage1.Controls.Add(this.SearchTB);
            this.tabPage1.Controls.Add(this.DataSort);
            this.tabPage1.Controls.Add(this.SortableBtn);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сортировка";
            // 
            // ExportSort
            // 
            this.ExportSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportSort.BackColor = System.Drawing.Color.Black;
            this.ExportSort.ForeColor = System.Drawing.Color.White;
            this.ExportSort.Location = new System.Drawing.Point(1015, 162);
            this.ExportSort.Name = "ExportSort";
            this.ExportSort.Size = new System.Drawing.Size(189, 47);
            this.ExportSort.TabIndex = 11;
            this.ExportSort.Text = "Экспортировать";
            this.ExportSort.UseVisualStyleBackColor = false;
            this.ExportSort.Click += new System.EventHandler(this.ExportSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(509, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Выберете способ\r\nэкспорта";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortExport
            // 
            this.SortExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortExport.FormattingEnabled = true;
            this.SortExport.Location = new System.Drawing.Point(646, 151);
            this.SortExport.Name = "SortExport";
            this.SortExport.Size = new System.Drawing.Size(229, 28);
            this.SortExport.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(509, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберете способ\r\nсортировки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortirBox
            // 
            this.SortirBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortirBox.FormattingEnabled = true;
            this.SortirBox.Location = new System.Drawing.Point(646, 56);
            this.SortirBox.Name = "SortirBox";
            this.SortirBox.Size = new System.Drawing.Size(229, 28);
            this.SortirBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите столбец, который\r\nбудет сортироваться";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберете таблицу";
            // 
            // SelectTableSort
            // 
            this.SelectTableSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectTableSort.BackColor = System.Drawing.Color.Black;
            this.SelectTableSort.ForeColor = System.Drawing.Color.White;
            this.SelectTableSort.Location = new System.Drawing.Point(1015, 56);
            this.SelectTableSort.Name = "SelectTableSort";
            this.SelectTableSort.Size = new System.Drawing.Size(189, 47);
            this.SelectTableSort.TabIndex = 4;
            this.SelectTableSort.Text = "Выбрать";
            this.SelectTableSort.UseVisualStyleBackColor = false;
            this.SelectTableSort.Click += new System.EventHandler(this.SelectTableSort_Click);
            // 
            // SorTablBox
            // 
            this.SorTablBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SorTablBox.FormattingEnabled = true;
            this.SorTablBox.Location = new System.Drawing.Point(232, 56);
            this.SorTablBox.Name = "SorTablBox";
            this.SorTablBox.Size = new System.Drawing.Size(229, 28);
            this.SorTablBox.TabIndex = 3;
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(232, 151);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(229, 27);
            this.SearchTB.TabIndex = 2;
            // 
            // DataSort
            // 
            this.DataSort.AllowUserToAddRows = false;
            this.DataSort.AllowUserToDeleteRows = false;
            this.DataSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSort.Location = new System.Drawing.Point(6, 246);
            this.DataSort.Name = "DataSort";
            this.DataSort.ReadOnly = true;
            this.DataSort.RowHeadersWidth = 51;
            this.DataSort.RowTemplate.Height = 29;
            this.DataSort.Size = new System.Drawing.Size(1195, 338);
            this.DataSort.TabIndex = 1;
            // 
            // SortableBtn
            // 
            this.SortableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortableBtn.BackColor = System.Drawing.Color.Black;
            this.SortableBtn.ForeColor = System.Drawing.Color.White;
            this.SortableBtn.Location = new System.Drawing.Point(1015, 109);
            this.SortableBtn.Name = "SortableBtn";
            this.SortableBtn.Size = new System.Drawing.Size(189, 47);
            this.SortableBtn.TabIndex = 0;
            this.SortableBtn.Text = "Сортировать";
            this.SortableBtn.UseVisualStyleBackColor = false;
            this.SortableBtn.Click += new System.EventHandler(this.SortableBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.VidBtn);
            this.tabPage2.Controls.Add(this.SearchBtn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.SelectVidSearch);
            this.tabPage2.Controls.Add(this.SearchTextBox);
            this.tabPage2.Controls.Add(this.DataSearchSh);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // VidBtn
            // 
            this.VidBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VidBtn.BackColor = System.Drawing.Color.Black;
            this.VidBtn.ForeColor = System.Drawing.Color.White;
            this.VidBtn.Location = new System.Drawing.Point(1010, 84);
            this.VidBtn.Name = "VidBtn";
            this.VidBtn.Size = new System.Drawing.Size(189, 47);
            this.VidBtn.TabIndex = 12;
            this.VidBtn.Text = "Выбрать";
            this.VidBtn.UseVisualStyleBackColor = false;
            this.VidBtn.Click += new System.EventHandler(this.VidBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackColor = System.Drawing.Color.Black;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Location = new System.Drawing.Point(1010, 152);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(189, 47);
            this.SearchBtn.TabIndex = 11;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Введите значение для поиска\r\n(Значение для поиска в 2 столбце)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(89, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Выберете таблицу";
            // 
            // SelectVidSearch
            // 
            this.SelectVidSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectVidSearch.FormattingEnabled = true;
            this.SelectVidSearch.Location = new System.Drawing.Point(232, 53);
            this.SelectVidSearch.Name = "SelectVidSearch";
            this.SelectVidSearch.Size = new System.Drawing.Size(229, 28);
            this.SelectVidSearch.TabIndex = 8;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(232, 138);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(229, 27);
            this.SearchTextBox.TabIndex = 7;
            // 
            // DataSearchSh
            // 
            this.DataSearchSh.AllowUserToAddRows = false;
            this.DataSearchSh.AllowUserToDeleteRows = false;
            this.DataSearchSh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSearchSh.Location = new System.Drawing.Point(6, 244);
            this.DataSearchSh.Name = "DataSearchSh";
            this.DataSearchSh.ReadOnly = true;
            this.DataSearchSh.RowHeadersWidth = 51;
            this.DataSearchSh.RowTemplate.Height = 29;
            this.DataSearchSh.Size = new System.Drawing.Size(1195, 338);
            this.DataSearchSh.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.SelectExp);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.SelectTabel);
            this.tabPage3.Controls.Add(this.ExBtn);
            this.tabPage3.Controls.Add(this.TablEx);
            this.tabPage3.Controls.Add(this.DataExp);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1207, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Экспорт";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(351, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберете способ экспорта";
            // 
            // SelectExp
            // 
            this.SelectExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectExp.FormattingEnabled = true;
            this.SelectExp.Location = new System.Drawing.Point(351, 41);
            this.SelectExp.Name = "SelectExp";
            this.SelectExp.Size = new System.Drawing.Size(204, 28);
            this.SelectExp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "выберете таблицу";
            // 
            // SelectTabel
            // 
            this.SelectTabel.BackColor = System.Drawing.Color.Black;
            this.SelectTabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTabel.ForeColor = System.Drawing.Color.White;
            this.SelectTabel.Location = new System.Drawing.Point(669, 8);
            this.SelectTabel.Name = "SelectTabel";
            this.SelectTabel.Size = new System.Drawing.Size(204, 61);
            this.SelectTabel.TabIndex = 4;
            this.SelectTabel.Text = "Выбрать";
            this.SelectTabel.UseVisualStyleBackColor = false;
            this.SelectTabel.Click += new System.EventHandler(this.SelectTabel_Click);
            // 
            // ExBtn
            // 
            this.ExBtn.BackColor = System.Drawing.Color.Black;
            this.ExBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExBtn.ForeColor = System.Drawing.Color.White;
            this.ExBtn.Location = new System.Drawing.Point(879, 8);
            this.ExBtn.Name = "ExBtn";
            this.ExBtn.Size = new System.Drawing.Size(320, 61);
            this.ExBtn.TabIndex = 3;
            this.ExBtn.Text = "Экспорт";
            this.ExBtn.UseVisualStyleBackColor = false;
            this.ExBtn.Click += new System.EventHandler(this.ExBtn_Click);
            // 
            // TablEx
            // 
            this.TablEx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablEx.FormattingEnabled = true;
            this.TablEx.Location = new System.Drawing.Point(31, 41);
            this.TablEx.Name = "TablEx";
            this.TablEx.Size = new System.Drawing.Size(263, 28);
            this.TablEx.TabIndex = 2;
            // 
            // DataExp
            // 
            this.DataExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataExp.Location = new System.Drawing.Point(8, 97);
            this.DataExp.Name = "DataExp";
            this.DataExp.RowHeadersWidth = 51;
            this.DataExp.RowTemplate.Height = 29;
            this.DataExp.Size = new System.Drawing.Size(1191, 485);
            this.DataExp.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 651);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSort)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSearchSh)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataExp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SelectTabel;
        private System.Windows.Forms.Button ExBtn;
        private System.Windows.Forms.ComboBox TablEx;
        private System.Windows.Forms.DataGridView DataExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectTableSort;
        private System.Windows.Forms.ComboBox SorTablBox;
        private System.Windows.Forms.TextBox SearchTB;
        private System.Windows.Forms.DataGridView DataSort;
        private System.Windows.Forms.Button SortableBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SortirBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SortExport;
        private System.Windows.Forms.Button ExportSort;
        private System.ComponentModel.BackgroundWorker м;
        private System.Windows.Forms.DataGridView DataSearchSh;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SelectVidSearch;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button VidBtn;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}