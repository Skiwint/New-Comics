
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Froms
{
    public partial class FilialForm : Form
    {
        AllModel<Branch> branches = new AllModel<Branch>("Branches");
        
        public FilialForm()
        {
            InitializeComponent();
            if (RoleCheck.skladInt != 1)
            {
                FilPoSklad.Visible = false;
                SkladBtn.Visible = false;
                PostavBtn.Visible = false;
            }
            else
            {
                FilPoSklad.Visible = true;
                SkladBtn.Visible = true;
                PostavBtn.Visible = true;
            }
        }
        SkladForm skladForm = new SkladForm();
        private void BackForm_Click(object sender, EventArgs e)
        {
            if (RoleCheck.skladInt != 0)
            {
                RegistrationForms registrationForms = new RegistrationForms();
                this.Hide();
                registrationForms.Show();
            }
            else
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
                
            }
        }

        private async void AddFilial_Click(object sender, EventArgs e)
        {
            await new Branch
            {
                Id = 0,
                Adress = FilName.Text,
            }.Add();
            FilName.Text = "";
            DataFilial.DataSource = branches.Objs;
        }

        private async void DelFilial_Click(object sender, EventArgs e)
        {
            await (DataFilial.SelectedRows[0].DataBoundItem as Branch).Delete();
            DataFilial.DataSource = branches.Objs;
        }

        private async void UpFilial_Click(object sender, EventArgs e)
        {
            if (DataFilial.SelectedRows[0].DataBoundItem is Branch branch)
            {
                branch.Adress= FilName.Text;
                await branch.Update();
            }
            FilName.Text = "";
            DataFilial.DataSource = branches.Objs;
        }

        private void FilialForm_Load(object sender, EventArgs e)
        {
            DataFilial.DataSource = branches.Objs;
        }

        private void FilialForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataFilial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FilName.Text = DataFilial.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void PostavBtn_Click(object sender, EventArgs e)
        {
            PostavForm postavForm = new PostavForm();
            this.Hide();
            postavForm.Show();
        }

        private void FilPoSklad_Click(object sender, EventArgs e)
        {
            FilForSkladForm filForSkladForm = new FilForSkladForm();
            this.Hide();
            filForSkladForm.Show();
        }

        private void SkladBtn_Click(object sender, EventArgs e)
        {
            SkladForm skladForm = new SkladForm();
            this.Hide();
            skladForm.Show();
        }
    }
}
