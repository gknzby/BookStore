using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class DetailsPopupForm : Form
    {
        Customer customer = Customer.CustomerX();
        Admin admin = Admin.AdminX();
        ShoppingCart shoppingCart = ShoppingCart.ShoppingCartX();

        AccountForm accountForm;

        string productType = "";
        string imageAdress = "";
        string pictureFileName = "";
        string imageType = "";

        // Default Constructor - Start
        public DetailsPopupForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Overloaded Constructor For AccountForm Form Object - Start
        public DetailsPopupForm(AccountForm x)
        {
            InitializeComponent();
            accountForm = x;
        }
        // Overloaded Constructor For AccountForm Form Object - End

        // DetailsPopupForm Load - Start
        private void DetailsPopupForm_Load(object sender, EventArgs e)
        {

        }
        // DetailsPopupForm Load - End

        // Back To Account Form - Start
        private void btnBack_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnBack");
            this.Close();
        }
        // Back To Account Form - End

        // Close DetailsPopupForm - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnExit");
            this.Close();
        }
        // Close DetailsPopupForm - End

        // Set UI For 'Add New Product' - Start
        public void newProductUI()
        {
            pnlProduct.BringToFront();

            cmboxProductType.Visible = true;

            btnAddProduct.Visible = true;
            btnDeleteProduct.Visible = false;
            btnUpdateProduct.Visible = false;
            btnUploadPic.Visible = false;
            picbxCoverPagePic.Visible = false;

            lblProductID.Visible = false;
            lblProductName.Visible = false;
            lblProductPrice.Visible = false;
            lblProductVar1.Visible = false;
            lblProductVar2.Visible = false;
            lblProductVar3.Visible = false;
            lblProductVar4.Visible = false;

            txtProductID.Visible = false;
            txtProductName.Visible = false;
            txtProductPrice.Visible = false;
            txtProductVar1.Visible = false;
            txtProductVar2.Visible = false;
            txtProductVar3.Visible = false;
            txtProductVar4.Visible = false;

            picbxCoverPagePic.Image = null;
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtProductVar1.Text = "";
            txtProductVar2.Text = "";
            txtProductVar3.Text = "";
            txtProductVar4.Text = "";

            cmboxProductType.SelectedIndex = -1;
        }
        // Set UI For 'Add New Product' - End

        // Set UI For 'Selected User' - Start
        public void userUI(string[] user)
        {
            pnlUser.BringToFront();

            cmboxProductType.Visible = false;

            txtCustomerID.Text = user[0];
            txtUsername.Text = user[1];
            txtName.Text = user[2];
            txtEmail.Text = user[3];
            txtAdress.Text = user[4];

            if (user[5] == "1")
            {
                chckbxIsAdmin.Checked = true;
            }
            else
            {
                chckbxIsAdmin.Checked = false;
            }

            if (user[6] == "1")
            {
                chckbxAccountConfirmed.Checked = true;
            }
            else
            {
                chckbxAccountConfirmed.Checked = false;
            }
        }
        // Set UI For 'Selected User' - End

        // Set UI For 'Selected Product' - Start
        public void productUI(string[] product, string type)
        {
            pnlProduct.BringToFront();

            productType = type;
            cmboxProductType.Visible = false;

            btnAddProduct.Visible = false;
            btnDeleteProduct.Visible = true;
            btnUpdateProduct.Visible = true;
            btnUploadPic.Visible = true;
            picbxCoverPagePic.Visible = true;

            txtProductID.Text = product[0];
            txtProductName.Text = product[1];
            txtProductPrice.Text = product[2];
            txtProductVar1.Text = product[3];
            txtProductVar2.Text = product[4];

            imageAdress = "";

            if (type == "Book")
            {
                txtProductVar3.Visible = true;
                txtProductVar4.Visible = true;
                lblProductVar3.Visible = true;
                lblProductVar4.Visible = true;

                lblProductVar1.Text = "ISBN";
                lblProductVar2.Text = "Author";
                lblProductVar3.Text = "Publisher";
                lblProductVar4.Text = "Page Number";

                txtProductVar3.Text = product[5];
                txtProductVar4.Text = product[6];
                imageAdress = product[7];
            }
            else if (type == "Magazine")
            {
                txtProductVar3.Visible = false;
                txtProductVar4.Visible = false;
                lblProductVar3.Visible = false;
                lblProductVar4.Visible = false;

                lblProductVar1.Text = "Type";
                lblProductVar2.Text = "Issue";

                imageAdress = product[5];
            }
            else if (type == "MusicCD")
            {
                txtProductVar3.Visible = false;
                txtProductVar4.Visible = false;
                lblProductVar3.Visible = false;
                lblProductVar4.Visible = false;

                lblProductVar1.Text = "Type";
                lblProductVar2.Text = "Singer";

                imageAdress = product[5];
            }
            if (imageAdress != "")
            {
                picbxCoverPagePic.Image = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
            }
        }
        // Set UI For 'Selected Product' - End

        // New Product Type Choice - Start
        private void cmboxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboxProductType.SelectedIndex == 0)
            {
                btnUploadPic.Visible = true;
                picbxCoverPagePic.Visible = true;

                lblProductID.Visible = false;
                lblProductName.Visible = true;
                lblProductPrice.Visible = true;
                lblProductVar1.Visible = true;
                lblProductVar2.Visible = true;
                lblProductVar3.Visible = true;
                lblProductVar4.Visible = true;

                txtProductID.Visible = false;
                txtProductName.Visible = true;
                txtProductPrice.Visible = true;
                txtProductVar1.Visible = true;
                txtProductVar2.Visible = true;
                txtProductVar3.Visible = true;
                txtProductVar4.Visible = true;

                lblProductVar1.Text = "ISBN";
                lblProductVar2.Text = "Author";
                lblProductVar3.Text = "Publisher";
                lblProductVar4.Text = "Page Number";
            }
            else if (cmboxProductType.SelectedIndex == 1)
            {
                btnUploadPic.Visible = true;
                picbxCoverPagePic.Visible = true;

                lblProductID.Visible = false;
                lblProductName.Visible = true;
                lblProductPrice.Visible = true;
                lblProductVar1.Visible = true;
                lblProductVar2.Visible = true;
                lblProductVar3.Visible = false;
                lblProductVar4.Visible = false;

                txtProductID.Visible = false;
                txtProductName.Visible = true;
                txtProductPrice.Visible = true;
                txtProductVar1.Visible = true;
                txtProductVar2.Visible = true;
                txtProductVar3.Visible = false;
                txtProductVar4.Visible = false;

                lblProductVar1.Text = "Type";
                lblProductVar2.Text = "Issue";
            }
            else if (cmboxProductType.SelectedIndex == 2)
            {
                btnUploadPic.Visible = true;
                picbxCoverPagePic.Visible = true;

                lblProductID.Visible = false;
                lblProductName.Visible = true;
                lblProductPrice.Visible = true;
                lblProductVar1.Visible = true;
                lblProductVar2.Visible = true;
                lblProductVar3.Visible = false;
                lblProductVar4.Visible = false;

                txtProductID.Visible = false;
                txtProductName.Visible = true;
                txtProductPrice.Visible = true;
                txtProductVar1.Visible = true;
                txtProductVar2.Visible = true;
                txtProductVar3.Visible = false;
                txtProductVar4.Visible = false;

                lblProductVar1.Text = "Type";
                lblProductVar2.Text = "Singer";
            }
        }
        // New Product Type Choice - End

        // Add New Product - Start
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnAddProduct");

            if (cmboxProductType.SelectedIndex == 0)
            {
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                long isbnX = Int64.Parse(txtProductVar1.Text.Trim());
                string authorX = txtProductVar2.Text.Trim();
                string publisherX = txtProductVar3.Text.Trim();
                int pageNumberX = Int32.Parse(txtProductVar4.Text.Trim());

                string res = admin.addNewBook(nameX, priceX, isbnX, authorX, publisherX, pageNumberX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add Book." &&
                res != "Added Product But Failed To Add Book." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
                {
                    long idX = Int64.Parse(res);
                    if (pictureFileName != "")
                    {
                        admin.addCoverPagePicture(idX, "Book", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "Book Added Successfully.";
                }
                MessageBox.Show(res);
            }
            else if (cmboxProductType.SelectedIndex == 1)
            {
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                string typeX = txtProductVar1.Text.Trim();
                DateTime issueX = Convert.ToDateTime(txtProductVar2.Text.Trim());

                string res = admin.addNewMagazine(nameX, priceX, typeX, issueX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add Magazine." &&
                res != "Added Product But Failed To Add Magazine." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
                {
                    long idX = Int64.Parse(res);
                    if (pictureFileName != "")
                    {
                        admin.addCoverPagePicture(idX, "Magazine", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "Magazine Added Successfully.";
                }
                MessageBox.Show(res);
            }
            else if (cmboxProductType.SelectedIndex == 2)
            {
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                string typeX = txtProductVar1.Text.Trim();
                string singerX = txtProductVar2.Text.Trim();

                string res = admin.addNewMusicCD(nameX, priceX, typeX, singerX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add MusicCD." &&
                res != "Added Product But Failed To Add MusicCD." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
                {
                    long idX = Int64.Parse(res);
                    if (pictureFileName != "")
                    {
                        admin.addCoverPagePicture(idX, "MusicCD", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "MusicCD Added Successfully.";
                }
                MessageBox.Show(res);
            }
            this.Close();
        }
        // Add New Product - End

        // Update Product - Start
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnUpdateProduct");
            if (productType == "Book")
            {
                long idX = Int64.Parse(txtProductID.Text.Trim());
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                long isbnX = Int64.Parse(txtProductVar1.Text.Trim());
                string authorX = txtProductVar2.Text.Trim();
                string publisherX = txtProductVar3.Text.Trim();
                int pageNumberX = Int32.Parse(txtProductVar4.Text.Trim());

                string res = admin.updateBook(idX, nameX, priceX, isbnX, authorX, publisherX, pageNumberX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
                {
                    if (pictureFileName != "")
                    {
                        if (imageAdress != "")
                        {
                            ImageOperations.DeleteImage(imageAdress);
                        }
                        admin.addCoverPagePicture(idX, "Book", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "Book Updated Successfully.";
                }
                MessageBox.Show(res);

                Book book = new Book();
                book.Id = idX;
                book.Name = nameX;
                book.Price = priceX;
                book.CoverPagePicture = imageAdress;

                shoppingCart.updateProduct(book);
            }
            else if (productType == "Magazine")
            {
                long idX = Int64.Parse(txtProductID.Text.Trim());
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                string typeX = txtProductVar1.Text.Trim();
                DateTime issueX = Convert.ToDateTime(txtProductVar2.Text.Trim());

                string res = admin.updateMagazine(idX, nameX, priceX, typeX, issueX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
                {
                    if (pictureFileName != "")
                    {
                        if (imageAdress != "")
                        {
                            ImageOperations.DeleteImage(imageAdress);
                        }
                        admin.addCoverPagePicture(idX, "Magazine", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "Magazine Updated Successfully.";
                }
                MessageBox.Show(res);

                Magazine magazine = new Magazine();
                magazine.Id = idX;
                magazine.Name = nameX;
                magazine.Price = priceX;
                magazine.CoverPagePicture = imageAdress;

                shoppingCart.updateProduct(magazine);
            }
            else if (productType == "MusicCD")
            {
                long idX = Int64.Parse(txtProductID.Text.Trim());
                string nameX = txtProductName.Text.Trim();
                double priceX = Double.Parse(txtProductPrice.Text.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
                string typeX = txtProductVar1.Text.Trim();
                string singerX = txtProductVar2.Text.Trim();

                string res = admin.updateMusicCD(idX, nameX, priceX, typeX, singerX, accountForm);
                if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
                {
                    if (pictureFileName != "")
                    {
                        if (imageAdress != "")
                        {
                            ImageOperations.DeleteImage(imageAdress);
                        }
                        admin.addCoverPagePicture(idX, "MusicCD", pictureFileName, idX.ToString() + imageType);
                    }
                    res = "MusicCD Updated Successfully.";
                }
                MessageBox.Show(res);

                MusicCd musicCd = new MusicCd();
                musicCd.Id = idX;
                musicCd.Name = nameX;
                musicCd.Price = priceX;
                musicCd.CoverPagePicture = imageAdress;

                shoppingCart.updateProduct(musicCd);
            }
            this.Close();
        }
        // Update Product - End

        // Delete Product - Start
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnDeleteProduct");
            long idX = Int64.Parse(txtProductID.Text.Trim());
            string typeX = productType;

            string res = admin.deleteProduct(idX, typeX, accountForm);
            if (res != "Wrong Product Type Choice." && res != "Failed To Delete Product." && res != "Please Choose Product Type.")
            {
                if (imageAdress != "")
                {
                    ImageOperations.DeleteImage(imageAdress);
                }
            }
            MessageBox.Show(res);
            if(typeX=="Book")
            {
                Book book = new Book();
                book.Id = idX;
                shoppingCart.removeProduct(book);
            }
            else if(typeX=="Magazine")
            {
                Magazine magazine = new Magazine();
                magazine.Id = idX;
                shoppingCart.removeProduct(magazine);
            }
            else if (typeX == "MusicCD")
            {
                MusicCd musicCd = new MusicCd();
                musicCd.Id = idX;
                shoppingCart.removeProduct(musicCd);
            }
            this.Close();
        }
        // Delete Product - End

        // Delete User - Start
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnDeleteUser");

            string idX = txtCustomerID.Text;

            string res = admin.deleteUser(idX, accountForm);
            MessageBox.Show(res);
            this.Close();
        }
        // Delete User - End

        // Upload Cover Page Picture - Start
        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "DetailsPopupForm - btnUploadPic");

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureFileName = openFileDialog.FileName;
                Image image = Image.FromFile(pictureFileName);
                picbxCoverPagePic.Image = image;

                if (ImageFormat.Jpeg.Equals(image.RawFormat))
                {
                    imageType = ".jpg";
                }
                else if (ImageFormat.Png.Equals(image.RawFormat))
                {
                    imageType = ".png";
                }
                else
                {
                    imageType = ".jpg"; // Default Image Value Is JPEG
                }
            }
        }
        // Upload Cover Page Picture - End
    }
}