using Microsoft.Extensions.Configuration;

namespace AutomobileWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _Email = txtEmail.Text;
            string _Password = txtPassword.Text;
            IConfiguration configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                       .Build();
            string adminEmail = configuration.GetSection("Login")["Email"];
            string adminPassword = configuration.GetSection("Login")["Password"];
            if (_Email == adminEmail && _Password == adminPassword)
            {
                frmCarManagement frmMemberManagement = new frmCarManagement();
                frmMemberManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fails");
            }


        }
    }
}
