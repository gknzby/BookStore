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
    public partial class ShoppingItemDetailsPopupForm : Form
    {
        Customer customer = Customer.CustomerX();
        Admin admin = Admin.AdminX();
        Book book = Book.BookX();
        Magazine magazine = Magazine.MagazineX();
        MusicCd musicCd = MusicCd.MusicCdX();

        List<Book> books;
        List<Magazine> magazines;
        List<MusicCd> musicCds;

        // Default Constructor - Start
        public ShoppingItemDetailsPopupForm()
        {
            InitializeComponent();
        }
        // Default Constructor - End

        // Set UI For Books - Start
        public void bookUI(long idX)
        {
            admin.syncProductType("Book");
            books = book.listAllBooks();

            lblVar3.Visible = true;
            lblVar4.Visible = true;

            int index = -1;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }

            lblProductType.Text = "Product Type : Book";
            lblName.Text = "Name : " + books[index].Name;
            lblPrice.Text = "Price : " + books[index].Price.ToString("F", CultureInfo.InvariantCulture) + " TL";
            lblVar1.Text = "Author : " + books[index].Author;
            lblVar2.Text = "Publisher : " + books[index].Publisher;
            lblVar3.Text = "PageNumber : " + books[index].PageNumber.ToString();
            lblVar4.Text = "Isbn : " + books[index].Isbn.ToString();

            string imageAdress = books[index].CoverPagePicture;

            if (imageAdress != "")
            {
                Image coverPagePicture = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
                picbxCoverPagePic.Image = coverPagePicture;
            }
        }
        // Set UI For Books - End

        // Set UI For Magazines - Start
        public void magazineUI(long idX)
        {
            admin.syncProductType("Magazine");
            magazines = magazine.listAllMagazines();

            lblVar3.Visible = false;
            lblVar4.Visible = false;

            int index = -1;

            for (int i = 0; i < magazines.Count; i++)
            {
                if (magazines[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }

            lblProductType.Text = "Product Type : Magazine";
            lblName.Text = "Name : " + magazines[index].Name;
            lblPrice.Text = "Price : " + magazines[index].Price.ToString("F", CultureInfo.InvariantCulture) + " TL";
            lblVar1.Text = "Type : " + magazines[index].Type;
            lblVar2.Text = "Issue : " + magazines[index].Issue.ToString("yyyy-MM-dd");

            string imageAdress = magazines[index].CoverPagePicture;

            if (imageAdress != "")
            {
                Image coverPagePicture = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
                picbxCoverPagePic.Image = coverPagePicture;
            }
        }
        // Set UI For Magazines - End

        // Set UI For MusicCDs - Start
        public void musicCdUI(long idX)
        {
            admin.syncProductType("MusicCD");
            musicCds = musicCd.listAllMusicCds();

            lblVar3.Visible = false;
            lblVar4.Visible = false;

            int index = -1;

            for (int i = 0; i < musicCds.Count; i++)
            {
                if (musicCds[i].Id == idX)
                {
                    index = i;
                    break;
                }
            }

            lblProductType.Text = "Product Type : MusicCD";
            lblName.Text = "Name : " + musicCds[index].Name;
            lblPrice.Text = "Price : " + musicCds[index].Price.ToString("F", CultureInfo.InvariantCulture) + " TL";
            lblVar1.Text = "Type : " + musicCds[index].Type;
            lblVar2.Text = "Singer : " + musicCds[index].Singer;

            string imageAdress = musicCds[index].CoverPagePicture;

            if (imageAdress != "")
            {
                Image coverPagePicture = Image.FromStream(ImageOperations.DownloadImage(imageAdress));
                picbxCoverPagePic.Image = coverPagePicture;
            }
        }
        // Set UI For MusicCDs - End

        // Close Form - Start
        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "ShoppingItemDetailsPopupForm - btnExit");
            this.Close();
        }
        // Close Form - End
    }
}