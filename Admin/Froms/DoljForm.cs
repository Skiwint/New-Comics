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
    public partial class DoljForm : Form
    {
        AllModel<Post> posts = new AllModel<Post>("Posts");
        public DoljForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private async void AddDol_Click(object sender, EventArgs e)
        {
            try
            {
                await new Post
                {
                    Id = 0,
                    Name = NamePost.Text,
                    Oklad = PostOklad.Text,
                    Graph = Grarph.Text,
                }.Add();
                DataDol.DataSource = posts.Objs;
                NamePost.Text = "";
                PostOklad.Text = "";
                Grarph.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelDol_Click(object sender, EventArgs e)
        {
            await(DataDol.SelectedRows[0].DataBoundItem as Post).Delete();
            DataDol.DataSource = posts.Objs;
        }

        private async void UpDol_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataDol.SelectedRows[0].DataBoundItem is Post post)
                {
                    post.Name = NamePost.Text;
                    post.Oklad = PostOklad.Text;
                    post.Graph = Grarph.Text;
                    await post.Update();
                }
                NamePost.Text = "";
                PostOklad.Text = "";
                Grarph.Text = "";
                DataDol.DataSource = posts.Objs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoljForm_Load(object sender, EventArgs e)
        {
            DataDol.DataSource = posts.Objs;
        }

        private void DoljForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataDol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NamePost.Text = DataDol.Rows[e.RowIndex].Cells[1].Value.ToString();
            PostOklad.Text = DataDol.Rows[e.RowIndex].Cells[2].Value.ToString();
            Grarph.Text = DataDol.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
