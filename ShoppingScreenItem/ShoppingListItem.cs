using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BookStore
{
    public partial class ShoppingListItem : UserControl
    {
        Customer customer = Customer.CustomerX();
        ShoppingCart shoppingCart = ShoppingCart.ShoppingCartX();

        ShoppingCartForm shoppingCartForm;
        ShoppingItemDetailsPopupForm shoppingItemDetailsPopupForm;

        Book book = new Book();
        Magazine magazine = new Magazine();
        MusicCd musicCd = new MusicCd();

        int firstLoad = 1;

        private long productID;
        private string productName;
        private string productType;
        private string productPrice;
        private string coverPagePictureAdress;
        private Image coverPagePicture;
        private int quantity;

        // Product ID - Getter / Setter
        public long ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        // Product Name - Getter / Setter
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                
                if(value.Length>30)
                {
                    int cutIndex = -1;

                    for(int i=30;i>0;i--)
                    {
                        if(value.Substring(i,1)==" ")
                        {
                            cutIndex = i;
                            break;
                        }
                    }
                    if(cutIndex!=-1)
                    {
                        lblProductName.Text = value.Substring(0, cutIndex) + Environment.NewLine + value.Substring(cutIndex + 1);
                    }
                    else
                    {
                        lblProductName.Text = value.Substring(0, 30);
                    }
                }
                else
                {
                    lblProductName.Text = value;
                }
            }
        }
        // Product Type - Getter / Setter
        public string ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
                lblProductType.Text = value;
            }
        }
        // Product Price - Getter / Setter
        public string ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
                lblProductPrice.Text = value + " TL";
            }
        }
        // Product Cover Page Picture Adress - Getter / Setter
        public string CoverPagePictureAdress
        {
            get
            {
                return coverPagePictureAdress;
            }
            set
            {
                coverPagePictureAdress = value;
            }
        }
        // Product Cover Page Picture - Getter / Setter
        public Image CoverPagePicture
        {
            get
            {
                return coverPagePicture;
            }
            set
            {
                coverPagePicture = value;
                picbxCoverPagePicture.Image = value;
            }
        }
        // Quantity - Getter / Setter
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                cmbxQuantity.SelectedIndex = value - 1;
            }
        }

        // Default Constructor - Start
        public ShoppingListItem()
        {
            InitializeComponent();
        }
        // Default Constructor - Start

        // Overloaded Constructor For ShoppingCart Form Object - Start
        public ShoppingListItem(ShoppingCartForm x)
        {
            InitializeComponent();
            shoppingCartForm = x;
        }
        // Overloaded Constructor For ShoppingCart Form Object - Start

        // Set UI of Item At Load - Start
        private void ShoppingListItem_Load(object sender, EventArgs e)
        {
            if (shoppingCartForm == null || shoppingCartForm.IsDisposed)
            {
                btnRemoveFromCart.Visible = false;
                btnAddToCart.Visible = true;
            }
            else
            {
                btnRemoveFromCart.Visible = true;
                btnAddToCart.Visible = false;
            }
            firstLoad = 0;
        }
        // Set UI of Item At Load - End

        // Add Item To Shopping Cart - Start
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingListItem - btnAddToCart");

            Quantity = cmbxQuantity.SelectedIndex + 1;

            if (Quantity != 0)
            {
                if (ProductType == "Book")
                {
                    book.Id = ProductID;
                    book.Name = ProductName;
                    book.ProductType = ProductType;
                    book.Price = Double.Parse(ProductPrice.Replace(',', '.'), CultureInfo.InvariantCulture);
                    book.CoverPagePicture = CoverPagePictureAdress;

                    shoppingCart.addProduct(book, Quantity);
                }
                else if (ProductType == "Magazine")
                {
                    magazine.Id = ProductID;
                    magazine.Name = ProductName;
                    magazine.ProductType = ProductType;
                    magazine.Price = Double.Parse(ProductPrice.Replace(',', '.'), CultureInfo.InvariantCulture);
                    magazine.CoverPagePicture = CoverPagePictureAdress;

                    shoppingCart.addProduct(magazine, Quantity);
                }
                else if (ProductType == "MusicCD")
                {
                    musicCd.Id = ProductID;
                    musicCd.Name = ProductName;
                    musicCd.ProductType = ProductType;
                    musicCd.Price = Double.Parse(ProductPrice.Replace(',', '.'), CultureInfo.InvariantCulture);
                    musicCd.CoverPagePicture = CoverPagePictureAdress;

                    shoppingCart.addProduct(musicCd, Quantity);
                }
                Quantity = 0;
                cmbxQuantity.SelectedIndex = -1;
                MessageBox.Show("Product Added To Your Cart.");
            }
            else
            {
                MessageBox.Show("Please Choose Quantity.");
            }
        }
        // Add Item To Shopping Cart - End

        // Remove Item From Shopping Cart - Start
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingListItem - btnRemoveFromCart");

            if (ProductType == "Book")
            {
                book.Id = ProductID;

                shoppingCart.removeProduct(book);
            }
            else if (ProductType == "Magazine")
            {
                magazine.Id = ProductID;

                shoppingCart.removeProduct(magazine);
            }
            else if (ProductType == "MusicCD")
            {
                musicCd.Id = ProductID;

                shoppingCart.removeProduct(musicCd);
            }
            shoppingCartForm.populateItems();
            // Maybe Find An Alternate Solution Instead Populate?
            MessageBox.Show("Product Removed From Your Cart.");
        }
        // Remove Item From Shopping Cart - End

        // Change Quantity Of Selected Item At Shopping Cart - Start
        private void cmbxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shoppingCartForm == null || shoppingCartForm.IsDisposed)
            {
                // Do Nothing.
            }
            else
            {
                Quantity = cmbxQuantity.SelectedIndex + 1;

                if (ProductType == "Book")
                {
                    Quantity = cmbxQuantity.SelectedIndex + 1;
                    book.Id = ProductID;

                    shoppingCart.changeQuantity(book, Quantity);
                }
                else if (ProductType == "Magazine")
                {
                    Quantity = cmbxQuantity.SelectedIndex + 1;
                    magazine.Id = ProductID;

                    shoppingCart.changeQuantity(magazine, Quantity);
                }
                else if (ProductType == "MusicCD")
                {
                    Quantity = cmbxQuantity.SelectedIndex + 1;
                    musicCd.Id = ProductID;

                    shoppingCart.changeQuantity(musicCd, Quantity);
                }
                if (firstLoad == 0)
                {
                    shoppingCartForm.populateItems();
                }
            }
        }
        // Change Quantity Of Selected Item At Shopping Cart - End

        // Show Product Details - Start
        private void btnDetails_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingListItem - btnDetails");

            if (shoppingItemDetailsPopupForm == null || shoppingItemDetailsPopupForm.IsDisposed)
            {
                shoppingItemDetailsPopupForm = new ShoppingItemDetailsPopupForm();
            }

            if (ProductType == "Book")
            {
                shoppingItemDetailsPopupForm.bookUI(ProductID);
            }
            else if (ProductType == "Magazine")
            {
                shoppingItemDetailsPopupForm.magazineUI(ProductID);
            }
            else if (ProductType == "MusicCD")
            {
                shoppingItemDetailsPopupForm.musicCdUI(ProductID);
            }

            shoppingItemDetailsPopupForm.Show();
        }
        // Show Product Details - End
    }
}