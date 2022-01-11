using Admin.Froms;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UserForm_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.Show();
        }

        private void RoleForm_Click(object sender, EventArgs e)
        {
            RoleForm roleForm = new RoleForm();
            this.Hide();
            roleForm.Show();
        }

        private void ComicsForm_Click(object sender, EventArgs e)
        {
            ComicsForm comics = new ComicsForm();
            this.Hide();
            comics.Show();
        }
        
        private void SklasForm_Click(object sender, EventArgs e)
        {
            SkladForm skladForm = new SkladForm();
            this.Hide();
            skladForm.Show();
        }

        private void FilialForm_Click(object sender, EventArgs e)
        {
            FilialForm button = new FilialForm();
            this.Hide();
            button.Show();
        }

        private void FilialSkalForm_Click(object sender, EventArgs e)
        {
            FilForSkladForm filForSkladForm = new FilForSkladForm();
            this.Hide();
            filForSkladForm.Show();
        }

        private void SotrudnikiForm_Click(object sender, EventArgs e)
        {
            Сотрудники employeeForm = new Сотрудники();
            this.Hide();
            employeeForm.Show();
        }

        private void ClientForm_Click(object sender, EventArgs e)
        {
            ClientForm button = new ClientForm();
            this.Hide();
            button.Show();
        }

        private void PostavForm_Click(object sender, EventArgs e)
        {
            PostavForm postav = new PostavForm();
            this.Hide();
            postav.Show();
        }

        private void SaleForm_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            this.Hide();
            sale.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            this.Hide();
            searchForm.Show();
        }

        private void DolBtn_Click(object sender, EventArgs e)
        {
            DoljForm doljForm = new DoljForm();
            this.Hide();
            doljForm.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackRegistration_Click(object sender, EventArgs e)
        {
            RegistrationForms registrationForms = new RegistrationForms();
            this.Hide();
            registrationForms.Show();
        }

        private void ForClin_Click(object sender, EventArgs e)
        {
            ForClient forClient = new ForClient();
            this.Hide();
            forClient.Show();
        }
    }
}
