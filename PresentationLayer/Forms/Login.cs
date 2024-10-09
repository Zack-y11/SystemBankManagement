using BusinessLayer.Services;
using PresentationLayer.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        private ClientService _clientService;
        public Login()
        {
            InitializeComponent();
            _clientService = new ClientService();

        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            string admin = "admin";
            string password = "admin";
            if (nameTextBox.Text != admin && passwordTextBox.Text != password)
            {
                LoginClient(nameTextBox.Text, passwordTextBox.Text);
                MessageBox.Show("Welcome Client");
                this.Hide();
                ClientTransaction clientTransaction = new ClientTransaction();
                clientTransaction.ShowDialog();
            }
            else if (nameTextBox.Text == admin && passwordTextBox.Text == password)
            {
                MessageBox.Show("Welcome Admin");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect User or Password");
            }

        }
        private void LoginClient(string name, string password)
        {
            _clientService.LoginClient(name, password);
        }
    }
}
