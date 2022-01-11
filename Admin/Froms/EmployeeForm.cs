using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Froms
{
    public partial class Сотрудники : Form
    {
        AllModel<Employee> employes = new AllModel<Employee>("Employees");
        AllModel<Branch> branches = new AllModel<Branch>("Branches");
        AllModel<Post> posts = new AllModel<Post>("Posts");
        AllModel<User> users = new AllModel<User>("Users");
        public string[] GenAr = 
        { 
            "муж", 
            "жен" 
        };
        public Сотрудники()
        {
            
            InitializeComponent();
            GetRateForFiltr();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            UserBox.DataSource = users.Objs;
            UserBox.DisplayMember = "Login";
            UserBox.ValueMember = "Id";

            FilialBox.DataSource = branches.Objs;
            FilialBox.DisplayMember = "Name";
            FilialBox.ValueMember = "Id";

            PostBox.DataSource = posts.Objs;
            PostBox.DisplayMember = "Name";
            PostBox.ValueMember = "Id";


            DataEmp.DataSource = employes.Objs;        
        }

        private void BeckForm_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
       
        private async void AddEmp_Click(object sender, EventArgs e)
        {
       
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            try
            {
                if(!Regex.IsMatch(EmailTB.Text, pattern, RegexOptions.IgnoreCase) )
                {
                    MessageBox.Show("Неправильное заполнение данных, попробуйте ещё раз");
                    Familia.Text = "";
                    NameEm.Text = "";
                    SerName.Text = "";
                    PhoneTB1.Text = "";
                    EmailTB.Text = "";
                    INN.Text = "";
                    SNILS.Text = "";
                    return;
                }


                await new Employee
                {
                    Id = 0,
                    Familiya = Familia.Text,
                    Imiya = NameEm.Text,
                    Otchestvo = SerName.Text,
                    Phone = PhoneTB1.Text,
                    Email = EmailTB.Text,
                    Inn = Convert.ToInt64(INN.Text),
                    Snils = Convert.ToInt64(SNILS.Text),
                    Gender = GenderCB.SelectedItem.ToString(),
                    PostId = PostBox.SelectedValue as int?,
                    BranchId = FilialBox.SelectedValue as int?,
                    UserId = UserBox.SelectedValue as int?,
                }.Add();
                Familia.Text = "";
                NameEm.Text = "";
                PhoneTB1.Text = "";
                EmailTB.Text = "";
                INN.Text = "";
                SNILS.Text = "";
                DataEmp.DataSource = employes.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void DelEmp_Click(object sender, EventArgs e)
        {
            await (DataEmp.SelectedRows[0].DataBoundItem as Employee).Delete();
            DataEmp.DataSource = employes.Objs;
        }

        private async void UpEmp_Click(object sender, EventArgs e)
        {
            if(DataEmp.SelectedRows[0].DataBoundItem is Employee employee)
            {
                employee.Familiya = Familia.Text;
                employee.Imiya = NameEm.Text;
                employee.Otchestvo = SerName.Text;
                employee.Phone = PhoneTB1.Text;
                employee.Email = EmailTB.Text;
                employee.Inn = Convert.ToInt32(INN.Text);
                employee.Snils = Convert.ToInt32(SNILS.Text);
                employee.Gender = GenderCB.SelectedItem.ToString();
                employee.PostId = PostBox.SelectedValue as int?;
                employee.BranchId = FilialBox.SelectedValue as int?;
                employee.UserId = UserBox.SelectedValue as int?;
                await employee.Update();
            }
            Familia.Text = "";
            NameEm.Text = "";
            PhoneTB1.Text = "";
            EmailTB.Text = "";
            INN.Text = "";
            SNILS.Text = "";
            DataEmp.DataSource = employes.Objs;
        }

        private void GetRateForFiltr()
        {
            GenderCB.Items.Add(GenAr[0]);
            GenderCB.Items.Add(GenAr[1]);
            GenderCB.SelectedIndex = 1;
        }

        private void DataEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Familia.Text = DataEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
            NameEm.Text = DataEmp.Rows[e.RowIndex].Cells[2].Value.ToString();
            SerName.Text = DataEmp.Rows[e.RowIndex].Cells[3].Value.ToString();
            PhoneTB1.Text = DataEmp.Rows[e.RowIndex].Cells[4].Value.ToString();
            EmailTB.Text = DataEmp.Rows[e.RowIndex].Cells[5].Value.ToString();
            INN.Text = DataEmp.Rows[e.RowIndex].Cells[6].Value.ToString();
            SNILS.Text = DataEmp.Rows[e.RowIndex].Cells[7].Value.ToString();
            GenderCB.Text = DataEmp.Rows[e.RowIndex].Cells[8].Value.ToString();
            PostBox.Text = DataEmp.Rows[e.RowIndex].Cells[9].Value.ToString();
            FilialBox.Text = DataEmp.Rows[e.RowIndex].Cells[10].Value.ToString();
            UserBox.Text = DataEmp.Rows[e.RowIndex].Cells[11].Value.ToString();
        }

        private void INN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
                 (!string.IsNullOrEmpty(INN.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void SNILS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
                 (!string.IsNullOrEmpty(SNILS.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
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
    }
}
