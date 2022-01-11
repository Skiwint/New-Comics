using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class RoleForm : Form
    {
        AllModel<Role> roles = new AllModel<Role>("Roles");
      
        public RoleForm()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role();
                role.RoleName = textBox1.Text;
                await role.Add();
                textBox1.Text = "";
                DataRole.DataSource = roles.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataRole.DataSource = roles.Objs;
        }

        private async void Role_Del_Click(object sender, EventArgs e)
        {
            await (DataRole.SelectedRows[0].DataBoundItem as Role).Delete();
            DataRole.DataSource = roles.Objs;
        }

        private async void Role_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataRole.SelectedRows[0].DataBoundItem is Role role)
                {
                    role.RoleName = textBox1.Text;
                    await role.Update();
                }
                textBox1.Text = "";
                DataRole.DataSource = roles.Objs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void RoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = DataRole.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }
    }
}
