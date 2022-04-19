using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class LoginForm : Form
    {
        Customer customer = Customer.CustomerX();
        RegisterForm registerForm;
        ShoppingForm shoppingForm;

        // Default Constructor - Start
        public LoginForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // LoginForm Load - Start
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        // LoginForm Load - End

        // Minimize The App - Start
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "LoginForm - btnMinimize");
            this.WindowState = FormWindowState.Minimized;
        }
        // Minimize The App - End

        // Close The App - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "LoginForm - btnExit");
            this.Close();
        }
        // Close The App - End

        // Open RegisterForm - Start
        private void btnRegister_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "LoginForm - btnRegister");

            if (registerForm==null || registerForm.IsDisposed)
            {
                registerForm = new RegisterForm(this);
            }
            registerForm.Show();
            this.Hide();
        }
        // Open RegisterForm - End

        // Login Process - Start
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameX = txtUsername.Text.Trim();
            string passwordX = txtPassword.Text.Trim();

            ServerOperations.saveButtonClick(usernameX, "LoginForm - btnLogin");

            string res = customer.login(usernameX,passwordX);
            MessageBox.Show(res);

            if (res!= "Your Account Still Waiting For Confirmation." && res != "Wrong Username or Password." && res != "Please Fill The All Spaces.")
            {
                if (shoppingForm == null || shoppingForm.IsDisposed)
                {
                    shoppingForm = new ShoppingForm(this);
                }
                shoppingForm.Show();
                this.Hide();
            }
        }
        // Login Process - End
    }
}