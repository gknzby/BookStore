using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;

namespace BookStore
{
    class Admin : User
    {
        Book book = Book.BookX();
        Magazine magazine = Magazine.MagazineX();
        MusicCd musicCd = MusicCd.MusicCdX();

        AccountForm accountForm;

        private static Admin admin; // Singleton Class Object.
        private static List<Admin> allUsers; // All Users's (Customer/Admin) Informations.
        private static List<ProductItems> allProducts; // All Products.

        // Default Constructor - Start
        private Admin()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static Admin AdminX()
        {
            if (admin == null)
            {
                admin = new Admin();
                allUsers = new List<Admin>();
                allProducts = new List<ProductItems>();
            }
            return admin;
        }
        // Singleton Patern Constructor - End

        // Confirm Customer Registeration - Start
        public string addCustomer(string updateTypeX, string idX, string accountConfirmedX)
        {
            string res = ServerOperations.addCustomer(updateTypeX, idX, accountConfirmedX);
            if (res != "Wrong Update Type Choice." && res != "User Doesnt Exists." && res != "Failed To Update." && res != "Please Fill The All Spaces.")
            {
                res = "Customer Registration Confirmed.";

                int index = -1;
                for (int i = 0; i < allUsers.Count; i++)
                {
                    if (allUsers[i].CustomerID == Int64.Parse(idX))
                    {
                        index = i;
                        break;
                    }
                }
                allUsers[index].AccountConfirmed = Int32.Parse(accountConfirmedX);
            }
            return res;
        }
        // Confirm Customer Registeration - End

        // Confirm Customer Registeration - Start
        public string upgradeToAdmin(string updateTypeX, string idX, string isAdminX)
        {
            string res = ServerOperations.upgradeToAdmin(updateTypeX, idX, isAdminX);
            if (res != "Wrong Update Type Choice." && res != "User Doesnt Exists." && res != "Failed To Update." && res != "Please Fill The All Spaces.")
            {
                res = "Admin Upgrade Successful.";

                int index = -1;
                for (int i = 0; i < allUsers.Count; i++)
                {
                    if (allUsers[i].CustomerID == Int64.Parse(idX))
                    {
                        index = i;
                        break;
                    }
                }
                allUsers[index].IsAdmin = Int32.Parse(isAdminX);
            }
            return res;
        }
        // Confirm Customer Registeration - End

        // Delete User - Start
        public string deleteUser(string idX,AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.deleteUser(idX);
            if (res != "Failed To Delete User." && res != "Please Fill The All Spaces.")
            {
                int index = -1;

                for (int i = 0; i < allUsers.Count; i++)
                {
                    if (allUsers[i].CustomerID == Int64.Parse(idX))
                    {
                        index = i;
                        break;
                    }
                }
                allUsers.RemoveAt(index);
                accountForm.removeFromListview(idX.ToString());
            }
            return res;
        }
        // Delete User - End

        // List All Users From Database - Start
        public List<Admin> listAllUsers()
        {
            allUsers.Clear();
            string res = ServerOperations.listAllUsers();
            if (res != "No User Exists.")
            {
                allUsers = JsonConvert.DeserializeObject<List<Admin>>(res);
            }
            return allUsers;
        }
        // List All Users From Database - End

