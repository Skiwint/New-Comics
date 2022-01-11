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
    public partial class ViewStuff : Form
    {
        int RowIndex;
        
        ForClient Comics = new ForClient();
        public ViewStuff(ForClient comics)
        {
            InitializeComponent();
            Comics = comics;
            this.RowIndex = Comics.DataStuff.CurrentRow.Index;
        }

        private void ViewStuff_Load(object sender, EventArgs e)
        {
            if (Comics.DataStuff != null)
            {
                ComicsName.Text = Comics.DataStuff.Rows[RowIndex].Cells[1].Value.ToString();
                Author.Text = Comics.DataStuff.Rows[RowIndex].Cells[2].Value.ToString();
                DatePost.Text = Comics.DataStuff.Rows[RowIndex].Cells[3].Value.ToString();
                Bind.Text = Comics.DataStuff.Rows[RowIndex].Cells[4].Value.ToString();
                PageCount.Text = Comics.DataStuff.Rows[RowIndex].Cells[5].Value.ToString();
                Price.Text = Comics.DataStuff.Rows[RowIndex].Cells[6].Value.ToString();
                Sklad.Text = Comics.DataStuff.Rows[RowIndex].Cells[7].Value.ToString();
            }
        }
       
        private void BackForm_Click(object sender, EventArgs e)
        {
            ForClient forClient = new ForClient();
            this.Hide();
            forClient.Show();
        }

        private void ViewStuff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
