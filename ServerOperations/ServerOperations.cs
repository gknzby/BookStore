using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Globalization;

namespace BookStore
{
    public static class ServerOperations
    {
        public static WebClient webClient = new WebClient();
        public static NameValueCollection dataToSend = new NameValueCollection();

        public static string login(string usernameX, string passwordX)
        {
            dataToSend["username"] = usernameX;
            dataToSend["password"] = passwordX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string saveCustomer(string usernameX, string nameX, string emailX, string adressX, string passwordX)
        {
            dataToSend["username"] = usernameX;
            dataToSend["name"] = nameX;
            dataToSend["email"] = emailX;
            dataToSend["adress"] = adressX;
            dataToSend["password"] = passwordX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string addCustomer(string updateTypeX, string idX, string accountConfirmedX)
        {
            dataToSend["updateType"] = updateTypeX;
            dataToSend["customerID"] = idX;
            dataToSend["accountConfirmed"] = accountConfirmedX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string upgradeToAdmin(string updateTypeX, string idX, string isAdminX)
        {
            dataToSend["updateType"] = updateTypeX;
            dataToSend["customerID"] = idX;
            dataToSend["isAdmin"] = isAdminX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string deleteUser(string idX)
        {
            dataToSend["id"] = idX;
            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string updateCustomer(string updateTypeX, string customerIDX, string usernameX, string nameX, string emailX, string adressX, string passwordX, string isAdminX, string accountConfirmedX,string emailConfirmedX)
        {
            dataToSend["updateType"] = updateTypeX;
            dataToSend["customerID"] = customerIDX;
            dataToSend["username"] = usernameX;
            dataToSend["name"] = nameX;
            dataToSend["email"] = emailX;
            dataToSend["adress"] = adressX;
            dataToSend["password"] = passwordX;
            dataToSend["isAdmin"] = isAdminX;
            dataToSend["accountConfirmed"] = accountConfirmedX;
            dataToSend["emailConfirmed"] = emailConfirmedX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string listAllUsers()
        {
            string res = Encoding.UTF8.GetString(webClient.DownloadData(_url));
            webClient.Dispose();
            return res;
        }

        public static string addNewBook(string nameX, double priceX, long isbnX, string authorX, string publisherX, int pageNumberX)
        {
            dataToSend["productType"] = "Book";
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["isbn"] = isbnX.ToString();
            dataToSend["author"] = authorX;
            dataToSend["publisher"] = publisherX;
            dataToSend["pageNumber"] = pageNumberX.ToString();

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string addNewMagazine(string nameX, double priceX, string typeX, DateTime issueX)
        {
            dataToSend["productType"] = "Magazine";
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["type"] = typeX;
            dataToSend["issue"] = issueX.ToString("yyyy-MM-dd");

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string addNewMusicCD(string nameX, double priceX, string typeX, string singerX)
        {
            dataToSend["productType"] = "MusicCD";
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["type"] = typeX;
            dataToSend["singer"] = singerX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string updateBook(long idX, string nameX, double priceX, long isbnX, string authorX, string publisherX, int pageNumberX)
        {
            dataToSend["productType"] = "Book";
            dataToSend["id"] = idX.ToString();
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["isbn"] = isbnX.ToString();
            dataToSend["author"] = authorX;
            dataToSend["publisher"] = publisherX;
            dataToSend["pageNumber"] = pageNumberX.ToString();

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string updateMagazine(long idX, string nameX, double priceX, string typeX, DateTime issueX)
        {
            dataToSend["productType"] = "Magazine";
            dataToSend["id"] = idX.ToString();
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["type"] = typeX;
            dataToSend["issue"] = issueX.ToString("yyyy-MM-dd");

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string updateMusicCD(long idX, string nameX, double priceX, string typeX, string singerX)
        {
            dataToSend["productType"] = "MusicCD";
            dataToSend["id"] = idX.ToString();
            dataToSend["name"] = nameX;
            dataToSend["price"] = priceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["type"] = typeX;
            dataToSend["singer"] = singerX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string deleteProduct(long idX, string typeX)
        {
            dataToSend["id"] = idX.ToString();
            dataToSend["productType"] = typeX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string syncProductType(string typeX)
        {
            dataToSend["productType"] = typeX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string listAllProducts()
        {
            dataToSend["productType"] = "All";

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string updateCoverPagePicture(string typeX, string idX, string coverPagePictureX)
        {
            dataToSend["productType"] = typeX;
            dataToSend["id"] = idX.ToString();
            dataToSend["coverPagePicture"] = coverPagePictureX;

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string placeOrder(long customerIDX,long productIDX, string productTypeX, string productNameX, double productPriceX, int quantityX,DateTime orderDateX)
        {
            dataToSend["customerID"] = customerIDX.ToString();
            dataToSend["productID"] = productIDX.ToString();
            dataToSend["productType"] = productTypeX;
            dataToSend["productName"] = productNameX;
            dataToSend["productPrice"] = productPriceX.ToString("F", CultureInfo.InvariantCulture);
            dataToSend["quantity"] = quantityX.ToString();
            dataToSend["orderDate"] = orderDateX.ToString("yyyy-MM-dd HH:mm:ss");

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string listOrders(long customerIDX)
        {
            dataToSend["customerID"] = customerIDX.ToString();

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }

        public static string saveButtonClick(string usernameX,string buttonNameX)
        {
            DateTime datetimeX = DateTime.UtcNow;

            dataToSend["username"] = usernameX;
            dataToSend["buttonName"] = buttonNameX;
            dataToSend["datetime"] = datetimeX.ToString("yyyy-MM-dd HH:mm:ss");

            string res = Encoding.UTF8.GetString(webClient.UploadValues(_url, dataToSend));
            dataToSend.Clear();
            webClient.Dispose();
            return res;
        }
    }
}