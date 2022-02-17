
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
    public partial class SkladForm : Form
    {
        AllModel<Sklad> sklads = new AllModel<Sklad>("Sklads");
        AllModel<Supplier> supplier = new AllModel<Supplier>("Suppliers");
        
        public SkladForm()
        {
            InitializeComponent();
            if(RoleCheck.skladInt != 0)
            {
                PostavBtn.Visible = true;
                FilialBtn.Visible = true;
                FilPoSklad.Visible = true;
               
            }
            else
            {
                PostavBtn.Visible = false;
                FilialBtn.Visible = false;
                FilPoSklad.Visible = false;
            }
        }
        public int x;
        private void BackForm_Click(object sender, EventArgs e)
        {
            if (RoleCheck.skladInt == 0)
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

        private async void AddSklad_Click(object sender, EventArgs e)
        {
            try
            {
                await new Sklad
                {
                    Id = 0,
                    Adress = Adres.Text,
                    Capacity = Vmest.Text,
                    Phone = PhoneTB1.Text,
                    SupplierId = PostavBox.SelectedValue as int?,
                }.Add();
                DataSklad.DataSource = sklads.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelSklad_Click(object sender, EventArgs e)
        {
            await(DataSklad.SelectedRows[0].DataBoundItem as Sklad).Delete();
            DataSklad.DataSource = sklads.Objs;

        }

        private async void UpSklad_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataSklad.SelectedRows[0].DataBoundItem is Sklad sklad)
                {
                    sklad.Adress = Adres.Text;
                    sklad.Capacity = Vmest.Text;
                    sklad.Phone = PhoneTB1.Text;
                    sklad.SupplierId = PostavBox.SelectedValue as int?;
                    await sklad.Update();
                }
                DataSklad.DataSource = sklads.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SkladForm_Load(object sender, EventArgs e)
        {
            PostavBox.DataSource = supplier.Objs;
            PostavBox.DisplayMember = "Name";
            PostavBox.ValueMember = "Id";

            DataSklad.DataSource = sklads.Objs;
        }

        private void SkladForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataSklad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Adres.Text = DataSklad.Rows[e.RowIndex].Cells[1].Value.ToString();
            Vmest.Text = DataSklad.Rows[e.RowIndex].Cells[2].Value.ToString();
            PhoneTB1.Text = DataSklad.Rows[e.RowIndex].Cells[3].Value.ToString();
            PostavBox.Text = DataSklad.Rows[e.RowIndex].Cells[4].Value.ToString();
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

        private void PostavBtn_Click(object sender, EventArgs e)
        {
            PostavForm postavForm = new PostavForm();
            this.Hide();
            postavForm.Show();
        }

        private void FilialBtn_Click(object sender, EventArgs e)
        {
            FilialForm filialForm = new FilialForm();
            this.Hide();
            filialForm.Show();
        }
    }
}
