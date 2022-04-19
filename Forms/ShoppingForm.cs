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
    public partial class ShoppingForm : Form
    {
        Customer customer = Customer.CustomerX();
        Admin admin = Admin.AdminX();
        Book book = Book.BookX();
        Magazine magazine = Magazine.MagazineX();
        MusicCd musicCd = MusicCd.MusicCdX();

        LoginForm loginForm;
        AccountForm accountForm;
        ShoppingCartForm shoppingCartForm;

        List<ProductItems> allProducts;
        List<Book> books;
        List<Magazine> magazines;
        List<MusicCd> musicCds;

        ShoppingListItem[] shoppingListItem;

        // Default Constructor - Start
        public ShoppingForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Overloaded Constructor For Login Form Object - Start
        public ShoppingForm(LoginForm x)
        {
            InitializeComponent();
            loginForm = x;
        }
        // Overloaded Constructor For Login Form Object - End

        // ShoppingForm Load - Start
        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            admin.syncProductType("Book");
            books = book.listAllBooks();
            admin.syncProductType("Magazine");
            magazines = magazine.listAllMagazines();
            admin.syncProductType("MusicCD");
            musicCds = musicCd.listAllMusicCds();

            allProducts = admin.listAllProducts();
            populateItems();
        }
        // ShoppingForm Load - End

        // ShoppingForm Closing Event To Open Login Form - Start
        private void ShoppingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((accountForm == null || accountForm.IsDisposed) && (shoppingCartForm == null || shoppingCartForm.IsDisposed))
            {
                loginForm.Show();
            }
            else if ((shoppingCartForm == null || shoppingCartForm.IsDisposed) && (accountForm != null || !accountForm.IsDisposed))
            {
                accountForm.Show();
            }
            else if ((accountForm == null || accountForm.IsDisposed) && (shoppingCartForm != null || !shoppingCartForm.IsDisposed))
            {
                shoppingCartForm.Show();
            }
        }
        // ShoppingForm Closing Event To Open Login Form - End

        // Minimize Form - Start
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingForm - btnMinimize");
            this.WindowState = FormWindowState.Minimized;
        }
        // Minimize Form - End

        // Close Form - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingForm - btnExit");
            this.Close();
        }
        // Close Form - End

        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////
        private void btnBookStore_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingForm - btnBookStore");
            // We are in that page already. Maybe refresh?
        }
        ////////////////////////////////////////////////// NOT USED YET //////////////////////////////////////////////////

        // Open Shopping Cart Screen - Start
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingForm - btnShoppingCart");

            if (shoppingCartForm == null || shoppingCartForm.IsDisposed)
            {
                shoppingCartForm = new ShoppingCartForm(loginForm);
            }
            shoppingCartForm.Show();
            this.Close();
        }
        // Open Shopping Cart Screen - End

        // Open AccountForm - Start
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingForm - btnAccount");

            if (accountForm == null || accountForm.IsDisposed)
            {
                accountForm = new AccountForm(loginForm);
            }
            accountForm.Show();
            this.Close();
        }
        // Open AccountForm - End 

        // Show or Dont Show Books - Start
        private void chckbxBooks_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < shoppingListItem.Length; i++)
            {
                if(shoppingListItem[i].ProductType=="Book")
                {
                    if(chckbxBooks.Checked)
                    {
                        shoppingListItem[i].Visible = true;
                    }
                    else
                    {
                        shoppingListItem[i].Visible = false;
                    }
                }
            }
        }
        // Show or Dont Show Books - End

        // Show or Dont Show Magazines - Start
        private void chckbxMagazines_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < shoppingListItem.Length; i++)
            {
                if (shoppingListItem[i].ProductType == "Magazine")
                {
                    if (chckbxMagazines.Checked)
                    {
                        shoppingListItem[i].Visible = true;
                    }
                    else
                    {
                        shoppingListItem[i].Visible = false;
                    }
                }
            }
        }
        // Show or Dont Show Magazines - End

        // Show or Dont Show MusicCDs - Start
        private void chckbxMusicCDs_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < shoppingListItem.Length; i++)
            {
                if (shoppingListItem[i].ProductType == "MusicCD")
                {
                    if (chckbxMusicCDs.Checked)
                    {
                        shoppingListItem[i].Visible = true;
                    }
                    else
                    {
                        shoppingListItem[i].Visible = false;
                    }
                }
            }
        }
        // Show or Dont Show MusicCDs - End

        // Shopping Product List - Start
        public void populateItems()
        {
            flwLytPnlShopping.Controls.Clear();
            shoppingListItem = new ShoppingListItem[allProducts.Count];

            for (int i = 0; i < shoppingListItem.Length; i++)
            {
                shoppingListItem[i] = new ShoppingListItem();
                shoppingListItem[i].ProductID = allProducts[i].Id;
                shoppingListItem[i].ProductName = allProducts[i].Name;
                shoppingListItem[i].ProductType = allProducts[i].ProductType;
                shoppingListItem[i].ProductPrice = allProducts[i].Price.ToString("F", CultureInfo.InvariantCulture);
                string imageAdress = "";

                if (shoppingListItem[i].ProductType == "Book")
                {
                    int index = -1;
                    for (int j = 0; j < books.Count; j++)
                    {
                        if (shoppingListItem[i].ProductID == books[j].Id)
                        {
                            index = j;
                            break;
                        }
                    }
                    imageAdress = books[index].CoverPagePicture;
                }
                else if (shoppingListItem[i].ProductType == "Magazine")
                {
                    int index = -1;
                    for (int j = 0; j < magazines.Count; j++)
                    {
                        if (shoppingListItem[i].ProductID == magazines[j].Id)
                        {
                            index = j;
                            break;
                        }
                    }
                    imageAdress = magazines[index].CoverPagePicture;
                }
                else if (shoppingListItem[i].ProductType == "MusicCD")
                {
                    int index = -1;
                    for (int j = 0; j < musicCds.Count; j++)
                    {
                        if (shoppingListItem[i].ProductID == musicCds[j].Id)
                        {
                            index = j;
                            break;
                        }
                    }
                    imageAdress = musicCds[index].CoverPagePicture;
                }

                shoppingListItem[i].CoverPagePictureAdress = imageAdress;
                if (imageAdress != "")
                {
                    Image coverPagePicture = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
                    shoppingListItem[i].CoverPagePicture = coverPagePicture;
                }

                flwLytPnlShopping.Controls.Add(shoppingListItem[i]);
            }
        }
        // Shopping Product List - End
    }
}