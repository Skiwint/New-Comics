
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
    public partial class PostavForm : Form
    {
        AllModel<Supplier> supliers = new AllModel<Supplier>("Suppliers");
        
        public PostavForm()
        {
            InitializeComponent();
            if(RoleCheck.skladInt != 1)
            {
                SkladBtn.Visible = false;
                FilPoSklad.Visible = false;
                FilialBtn.Visible = false;
            }
            else
            {
                SkladBtn.Visible = true;
                FilPoSklad.Visible = true;
                FilialBtn.Visible = true;
            }
        }
        SkladForm skladForm = new SkladForm();
        private void button1_Click(object sender, EventArgs e)
        {
            if (RoleCheck.skladInt != 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                RegistrationForms registrationForms = new RegistrationForms();
                this.Hide();
                registrationForms.Show();
            }
        }

        private async void DelPostav_Click(object sender, EventArgs e)
        {
            await(DataPostav.SelectedRows[0].DataBoundItem as Supplier).Delete();
            DataPostav.DataSource = supliers.Objs;
        }

        private async void UpPostav_Click(object sender, EventArgs e)
        {
            if (DataPostav.SelectedRows[0].DataBoundItem is Supplier supplier)
            {
                supplier.Name = NameSup.Text;
                supplier.Adress = Adres.Text;
                supplier.Phone = PhoneTB1.Text;
                await supplier.Update();
            }
            NameSup.Text = "";
            Adres.Text = "";
            PhoneTB1.Text = "";
            DataPostav.DataSource = supliers.Objs;
        }

        private void PostavForm_Load(object sender, EventArgs e)
        {
            DataPostav.DataSource = supliers.Objs;
        }

        private async void AddPostav_Click(object sender, EventArgs e)
        {
            await new Supplier
            {
                Id = 0,
                Name = NameSup.Text,
                Adress = Adres.Text,
                Phone = PhoneTB1.Text,
            }.Add();
            NameSup.Text = "";
            Adres.Text = "";
            PhoneTB1.Text = "";
            DataPostav.DataSource = supliers.Objs;
        }

        private void PostavForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataPostav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameSup.Text = DataPostav.Rows[e.RowIndex].Cells[1].Value.ToString();
            Adres.Text = DataPostav.Rows[e.RowIndex].Cells[2].Value.ToString();
            PhoneTB1.Text = DataPostav.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void PhoneTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
               (!string.IsNullOrEmpty(PhoneTB1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void FilPoSklad_Click(object sender, EventArgs e)
        {
            FilForSkladForm filForSkladForm = new FilForSkladForm();
            this.Hide();
            filForSkladForm.Show();
        }

        private void FilialBtn_Click(object sender, EventArgs e)
        {
            FilialForm filialForm = new FilialForm();
            this.Hide();
            filialForm.Show();
        }

        private void SkladBtn_Click(object sender, EventArgs e)
        {
            SkladForm skladForm = new SkladForm();
            this.Hide();
            skladForm.Show();
        }
    }
}
