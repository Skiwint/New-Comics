
namespace Admin
{
    partial class RoleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DataRole = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Role_Del = new System.Windows.Forms.Button();
            this.Role_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataRole)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 27);
            this.textBox1.TabIndex = 0;
            // 
            // DataRole
            // 
            this.DataRole.AllowUserToAddRows = false;
            this.DataRole.AllowUserToDeleteRows = false;
            this.DataRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRole.Location = new System.Drawing.Point(10, 254);
            this.DataRole.Margin = new System.Windows.Forms.Padding(2);
            this.DataRole.MultiSelect = false;
            this.DataRole.Name = "DataRole";
            this.DataRole.ReadOnly = true;
            this.DataRole.RowHeadersWidth = 62;
            this.DataRole.RowTemplate.Height = 33;
            this.DataRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataRole.Size = new System.Drawing.Size(1085, 306);
            this.DataRole.TabIndex = 1;
            this.DataRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRole_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Role_Del
            // 
            this.Role_Del.BackColor = System.Drawing.Color.Black;
            this.Role_Del.ForeColor = System.Drawing.Color.White;
            this.Role_Del.Location = new System.Drawing.Point(134, 208);
            this.Role_Del.Margin = new System.Windows.Forms.Padding(2);
            this.Role_Del.Name = "Role_Del";
            this.Role_Del.Size = new System.Drawing.Size(90, 27);
            this.Role_Del.TabIndex = 3;
            this.Role_Del.Text = "Удалить";
            this.Role_Del.UseVisualStyleBackColor = false;
            this.Role_Del.Click += new System.EventHandler(this.Role_Del_Click);
            // 
            // Role_Update
            // 
            this.Role_Update.BackColor = System.Drawing.Color.Black;
            this.Role_Update.ForeColor = System.Drawing.Color.White;
            this.Role_Update.Location = new System.Drawing.Point(252, 208);
            this.Role_Update.Margin = new System.Windows.Forms.Padding(2);
            this.Role_Update.Name = "Role_Update";
            this.Role_Update.Size = new System.Drawing.Size(90, 27);
            this.Role_Update.TabIndex = 4;
            this.Role_Update.Text = "Изменить";
            this.Role_Update.UseVisualStyleBackColor = false;
            this.Role_Update.Click += new System.EventHandler(this.Role_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название роли";
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(15, 11);
            this.BackForm.Margin = new System.Windows.Forms.Padding(2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(105, 36);
            this.BackForm.TabIndex = 6;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 570);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Role_Update);
            this.Controls.Add(this.Role_Del);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataRole);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoleForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoleForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DataRole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Role_Del;
        private System.Windows.Forms.Button Role_Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackForm;
    }
}

