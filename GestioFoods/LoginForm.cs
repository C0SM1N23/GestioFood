

namespace Desktop_App_.NET_8._0
{
    public partial class LoginForm : Form
    {
        readonly SqlDatabase sqlDB = new SqlDatabase();
        Person loggedUser;
        public LoginForm()
        {
            InitializeComponent();

        }
        bool check = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            switch (sqlDB.ValidateLogin(email, password))
            {
                case 1:
                    this.Hide();
                    MainForm mainform = new MainForm();
                    mainform.Show();
                    break;
                case 0:
                    MessageBox.Show("Invalid credentials!");
                    break;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbEmail.Text = "alexjones@gamingbros.com";
            tbPassword.Text = "alexjones123";
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            tbEmail.Text = "alexjones@gamingbros.com";
            tbPassword.Text = "alexjones123";
        }

        private void iconPictureBox3_Click_1(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '•')
            {
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                tbPassword.PasswordChar = '•';
            }
        }
    }
}
