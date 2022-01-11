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
    public partial class ForClient : Form
    {
        AllModel<Comics> comics = new AllModel<Comics>("Comics");
        public ForClient()
        {
            InitializeComponent();
        }

        private void LinkView_Click(object sender, EventArgs e)
        {
            if (DataStuff.SelectedRows.Count > 0)
            {
                ViewStuff viewStuff = new ViewStuff(this);
                this.Hide();
                viewStuff.Show();
            }
        }

        private void ForClient_Load(object sender, EventArgs e)
        {
            DataStuff.DataSource = comics.Objs;
            DataStuff.Columns[3].Visible = false;
            DataStuff.Columns[4].Visible = false;
            DataStuff.Columns[5].Visible = false;
            DataStuff.Columns[6].Visible = false;
        }

        private void ForClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            RegistrationForms registrationForms = new RegistrationForms();
            this.Hide();
            registrationForms.Show();
        }
    }
}
