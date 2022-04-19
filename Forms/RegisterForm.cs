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
    public partial class RegisterForm : Form
    {
        Customer customer = Customer.CustomerX();
        LoginForm loginForm;

        // Default Constructor - Start
        public RegisterForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Overloaded Constructor For Login Form Object - Start
        public RegisterForm(LoginForm x)
        {
            InitializeComponent();
            loginForm = x;
        }
        // Overloaded Constructor For Login Form Object - End

        // RegisterForm Load - Start
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        // RegisterForm Load - End

        // RegisterForm Closing Event To Open Login Form - Start
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
        // RegisterForm Closing Event To Open Login Form - End

        // Minimize The App - Start
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "RegisterForm - btnMinimize");
            this.WindowState = FormWindowState.Minimized;
        }
        // Minimize The App - End

        // Close The App - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "RegisterForm - btnExit");
            this.Close();
        }
        // Close The App - End

        // Open LoginForm - Start
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick("-", "RegisterForm - buttonLogin");
            loginForm.Show();
            this.Close();
        }
        // Open LoginForm - End

        // Registeration Process - Start
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usernameX = txtUsername.Text.Trim();
            string nameX = txtName.Text.Trim();
            string emailX = txtEmail.Text.Trim();
            string adressX = txtAdress.Text.Trim();
            string passwordX = txtPassword.Text.Trim();

            ServerOperations.saveButtonClick(usernameX, "RegisterForm - btnRegister");

            string res = customer.saveCustomer(usernameX, nameX, emailX, adressX, passwordX);
            MessageBox.Show(res);
            this.Close();
        }
        // Registeration Process - End
    }
}