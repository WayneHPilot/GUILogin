using System.ComponentModel;

namespace LoginScript1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="admin" && txtPassword.Text == "password")
            {
                MessageBox.Show("Successfully logged in!");
                new Form2().Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("The Username or password you entered is incorrect, please try again");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Text = null;
            txtPassword.Text = null;
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}