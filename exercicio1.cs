namespace Windows_Forms_Basics
{
    public partial class exercicio1 : Form
    {
        public exercicio1()
        {
            InitializeComponent();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            String email;
            String password;

            email = txtEmail.Text;
            password = txtPassword.Text;

            if (String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is empty");
            }
            else
            {
                if (String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is empty");
                }
                else
                {
                    MessageBox.Show("Email and Password are computed correctly!");
                }
            }
        }
    }
}