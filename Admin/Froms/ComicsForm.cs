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
    public partial class ComicsForm : Form
    {
        AllModel<Sklad> sklads = new AllModel<Sklad>("Sklads");
        AllModel<Comics> comics = new AllModel<Comics>("Comics");
        public string[] Bind = {
            "да",
            "нет"
        };
        public ComicsForm()
        {
            InitializeComponent();
        }

        private void BeckForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private async void AddComics_Click(object sender, EventArgs e)
        {
            try
            {
                await new Comics
                {
                    Id = 0,
                    Name = ComName.Text,
                    Author = Author.Text,
                    DateShops = DateCom.Value,
                    Binding = Binding.SelectedIndex.ToString(),
                    Pages = Convert.ToInt32(CountPage.Text),
                    Price = Convert.ToInt32(Price.Text),
                    SkladId = SkladBox.SelectedValue as int?,
                }.Add();
                ComName.Text = "";
                Author.Text = "";
                DateCom.Value = DateTime.Now;
                Binding.SelectedIndex = 0;
                CountPage.Text = "";
                Price.Text = "";
                DataComics.DataSource = comics.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComicsForm_Load(object sender, EventArgs e)
        {
            GetRateForFiltr();
            SkladBox.DataSource = sklads.Objs;
            SkladBox.DisplayMember = "Adress";
            SkladBox.ValueMember = "Id";

            DataComics.DataSource = comics.Objs;
        }

        private async void DelComics_Click(object sender, EventArgs e)
        {
            await (DataComics.SelectedRows[0].DataBoundItem as Comics).Delete();
            DataComics.DataSource = comics.Objs;
        }

        private async void UpComics_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataComics.SelectedRows[0].DataBoundItem is Comics comic)
                {
                    comic.Name = ComName.Text;
                    comic.Author = Author.Text;
                    comic.DateShops = DateCom.Value;
                    comic.Binding = Binding.SelectedIndex.ToString();
                    comic.Pages = Convert.ToInt32(CountPage.Text);
                    comic.Price = Convert.ToInt32(Price.Text);
                    comic.SkladId = SkladBox.SelectedValue as int?;
                    await comic.Update();
                }
                ComName.Text = "";
                Author.Text = "";
                DateCom.Value = DateTime.Now;
                Binding.SelectedIndex = 0;
                CountPage.Text = "";
                Price.Text = "";
                DataComics.DataSource = comics.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetRateForFiltr()
        {
            Binding.Items.Add(Bind[0]);
            Binding.Items.Add(Bind[1]);
            Binding.SelectedIndex = 0;
        }

        private void ComicsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void DataComics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComName.Text = DataComics.Rows[e.RowIndex].Cells[1].Value.ToString();
            Author.Text = DataComics.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateCom.Text = DataComics.Rows[e.RowIndex].Cells[3].Value.ToString();
            Binding.Text = DataComics.Rows[e.RowIndex].Cells[4].Value.ToString();
            CountPage.Text = DataComics.Rows[e.RowIndex].Cells[5].Value.ToString();
            Price.Text = DataComics.Rows[e.RowIndex].Cells[6].Value.ToString();
            SkladBox.Text = DataComics.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }

        private void CountPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
               (!string.IsNullOrEmpty(CountPage.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
               (!string.IsNullOrEmpty(Price.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }
    }
}
