using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.Froms
{
    public partial class RegistrationForms : Form
    {
        AllModel<User> users = new AllModel<User>("Users");

        SkladForm skladForm = new SkladForm();
        FilialForm filialForm = new FilialForm();
        FilForSkladForm fil = new FilForSkladForm();
        PostavForm postavForm = new PostavForm();
        public RegistrationForms()
        {
           
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        private async void SingIn_Click(object sender, EventArgs e)
        {
            var Pass = GetHash(PasswordTB.Text);
            if (users.Objs.Any(user => user.Login == LoginTB.Text && user.Password == Pass))
            {
                var user = users.Objs.FirstOrDefault(user => user.Login == LoginTB.Text && user.Password == Pass);
                switch((await new Role { Id = (int)user.RoleId }.Get()).RoleName)
                {
                    case"Администратор":
                        Menu menu = new Menu();
                        this.Hide();
                        menu.Show();
                        break;


                    case "Бухгалтер":
                        SearchForm searchForm = new SearchForm();
                        this.Hide();
                        searchForm.Show();
                        searchForm.x = 1;
                        break;


                    case "Кладовщик":
                        this.Hide();
                        skladForm.Show();
                        skladForm.x = 1;
                        break;


                    case "Кассир":
                        SaleForm saleForm = new SaleForm();
                        this.Hide();
                        saleForm.Show();
                        saleForm.x = 1;
                        break;


                    case "Клиент":
                        ForClient forClient = new ForClient();
                        this.Hide();
                        forClient.Show();
                        break;

                    default:
                        
                        return;
                }
            }
        }

        private void RegistrationForms_Load(object sender, EventArgs e)
        {

        }
    }
}
