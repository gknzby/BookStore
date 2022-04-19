using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ShoppingCartForm : Form
    {
        ShoppingCart shoppingCart = ShoppingCart.ShoppingCartX();
        Customer customer = Customer.CustomerX();

        LoginForm loginForm;
        ShoppingForm shoppingForm;
        AccountForm accountForm;
        ConfirmForm confirmForm;

        List<ItemToPurchase> itemsInShoppingCart;

        ShoppingListItem[] shoppingListItem;

        string creditCardNo = "";

        // Default Constructor - Start
        public ShoppingCartForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Overloaded Constructor For LoginForm Form Object - Start
        public ShoppingCartForm(LoginForm x)
        {
            InitializeComponent();
            loginForm = x;
        }
        // Overloaded Constructor For LoginForm Form Object - Start

        // ShoppingCartForm Load - Start
        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            populateItems();
        }
        // ShoppingCartForm Load - End

        // ShoppingCartForm Closing Event To Open Other Forms - Start
        private void ShoppingCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((shoppingForm == null || shoppingForm.IsDisposed) && (accountForm == null || accountForm.IsDisposed))
            {
                loginForm.Show();
            }
            else if ((accountForm == null || accountForm.IsDisposed) && (shoppingForm != null || !shoppingForm.IsDisposed))
            {
                shoppingForm.Show();
            }
            else if ((shoppingForm == null || shoppingForm.IsDisposed) && (accountForm != null || !accountForm.IsDisposed))
            {
                accountForm.Show();
            }
        }
        // ShoppingCartForm Closing Event To Open Other Forms - End

        // Minimize Form - Start
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnMinimize");
            this.WindowState = FormWindowState.Minimized;
        }
        // Minimize Form - End

        // Close Form - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnExit");
            this.Close();
        }
        // Close Form - End

        // Open Shopping Screen (Main Screen) - Start
        private void btnBookStore_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnBookStore");

            if (shoppingForm == null || shoppingForm.IsDisposed)
            {
                shoppingForm = new ShoppingForm(loginForm);
            }
            shoppingForm.Show();
            this.Close();
        }
        // Open Shopping Screen (Main Screen) - End

        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnShoppingCart");
            // We are in that page already. Maybe refresh?
        }
        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////

        // Open Account Screen - Start
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnAccount");

            if (accountForm == null || accountForm.IsDisposed)
            {
                accountForm = new AccountForm(loginForm);
            }
            accountForm.Show();
            this.Close();
        }
        // Open Account Screen - End

        // Shopping Cart List - Start
        public void populateItems()
        {
            flwLytPnlShoppingCart.Controls.Clear();
            shoppingCart.syncCart();
            itemsInShoppingCart = shoppingCart.printProducts();
            shoppingListItem = new ShoppingListItem[itemsInShoppingCart.Count];

            int itemCount = 0;
            double totalPrice = 0;

            for (int i = 0; i < shoppingListItem.Length; i++)
            {
                shoppingListItem[i] = new ShoppingListItem(this);
                shoppingListItem[i].ProductID = itemsInShoppingCart[i].Product.Id;
                shoppingListItem[i].ProductName = itemsInShoppingCart[i].Product.Name;
                shoppingListItem[i].ProductType = itemsInShoppingCart[i].Product.ProductType;
                shoppingListItem[i].ProductPrice = itemsInShoppingCart[i].Product.Price.ToString("F", CultureInfo.InvariantCulture);
                shoppingListItem[i].Quantity = itemsInShoppingCart[i].Quantity;

                string imageAdress = itemsInShoppingCart[i].Product.CoverPagePicture;
                if (imageAdress != "")
                {
                    Image coverPagePicture = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
                    shoppingListItem[i].CoverPagePicture = coverPagePicture;
                }

                flwLytPnlShoppingCart.Controls.Add(shoppingListItem[i]);
                itemCount += itemsInShoppingCart[i].Quantity;
                totalPrice += (itemsInShoppingCart[i].Product.Price) * (itemsInShoppingCart[i].Quantity);
            }

            lblItemCount.Text = "Item Count :" + itemCount.ToString();
            lblTotalPrice.Text = "Total Price : " + totalPrice.ToString("F", CultureInfo.InvariantCulture) + " TL";
        }
        // Shopping Cart List - End

        // Clear The Shopping Cart Items - Start
        private void btnClearShoppingCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnClearShoppingCart");

            shoppingCart.cancelOrder();
            populateItems();
        }
        // Clear The Shopping Cart Items - End

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnPlaceOrder");

            if (creditCardNo!="")
            {
                string res = shoppingCart.placeOrder(creditCardNo);

                if (res == "Payment succesfull! Thank you for shopping us.")
                {
                    int errorCheck = -1;
                    DateTime orderDateX = DateTime.UtcNow;

                    for (int i = 0; i < itemsInShoppingCart.Count; i++)
                    {
                        long productIDX = itemsInShoppingCart[i].Product.Id;
                        string productTypeX = itemsInShoppingCart[i].Product.ProductType;
                        string productNameX = itemsInShoppingCart[i].Product.Name;
                        double productPriceX = itemsInShoppingCart[i].Product.Price;
                        int quantityX = itemsInShoppingCart[i].Quantity;

                        res = shoppingCart.saveOrderToDatabase(productIDX, productTypeX, productNameX, productPriceX, quantityX, orderDateX);

                        if (res != "Your Order Has Been Placed Successfully.Thank You For Shopping With Us.")
                        {
                            errorCheck = 1;
                            MessageBox.Show(res);
                            break;
                        }
                    }

                    if (errorCheck == -1)
                    {
                        shoppingCart.completeOrder();

                        shoppingCart.cancelOrder(); // Clear Shopping Cart List After Successful Order Placement.
                        populateItems();

                        MessageBox.Show(res);

                        if (shoppingForm == null || shoppingForm.IsDisposed)
                        {
                            shoppingForm = new ShoppingForm(loginForm);
                        }
                        shoppingForm.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(res);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Payment Method.");
            }
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingCartForm - btnPaymentMethod");

            if (confirmForm == null || confirmForm.IsDisposed)
            {
                confirmForm = new ConfirmForm(this);
            }
            confirmForm.Show();
        }

        public void setCreditCardNo(string x)
        {
            creditCardNo = x;
        }  
    }
}