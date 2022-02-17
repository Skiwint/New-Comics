
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
    public partial class FilForSkladForm : Form
    {
        AllModel<BranchForSklad> BsS = new AllModel<BranchForSklad>("BranchForSklads");
        AllModel<Branch> branches = new AllModel<Branch>("Branches");
        AllModel<Sklad> sklads = new AllModel<Sklad>("Sklads");
        
        public FilForSkladForm()
        {
            InitializeComponent();
            if (RoleCheck.skladInt != 1)
            {
                Filialbtn.Visible = false;
                SkladBtn.Visible = false;
                PostavBtn.Visible = false;
            }
            else
            {
                Filialbtn.Visible = true;
                SkladBtn.Visible = true;
                PostavBtn.Visible = true;
            }
        }
        SkladForm skladForm = new SkladForm();
        private void BackForm_Click(object sender, EventArgs e)
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
        
        private void FilForSkladForm_Load(object sender, EventArgs e)
        {
            SkladBox.DataSource = sklads.Objs;
            FilialBox.DataSource = branches.Objs;

            SkladBox.DisplayMember = "Adress";
            FilialBox.DisplayMember = "Adress";

            SkladBox.ValueMember = "Id";
            FilialBox.ValueMember = "Id";

            DataSfF.DataSource = BsS.Objs;
        }

        private async void DelSfF_Click(object sender, EventArgs e)
        {
            await (DataSfF.SelectedRows[0].DataBoundItem as BranchForSklad).Delete();
            DataSfF.DataSource = BsS.Objs;
        }

        private async void AddSfF_Click(object sender, EventArgs e)
        {
            try
            {
                await new BranchForSklad
                {
                    Id = 0,
                    SkladId = SkladBox.SelectedValue as int?,
                    BranchId = FilialBox.SelectedValue as int?,
                }.Add();
                DataSfF.DataSource = BsS.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private async void UpSfF_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataSfF.SelectedRows[0].DataBoundItem is BranchForSklad branchForSklad)
                {

                    branchForSklad.SkladId = SkladBox.SelectedValue as int?;
                    branchForSklad.BranchId = FilialBox.SelectedValue as int?;
                    await branchForSklad.Update();
                }
                DataSfF.DataSource = BsS.Objs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilForSkladForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DataSfF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SkladBox.Text = DataSfF.Rows[e.RowIndex].Cells[1].Value.ToString();
            FilialBox.Text = DataSfF.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Filialbtn_Click(object sender, EventArgs e)
        {
            FilialForm filialForm = new FilialForm();
            this.Hide();
            filialForm.Show();
        }

        private void PostavBtn_Click(object sender, EventArgs e)
        {
            PostavForm postavForm = new PostavForm();
            this.Hide();
            postavForm.Show();
        }

        private void SkladBtn_Click(object sender, EventArgs e)
        {
            SkladForm skladForm = new SkladForm();
            this.Hide();
            skladForm.Show();
        }
    }
}
