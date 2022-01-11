using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class Users : Form
    {
        AllModel<Role> roles = new AllModel<Role>("Roles");
        AllModel<User> users = new AllModel<User>("Users");

        public Users()
        {
            InitializeComponent();
        }

        private async void AddUser_Click(object sender, EventArgs e)
        {
            var Pass = GetHash(Password.Text);
            await new User
            {
                Id = 0,
                Login = Login.Text,
                Password = Pass,
                RoleId = RoleBox.SelectedValue as int?,
            }.Add();
            DataUser.DataSource = users.Objs;
        }
        private void Users_Load(object sender, EventArgs e)
        {
            DataUser.DataSource = users.Objs;

            RoleBox.DataSource = roles.Objs;
            RoleBox.DisplayMember = "RoleName";
            RoleBox.ValueMember = "Id";
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void DelUser_Click(object sender, EventArgs e)
        {
            await (DataUser.SelectedRows[0].DataBoundItem as User).Delete();
            DataUser.DataSource = users.Objs;
        }

        private async void UpUser_Click(object sender, EventArgs e)
        {
            if(DataUser.SelectedRows[0].DataBoundItem is User user)
            {
                user.Login = Login.Text;
                user.Password = GetHash(Password.Text);
                user.RoleId = RoleBox.SelectedValue as int?;
                await user.Update();
            }
            DataUser.DataSource = users.Objs;
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            
            return Convert.ToBase64String(hash);
        }

        private void DataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.Text = DataUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            Password.Text = DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            RoleBox.Text = DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
