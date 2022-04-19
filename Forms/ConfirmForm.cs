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
    public partial class ConfirmForm : Form
    {
        Customer customer = Customer.CustomerX();
        ConfirmMail confirmMail;
        CheckCard checkCard;

        AccountForm accountForm;
        ShoppingCartForm shoppingCartForm;

        List<Customer> myInformations;

        public ConfirmForm()
        {
            InitializeComponent();
        }

        public ConfirmForm(AccountForm x)
        {
            InitializeComponent();
            accountForm = x;
            mailUI();

            confirmMail = new ConfirmMail();
            confirmMail.setMail();
            confirmMail.sendMail();
        }

        public ConfirmForm(ShoppingCartForm x)
        {
            InitializeComponent();
            shoppingCartForm = x;
            creditCardUI();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ConfirmForm - btnExit");
            this.Close();
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            myInformations = customer.printCustomerDetails();
        }

        private void mailUI()
        {
            pnlConfirmMail.Visible = true;
            pnlConfirmCreditCard.Visible = false;
            lblHeader.Text = "Confirm Email";
            lblHeader.Left = 160;
        }

        private void creditCardUI()
        {
            pnlConfirmMail.Visible = false;
            pnlConfirmCreditCard.Visible = true;
            lblHeader.Text = "Confirm Credit Card";
            lblHeader.Left = 122;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ConfirmForm - btnConfirm");

            if (txtConfirmationCode.Text.Trim()==confirmMail.ConfirmationCode.ToString())
            {
                string res = customer.updateCustomer("EmailConfirmation", myInformations);
                if (res != "Wrong Update Type Choice." && res != "User Doesnt Exists." && res != "Failed To Update." && res != "Please Fill The All Spaces.")
                {
                    MessageBox.Show("You Have Successfully Confirmed Your Email Address.");
                    accountForm.syncEmailConfirmation();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong.Sending A new Confirmation Code.");
                    confirmMail.setMail();
                    confirmMail.sendMail();
                    txtConfirmationCode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Wrong Confirmation Code.Sending A New Confirmation Code.");
                confirmMail.setMail();
                confirmMail.sendMail();
                txtConfirmationCode.Text = "";
            }
        }

        private void btnConfirmCreditCard_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ConfirmForm - btnConfirmCreditCard");

            if (checkCard == null)
            {
                checkCard = new CheckCard();
            }

            if (checkCard.PaymentOk(txtCreditCardNo.Text.Trim()))
            {
                shoppingCartForm.setCreditCardNo(txtCreditCardNo.Text.Trim());
                MessageBox.Show("Your Credit Card Informations Are Correct.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Your Credit Card Informations Are Wrong.");
            }
        }
    }
}