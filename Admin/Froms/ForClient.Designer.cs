namespace Admin.Froms
{
    partial class ForClient
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
            this.DataStuff = new System.Windows.Forms.DataGridView();
            this.LinkView = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // DataStuff
            // 
            this.DataStuff.AllowUserToAddRows = false;
            this.DataStuff.AllowUserToDeleteRows = false;
            this.DataStuff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataStuff.Location = new System.Drawing.Point(252, 12);
            this.DataStuff.MultiSelect = false;
            this.DataStuff.Name = "DataStuff";
            this.DataStuff.ReadOnly = true;
            this.DataStuff.RowHeadersWidth = 51;
            this.DataStuff.RowTemplate.Height = 29;
            this.DataStuff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataStuff.Size = new System.Drawing.Size(1638, 1009);
            this.DataStuff.TabIndex = 0;
            // 
            // LinkView
            // 
            this.LinkView.Location = new System.Drawing.Point(24, 276);
            this.LinkView.Name = "LinkView";
            this.LinkView.Size = new System.Drawing.Size(179, 49);
            this.LinkView.TabIndex = 1;
            this.LinkView.Text = "Просмотр товара";
            this.LinkView.UseVisualStyleBackColor = true;
            this.LinkView.Click += new System.EventHandler(this.LinkView_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Red;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(24, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(179, 49);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LinkView);
            this.Controls.Add(this.DataStuff);
            this.Name = "ForClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForClient_FormClosed);
            this.Load += new System.EventHandler(this.ForClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataStuff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataStuff;
        private System.Windows.Forms.Button LinkView;
        private System.Windows.Forms.Button BackBtn;
    }
}