        // Add New Book To Database - Start
        public string addNewBook(string nameX, double priceX, long isbnX, string authorX, string publisherX, int pageNumberX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.addNewBook(nameX, priceX, isbnX, authorX, publisherX, pageNumberX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add Book." &&
                res != "Added Product But Failed To Add Book." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
            {
                long idX = Int64.Parse(res);
                string coverPagePictureX = "";
                book.addBook(idX, nameX, priceX, isbnX, authorX, publisherX, pageNumberX, coverPagePictureX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "Book" };
                accountForm.addToListview(product);
            }
            return res;
        }
        // Add New Book To Database - End

        // Add New Magazine To Database - Start
        public string addNewMagazine(string nameX, double priceX, string typeX, DateTime issueX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.addNewMagazine(nameX, priceX, typeX, issueX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add Magazine." &&
                res != "Added Product But Failed To Add Magazine." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
            {
                long idX = Int64.Parse(res);
                string coverPagePictureX = "";
                magazine.addMagazine(idX, nameX, priceX, typeX, issueX, coverPagePictureX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "Magazine" };
                accountForm.addToListview(product);
            }
            return res;
        }
        // Add New Magazine To Database - End

        // Add New MusicCD To Database - Start
        public string addNewMusicCD(string nameX, double priceX, string typeX, string singerX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.addNewMusicCD(nameX, priceX, typeX, singerX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Read Id." && res != "Failed To Add MusicCD." &&
                res != "Added Product But Failed To Add MusicCD." && res != "Failed To Add Product." && res != "Please Choose Product Type.")
            {
                long idX = Int64.Parse(res);
                string coverPagePictureX = "";
                musicCd.addMusicCd(idX, nameX, priceX, typeX, singerX, coverPagePictureX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "MusicCD" };
                accountForm.addToListview(product);
            }
            return res;
        }
        // Add New MusicCD To Database - End

        // Update Book - Start
        public string updateBook(long idX, string nameX, double priceX, long isbnX, string authorX, string publisherX, int pageNumberX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.updateBook(idX, nameX, priceX, isbnX, authorX, publisherX, pageNumberX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
            {
                book.updateBook(idX, nameX, priceX, isbnX, authorX, publisherX, pageNumberX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "Book" };
                accountForm.updateAtListview(product, idX.ToString());
                res = "Book Updated Successfully.";
            }
            return res;
        }
        // Update Book - End

        // Update Magazine - Start
        public string updateMagazine(long idX, string nameX, double priceX, string typeX, DateTime issueX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.updateMagazine(idX, nameX, priceX, typeX, issueX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
            {
                magazine.updateMagazine(idX, nameX, priceX, typeX, issueX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "Magazine" };
                accountForm.updateAtListview(product, idX.ToString());
                res = "Magazine Updated Successfully.";
            }
            return res;
        }
        // Update Magazine - End

        // Update MusicCD - Start
        public string updateMusicCD(long idX, string nameX, double priceX, string typeX, string singerX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.updateMusicCD(idX, nameX, priceX, typeX, singerX);
            if (res != "Please Fill The All Spaces." && res != "Wrong Product Type Choice." && res != "Failed To Update Product." && res != "Please Choose Product Type.")
            {
                musicCd.updateMusicCd(idX, nameX, priceX, typeX, singerX);

                string[] product = { idX.ToString(), nameX, priceX.ToString("F", CultureInfo.InvariantCulture), "MusicCD" };
                accountForm.updateAtListview(product, idX.ToString());
                res = "MusicCD Updated Successfully.";
            }
            return res;
        }
        // Update MusicCD - End

        // Delete Product - Start
        public string deleteProduct(long idX, string typeX, AccountForm x)
        {
            accountForm = x;
            string res = ServerOperations.deleteProduct(idX, typeX);
            if (res != "Wrong Product Type Choice." && res != "Failed To Delete Product." && res != "Please Choose Product Type.")
            {
                if (typeX == "Book")
                {
                    book.removeBook(idX);
                }
                else if (typeX == "Magazine")
                {
                    magazine.removeMagazine(idX);
                }
                else if (typeX == "MusicCD")
                {
                    musicCd.removeMusicCd(idX);
                }
                accountForm.removeFromListview(idX.ToString());
            }
            return res;
        }
        // Delete Product - End

        // Sync Product Lists With Database - Start
        public void syncProductType(string typeX)
        {
            string res = ServerOperations.syncProductType(typeX);
            if (typeX == "Book")
            {
                book.clearBooks();
                if (res != "No Book Exists." && res != "Wrong Product Type Choice." && res != "Please Choose A Product Type.")
                {
                    book.syncAllBooks(JsonConvert.DeserializeObject<List<Book>>(res));
                }
            }
            else if (typeX == "Magazine")
            {
                magazine.clearMagazines();
                if (res != "No Magazine Exists." && res != "Wrong Product Type Choice." && res != "Please Choose A Product Type.")
                {
                    magazine.syncAllMagazines(JsonConvert.DeserializeObject<List<Magazine>>(res));
                }
            }
            else if (typeX == "MusicCD")
            {
                musicCd.clearMusicCds();
                if (res != "No MusicCD Exists." && res != "Wrong Product Type Choice." && res != "Please Choose A Product Type.")
                {
                    musicCd.syncAllMusicCds(JsonConvert.DeserializeObject<List<MusicCd>>(res));
                }
            }
        }
        // Sync Product Lists With Database - End

        // Sync All Products List With Database - Start
        public List<ProductItems> listAllProducts()
        {
            allProducts.Clear();
            string res = ServerOperations.listAllProducts();
            if (res != "No Product Exists." && res != "Wrong Product Type Choice." && res != "Please Choose A Product Type.")
            {
                allProducts = JsonConvert.DeserializeObject<List<ProductItems>>(res);
            }
            return allProducts;
        }
        // Sync All Products List With Database - End

        // Add Or Update Cover Page Picture Of Product - Start
        public void addCoverPagePicture(long idX, string typeX, string fileNameX, string pictureNameX)
        {
            ImageOperations.UploadImage(fileNameX, pictureNameX);
            ServerOperations.updateCoverPagePicture(typeX, idX.ToString(), pictureNameX);

            if (typeX == "Book")
            {
                book.AddCoverPagePicture(idX, pictureNameX);
            }
            else if (typeX == "Magazine")
            {
                magazine.AddCoverPagePicture(idX, pictureNameX);
            }
            else if (typeX == "MusicCD")
            {
                musicCd.AddCoverPagePicture(idX, pictureNameX);
            }
        }
        // Add Or Update Cover Page Picture Of Product - End
    }
}