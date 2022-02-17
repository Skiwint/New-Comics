using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Admin.Froms
{
    public partial class SaleForm : Form
    {
        AllModel<Sale> sales = new AllModel<Sale>("Sales");
        AllModel<Comics> comics = new AllModel<Comics>("Comics");
        AllModel<Client> clients = new AllModel<Client>("Clients");
        public int x;
        public SaleForm()
        {
            InitializeComponent();
        }
        RegistrationForms registrationForms = new RegistrationForms();
        private void BackForm_Click(object sender, EventArgs e)
        {
            if (RoleCheck.KassInt == 0)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                this.Hide();
                registrationForms.Show();
            }
        }

        private async void AddSale_Click(object sender, EventArgs e)
        {
            try
            {
                await new Sale
                {
                    ComicsId = ComicsBox.SelectedValue as int?,
                    ClientId = ClientBox.SelectedValue as int?,
                    Date = DataCheck.Value,
                }.Add();
                DataSale.DataSource = sales.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void SaleForm_Load(object sender, EventArgs e)
        {
            ComicsBox.DataSource = comics.Objs;
            ComicsBox.DisplayMember = "Name";
            ComicsBox.ValueMember = "Id";

            ClientBox.DataSource = clients.Objs;
            ClientBox.DisplayMember = "FIO";
            ClientBox.ValueMember = "Id";

            DataSale.DataSource = sales.Objs;
        }

        private async void DelSale_Click(object sender, EventArgs e)
        {
            await (DataSale.SelectedRows[0].DataBoundItem as Sale).Delete();
            DataSale.DataSource = sales.Objs;
        }

        private async void UpSale_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataSale.SelectedRows[0].DataBoundItem is Sale sale)
                {
                    sale.ComicsId = ComicsBox.SelectedValue as int?;
                    sale.ClientId = ClientBox.SelectedValue as int?;
                    sale.Date = DataCheck.Value;
                    await sale.Update();
                }
                DataSale.DataSource = sales.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComicsBox.Text = DataSale.Rows[e.RowIndex].Cells[1].Value.ToString();
            ClientBox.Text = DataSale.Rows[e.RowIndex].Cells[2].Value.ToString();
            DataCheck.Text = DataSale.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
