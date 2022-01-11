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
    public partial class ClientForm : Form
    {
        AllModel<Client> clients = new AllModel<Client>("Clients");
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            DataClient.DataSource = clients.Objs;
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private async void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                await new Client
                {
                    Id = 0,
                    Fio = FIO.Text,
                    Phone = NumberPhone.Text,
                }.Add();
                FIO.Text = "";
                NumberPhone.Text = "";
                DataClient.DataSource = clients.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelUser_Click(object sender, EventArgs e)
        {
            await(DataClient.SelectedRows[0].DataBoundItem as Client).Delete();
            DataClient.DataSource = clients.Objs;
        }

        private async void UpUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataClient.SelectedRows[0].DataBoundItem is Client client)
                {
                    client.Fio = FIO.Text;
                    client.Phone = NumberPhone.Text;
                    await client.Update();
                }
                FIO.Text = "";
                NumberPhone.Text = "";
                DataClient.DataSource = clients.Objs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FIO.Text = DataClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            NumberPhone.Text = DataClient.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void NumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
               (!string.IsNullOrEmpty(NumberPhone.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
