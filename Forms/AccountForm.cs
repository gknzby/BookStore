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
    public partial class AccountForm : Form
    {
        Customer customer = Customer.CustomerX();
        Admin admin = Admin.AdminX();
        Book book = Book.BookX();
        Magazine magazine = Magazine.MagazineX();
        MusicCd musicCd = MusicCd.MusicCdX();
        ShoppingCart shoppingCart = ShoppingCart.ShoppingCartX();

        LoginForm loginForm;
        ShoppingForm shoppingForm;
        ShoppingCartForm shoppingCartForm;
        DetailsPopupForm detailsPopupForm;
        ConfirmForm confirmForm;

        List<Orders> myOrders;
        List<Customer> myInformations;
        List<Admin> allUsers;
        List<ProductItems> allProducts;
        List<Book> books;
        List<Magazine> magazines;
        List<MusicCd> musicCds;

        int selectedIndex = -1;

        // Default Constructor - Start
        public AccountForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Overloaded Constructor For Login Form Object - Start
        public AccountForm(LoginForm x)
        {
            InitializeComponent();
            loginForm = x;
        }
        // Overloaded Constructor For Login Form Object - End

        // AccountForm Load - Start
        private void AccountForm_Load(object sender, EventArgs e)
        {
            myInformations = customer.printCustomerDetails();
            pnlPersonalInfo.Visible = true;
            pnlChangePass.Visible = false;
            pnlAdmin.Visible = false;
            pnlOrders.Visible = false;

            if (myInformations[0].IsAdmin == 0)
            {
                btnAdminFeatures.Visible = false;
            }
            else
            {
                btnAdminFeatures.Visible = true;
            }

            txtUsername.Text = myInformations[0].Username;
            txtName.Text = myInformations[0].Name;
            txtEmail.Text = myInformations[0].Email;
            txtAdress.Text = myInformations[0].Adress;

            if(myInformations[0].EmailConfirmed==1)
            {
                btnConfirmEmail.Text = "Email Already Confirmed";
                btnConfirmEmail.Enabled = false;
            }
            else
            {
                btnConfirmEmail.Text = "Confirm Your Email";
                btnConfirmEmail.Enabled = true;
            }
        }
        // AccountForm Load - End

        // AccountForm Closing Event To Open Login Form - Start
        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((shoppingForm == null || shoppingForm.IsDisposed) && (shoppingCartForm == null || shoppingCartForm.IsDisposed))
            {
                loginForm.Show();
            }
            else if ((shoppingCartForm == null || shoppingCartForm.IsDisposed) && (shoppingForm != null || !shoppingForm.IsDisposed))
            {
                shoppingForm.Show();
            }
            else if ((shoppingForm == null || shoppingForm.IsDisposed) && (shoppingCartForm != null || !shoppingCartForm.IsDisposed))
            {
                shoppingCartForm.Show();
            }
        }
        // AccountForm Closing Event To Open Login Form - End

        // Minimize Form - Start
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnMinimize");
            this.WindowState = FormWindowState.Minimized;
        }
        // Minimize Form - End

        // Close Form - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnExit");
            this.Close();
        }
        // Close Form - End

        // Logout - Start
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnLogout");
            this.Close();
        }
        // Logout - End

        // Open Shopping Cart Screen - Start
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnShoppingCart");

            if (shoppingCartForm == null || shoppingCartForm.IsDisposed)
            {
                shoppingCartForm = new ShoppingCartForm(loginForm);
            }
            shoppingCartForm.Show();
            this.Close();
        }
        // Open Shopping Cart Screen - End

        // Open Shopping Screen (Main Screen) - Start
        private void btnBookStore_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnBookStore");

            if (shoppingForm == null || shoppingForm.IsDisposed)
            {
                shoppingForm = new ShoppingForm(loginForm);
            }
            shoppingForm.Show();
            this.Close();
        }
        // Open Shopping Screen (Main Screen) - End

        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnAccount");
            // We are in that page already. Maybe refresh?
        }
        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////

        // Set UI For 'Change Personal Information' - Start 
        private void changePersonalInfoUI()
        {
            pnlPersonalInfo.Visible = true;
            pnlChangePass.Visible = false;
            pnlAdmin.Visible = false;
            pnlOrders.Visible = false;

            txtUsername.Text = myInformations[0].Username;
            txtName.Text = myInformations[0].Name;
            txtEmail.Text = myInformations[0].Email;
            txtAdress.Text = myInformations[0].Adress;

            if (myInformations[0].EmailConfirmed == 1)
            {
                btnConfirmEmail.Text = "Email Already Confirmed";
                btnConfirmEmail.Enabled = false;
            }
            else
            {
                btnConfirmEmail.Text = "Confirm Your Email";
                btnConfirmEmail.Enabled = true;
            }
        }
        // Set UI For 'Change Personal Information' - End 

        // Set UI For 'Change Password' - Start 
        private void changePasswordUI()
        {
            pnlPersonalInfo.Visible = false;
            pnlChangePass.Visible = true;
            pnlAdmin.Visible = false;
            pnlOrders.Visible = false;

            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtNewPasswordAgain.Text = "";
        }
        // Set UI For 'Change Password' - End 

        // Set UI For 'Admin Features' - Start
        private void adminUI()
        {
            pnlPersonalInfo.Visible = false;
            pnlChangePass.Visible = false;
            pnlAdmin.Visible = true;
            pnlOrders.Visible = false;

            cmboxAdminOperationChoice.SelectedIndex = -1;
            selectedIndex = -1;
            lstAllListed.Clear();
            btnAddNewProduct.Visible = false;
            btnUpgradeToAdmin.Visible = false;
            btnConfirmRegistration.Visible = false;
            chckbxIsAdmin.Visible = false;
            chckbxIsAdmin.Checked = false;
            chckbxAccountConfirmed.Visible = false;
            chckbxAccountConfirmed.Checked = false;
        }
        // Set UI For 'Admin Features' - End 

        // Set UI For 'Your Orders' - Start 
        private void yourOrdersUI()
        {
            pnlPersonalInfo.Visible = false;
            pnlChangePass.Visible = false;
            pnlAdmin.Visible = false;
            pnlOrders.Visible = true;

            customer.syncOrders();
            myOrders = customer.listOrders();
            populateItems();
        }
        // Set UI For 'Your Orders' - End 

        // Set UI For 'Admin's User Operations Select' - Start 
        private void adminOperationsUserUI()
        {
            btnAddNewProduct.Visible = false;
            btnUpgradeToAdmin.Visible = true;
            btnConfirmRegistration.Visible = true;
            chckbxIsAdmin.Visible = true;
            chckbxIsAdmin.Checked = false;
            chckbxAccountConfirmed.Visible = true;
            chckbxAccountConfirmed.Checked = false;
            selectedIndex = 0;
            lstAllListed.Clear();

            lstAllListed.Columns.Add("CustomerID", 70);
            lstAllListed.Columns.Add("Username", 100);
            lstAllListed.Columns.Add("Name", 129);
            lstAllListed.Columns.Add("Email", 129);
            lstAllListed.Columns.Add("IsAdmin", 50);
            lstAllListed.Columns.Add("AccountConfirmed", 100);
        }
        // Set UI For 'Admin's User Operations Select' - End 

        // Set UI For 'Admin's Product Operations Select' - Start 
        private void adminOperationsProductUI()
        {
            btnAddNewProduct.Visible = true;
            btnUpgradeToAdmin.Visible = false;
            btnConfirmRegistration.Visible = false;
            chckbxIsAdmin.Visible = false;
            chckbxIsAdmin.Checked = false;
            chckbxAccountConfirmed.Visible = false;
            chckbxAccountConfirmed.Checked = false;
            selectedIndex = 1;
            lstAllListed.Clear();

            lstAllListed.Columns.Add("ID", 78);
            lstAllListed.Columns.Add("Name", 275);
            lstAllListed.Columns.Add("Price", 125);
            lstAllListed.Columns.Add("Product Type", 100);
        }
        // Set UI For 'Admin's Product Operations Select' - End 

        // Show Prev. Orders Of User - Start
        private void btnYourOrders_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnYourOrders");
            yourOrdersUI();
        }
        // Show Prev. Orders Of User - End

        // Change Personal Informations - Start
        private void btnChangePersonalInformations_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnChangePersonalInformations");
            changePersonalInfoUI();
        }
        // Change Personal Informations - End

        // Change Password - Start
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnChangePassword");
            changePasswordUI();
        }
        // Change Password - End

        // Show Admin Only Features - Start
        private void btnAdminFeatures_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnAdminFeatures");
            adminUI();
        }
        // Show Admin Only Features - End

        // User - Product Choice By Admin - Start
        private void cmboxAdminOperationChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxAdminOperationChoice.SelectedIndex == 0 && selectedIndex != 0)
            {
                // If User Choosed Different Index Clear List And Redesign It.
                adminOperationsUserUI();

                allUsers = admin.listAllUsers();

                for (int i = 0; i < allUsers.Count; i++)
                {
                    string[] row = { allUsers[i].CustomerID.ToString(),
                                    allUsers[i].Username,
                                    allUsers[i].Name,
                                    allUsers[i].Email,
                                    allUsers[i].IsAdmin.ToString(),
                                    allUsers[i].AccountConfirmed.ToString() };

                    ListViewItem listViewItem = new ListViewItem(row);
                    lstAllListed.Items.Add(listViewItem);
                }
            }
            else if (cmboxAdminOperationChoice.SelectedIndex == 0 && selectedIndex == 0)
            {
                // If User Choosed The Same Index Just Realign Columns.
                lstAllListed.Columns.Clear();

                lstAllListed.Columns.Add("CustomerID", 70);
                lstAllListed.Columns.Add("Username", 100);
                lstAllListed.Columns.Add("Name", 129);
                lstAllListed.Columns.Add("Email", 129);
                lstAllListed.Columns.Add("IsAdmin", 50);
                lstAllListed.Columns.Add("AccountConfirmed", 100);
            }
            else if (cmboxAdminOperationChoice.SelectedIndex == 1 && selectedIndex != 1)
            {
                // If User Choosed Different Index Clear List And Redesign It.
                adminOperationsProductUI();

                admin.syncProductType("Book");
                books = book.listAllBooks();
                admin.syncProductType("Magazine");
                magazines = magazine.listAllMagazines();
                admin.syncProductType("MusicCD");
                musicCds = musicCd.listAllMusicCds();

                allProducts = admin.listAllProducts();

                for (int i = 0; i < allProducts.Count; i++)
                {
                    string[] row = { allProducts[i].Id.ToString(),
                                    allProducts[i].Name,
                                    allProducts[i].Price.ToString("F", CultureInfo.InvariantCulture),
                                    allProducts[i].ProductType };

                    ListViewItem listViewItem = new ListViewItem(row);
                    lstAllListed.Items.Add(listViewItem);
                }
            }
            else if (cmboxAdminOperationChoice.SelectedIndex == 1 && selectedIndex == 1)
            {
                // If User Choosed The Same Index Just Realign Columns.
                lstAllListed.Columns.Clear();

                lstAllListed.Columns.Add("ID", 78);
                lstAllListed.Columns.Add("Name", 275);
                lstAllListed.Columns.Add("Price", 125);
                lstAllListed.Columns.Add("Product Type", 100);
            }
        }
        // User - Product Choice By Admin - End

        // Selected Row From Listview - Start
        private void lstAllListed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxAdminOperationChoice.SelectedIndex == 0)
            {
                if (lstAllListed.SelectedIndices.Count > 0)
                {
                    if (lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[4].Text == "0")
                    {
                        chckbxIsAdmin.Checked = false;
                    }
                    else if (lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[4].Text == "1")
                    {
                        chckbxIsAdmin.Checked = true;
                    }

                    if (lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[5].Text == "0")
                    {
                        chckbxAccountConfirmed.Checked = false;
                    }
                    else if (lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[5].Text == "1")
                    {
                        chckbxAccountConfirmed.Checked = true;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                // Not needed for now.
            }
        }
        // Selected Row From Listview - End

        // Double Clicked A Row To Open Details Screen - Start
        private void lstAllListed_DoubleClick(object sender, EventArgs e)
        {
            detailsPopupForm = new DetailsPopupForm(this);

            if (cmboxAdminOperationChoice.SelectedIndex == 0)
            {
                long idX = Int64.Parse(lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[0].Text);
                string[] res = selectedUser(idX);
                detailsPopupForm.userUI(res);
            }
            else if (cmboxAdminOperationChoice.SelectedIndex == 1)
            {
                long productID = Int64.Parse(lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[0].Text);
                string productType = lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[3].Text;
                string[] res = selectedProduct(productID, productType);
                detailsPopupForm.productUI(res, productType);
            }
            detailsPopupForm.Show();
        }
        // Double Clicked A Row To Open Details Screen - End

        // Selected User From Listview - Start
        private string[] selectedUser(long idX)
        {
            string[] res = new string[7];
            int index = -1;
            for (int i = 0; i < allUsers.Count; i++)
            {
                if (allUsers[i].CustomerID == idX)
                {
                    index = i;
                    break;
                }
            }

            if(index!=-1)
            {
                res[0] = allUsers[index].CustomerID.ToString();
                res[1] = allUsers[index].Username;
                res[2] = allUsers[index].Name;
                res[3] = allUsers[index].Email;
                res[4] = allUsers[index].Adress;
                res[5] = allUsers[index].IsAdmin.ToString();
                res[6] = allUsers[index].AccountConfirmed.ToString();
            }
            
            return res;
        }
        // Selected User From Listview - End

        // Selected Product From Listview - Start
        private string[] selectedProduct(long idX, string typeX)
        {
            string[] res = new string[8];

            if (typeX == "Book")
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].Id == idX)
                    {
                        res[0] = books[i].Id.ToString();
                        res[1] = books[i].Name;
                        res[2] = books[i].Price.ToString("F", CultureInfo.InvariantCulture);
                        res[3] = books[i].Isbn.ToString();
                        res[4] = books[i].Author;
                        res[5] = books[i].Publisher;
                        res[6] = books[i].PageNumber.ToString();
                        res[7] = books[i].CoverPagePicture;
                        break;
                    }
                }
            }
            else if (typeX == "Magazine")
            {
                for (int i = 0; i < magazines.Count; i++)
                {
                    if (magazines[i].Id == idX)
                    {
                        res[0] = magazines[i].Id.ToString();
                        res[1] = magazines[i].Name;
                        res[2] = magazines[i].Price.ToString("F", CultureInfo.InvariantCulture);
                        res[3] = magazines[i].Type;
                        res[4] = magazines[i].Issue.ToString("yyyy-MM-dd");
                        res[5] = magazines[i].CoverPagePicture;
                        break;
                    }
                }
            }
            else if (typeX == "MusicCD")
            {
                for (int i = 0; i < musicCds.Count; i++)
                {
                    if (musicCds[i].Id == idX)
                    {
                        res[0] = musicCds[i].Id.ToString();
                        res[1] = musicCds[i].Name;
                        res[2] = musicCds[i].Price.ToString("F", CultureInfo.InvariantCulture);
                        res[3] = musicCds[i].Type;
                        res[4] = musicCds[i].Singer;
                        res[5] = musicCds[i].CoverPagePicture;
                        break;
                    }
                }
            }
            return res;
        }
        // Selected Product From Listview - End

        // Open New Product Screen To Add Product - Start
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnAddNewProduct");

            detailsPopupForm = new DetailsPopupForm(this);
            detailsPopupForm.newProductUI();
            detailsPopupForm.Show();
        }
        // Open New Product Screen To Add Product - End

        // Change Personal Informations - Start
        private void btnUpdatePersonalInfo_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnUpdatePersonalInfo");

            myInformations[0].Username = txtUsername.Text.Trim();
            myInformations[0].Name = txtName.Text.Trim();
            myInformations[0].Email = txtEmail.Text.Trim();
            myInformations[0].Adress = txtAdress.Text.Trim();

            string res = customer.updateCustomer("PersonalInformationEdit", myInformations);
            MessageBox.Show(res);
            myInformations = customer.printCustomerDetails();

            txtUsername.Text = myInformations[0].Username;
            txtName.Text = myInformations[0].Name;
            txtEmail.Text = myInformations[0].Email;
            txtAdress.Text = myInformations[0].Adress;

            if (myInformations[0].EmailConfirmed == 1)
            {
                btnConfirmEmail.Text = "Email Already Confirmed";
                btnConfirmEmail.Enabled = false;
            }
            else
            {
                btnConfirmEmail.Text = "Confirm Your Email";
                btnConfirmEmail.Enabled = true;
            }
        }
        // Change Personal Informations - End

        // Change Password - Start
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnUpdatePassword");

            if (txtOldPassword.Text.Trim() == myInformations[0].Password)
            {
                if (txtNewPassword.Text.Trim() == txtNewPasswordAgain.Text.Trim())
                {
                    myInformations[0].Password = txtNewPassword.Text.Trim();

                    string res = customer.updateCustomer("PasswordEdit", myInformations);
                    MessageBox.Show(res);
                    myInformations = customer.printCustomerDetails();

                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtNewPasswordAgain.Text = "";
                }
                else
                {
                    MessageBox.Show("Your New Passwords Doesnt Match.Please Enter The Same Values To Both.");
                }
            }
            else
            {
                MessageBox.Show("The Password You Entered Doesnt Match With Your 'Old Password.'");
            }
        }
        // Change Password - End

        // Confirm Customer Registration - Start
        private void btnConfirmRegistration_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnConfirmRegistration");

            if (lstAllListed.SelectedIndices.Count > 0)
            {
                string selectedID = lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[0].Text;
                string accountConfirmedX = "0";
                if (chckbxAccountConfirmed.Checked)
                {
                    accountConfirmedX = "1";
                }

                string res = admin.addCustomer("AccountConfirmation", selectedID, accountConfirmedX);
                MessageBox.Show(res);

                if (res != "Please Fill The All Spaces." && res != "Wrong Update Type Choice." && res != "User Doesnt Exists." &&
                    res != "Failed To Update." && res != "Update Type Can't Be Null.")
                {
                    lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[5].Text = accountConfirmedX;
                }
            }
            else
            {
                return;
            }
            lstAllListed.SelectedIndices.Clear();
            chckbxIsAdmin.Checked = false;
            chckbxAccountConfirmed.Checked = false;
        }
        // Confirm Customer Registration - End

        // Change Admin Status Of User - Start
        private void btnUpgradeToAdmin_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnUpgradeToAdmin");

            if (lstAllListed.SelectedIndices.Count > 0)
            {
                string selectedID = lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[0].Text;
                string isAdminX = "0";
                if (chckbxIsAdmin.Checked)
                {
                    isAdminX = "1";
                }

                string res = admin.upgradeToAdmin("AdminStatusEdit", selectedID, isAdminX);
                MessageBox.Show(res);

                if (res != "Please Fill The All Spaces." && res != "Wrong Update Type Choice." && res != "User Doesnt Exists." &&
                     res != "Failed To Update." && res != "Update Type Can't Be Null.")
                {
                    lstAllListed.Items[lstAllListed.SelectedIndices[0]].SubItems[4].Text = isAdminX;
                }
            }
            else
            {
                return;
            }
            lstAllListed.SelectedIndices.Clear();
            chckbxIsAdmin.Checked = false;
            chckbxAccountConfirmed.Checked = false;
        }
        // Change Admin Status Of User - End

        // Add Item To Listview - Start
        public void addToListview(string[] x)
        {
            ListViewItem listViewItem = new ListViewItem(x);
            lstAllListed.Items.Add(listViewItem);
        }
        // Add Item To Listview - End

        // Remove Item From Listview - Start
        public void removeFromListview(string idX)
        {
            int index = -1;
            for (int i = 0; i < lstAllListed.Items.Count; i++)
            {
                if (lstAllListed.Items[i].SubItems[0].Text == idX)
                {
                    index = i;
                    break;
                }
            }
            if(index!=-1)
            {
                lstAllListed.Items.RemoveAt(index);
            }
        }
        // Remove Item From Listview - End

        // Update Item At Listview - Start
        public void updateAtListview(string[] x, string idX)
        {
            int index = -1;
            for (int i = 0; i < lstAllListed.Items.Count; i++)
            {
                if (lstAllListed.Items[i].SubItems[0].Text == idX)
                {
                    index = i;
                    break;
                }
            }
            if(index!=-1)
            {
                ListViewItem listViewItem = new ListViewItem(x);
                lstAllListed.Items[index] = listViewItem;
            } 
        }
        // Update Item At Listview - End

        // Open Confirm Email Form - Start
        private void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "AccountForm - btnConfirmEmail");

            if (confirmForm == null || confirmForm.IsDisposed)
            {
                confirmForm = new ConfirmForm(this);
            }
            confirmForm.Show();
        }
        // Open Confirm Email Form - End

        // Sync List After Confirmation - Start
        public void syncEmailConfirmation()
        {
            myInformations = customer.printCustomerDetails();

            txtUsername.Text = myInformations[0].Username;
            txtName.Text = myInformations[0].Name;
            txtEmail.Text = myInformations[0].Email;
            txtAdress.Text = myInformations[0].Adress;

            if (myInformations[0].EmailConfirmed == 1)
            {
                btnConfirmEmail.Text = "Email Already Confirmed";
                btnConfirmEmail.Enabled = false;
            }
            else
            {
                btnConfirmEmail.Text = "Confirm Your Email";
                btnConfirmEmail.Enabled = true;
            }
        }
        // Sync List After Confirmation - End

        // Orders List - Start
        public void populateItems()
        {
            flwLytPnlYourOrders.Controls.Clear();

            int orderCount = 0;
            if(myOrders.Count!=0)
            {
                orderCount = 1;

                for(int i=1;i<myOrders.Count;i++)
                {
                    if (myOrders[i].OrderDate != myOrders[i - 1].OrderDate)
                    {
                        orderCount++;
                    }
                }

                OrdersListItem[] orderListItem = new OrdersListItem[orderCount];

                int index = 0;
                int newOrder = 1;
                for (int i = 0; i < orderListItem.Length; i++)
                {
                    DateTime orderDateX = DateTime.MinValue;
                    int totalQuantityX = 0;
                    double totalPriceX = 0;

                    for (int j = index; j < myOrders.Count; j++)
                    {
                        if (j > 0)
                        {
                            if (myOrders[j].OrderDate != myOrders[j - 1].OrderDate)
                            {
                                if (newOrder == 0)
                                {
                                    index = j;
                                    newOrder = 1;
                                    break;
                                }
                                else
                                {
                                    orderDateX = myOrders[j].OrderDate;
                                    totalQuantityX += myOrders[j].Quantity;
                                    totalPriceX += myOrders[j].ProductPrice * myOrders[j].Quantity;
                                    newOrder = 0;
                                }
                            }
                            else
                            {
                                orderDateX = myOrders[j].OrderDate;
                                totalQuantityX += myOrders[j].Quantity;
                                totalPriceX += myOrders[j].ProductPrice * myOrders[j].Quantity;
                            }
                        }
                        else
                        {
                            orderDateX = myOrders[j].OrderDate;
                            totalQuantityX += myOrders[j].Quantity;
                            totalPriceX += myOrders[j].ProductPrice * myOrders[j].Quantity;
                            newOrder = 0;
                        }
                    }

                    orderListItem[i] = new OrdersListItem();
                    orderListItem[i].OrderDate = orderDateX;
                    orderListItem[i].TotalQuantity = totalQuantityX;
                    orderListItem[i].TotalPrice = totalPriceX;

                    flwLytPnlYourOrders.Controls.Add(orderListItem[i]);
                }

            }
            else
            {
                MessageBox.Show("You Haven't Ordered Anything Yet.");
            }
        }
        // Orders List - End
    }
}