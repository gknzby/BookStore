using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ShoppingCart
    {
        Admin admin = Admin.AdminX();
        Book book = Book.BookX();
        Magazine magazine = Magazine.MagazineX();
        MusicCd musicCd = MusicCd.MusicCdX();

        List<Book> books;
        List<Magazine> magazines;
        List<MusicCd> musicCds;
        // private double paymentAmount; // - Gereksiz ise sil
        // private int paymentType; // - Gereksiz ise sil
        private Customer customer = Customer.CustomerX();

        private static ShoppingCart shoppingCart; // Singleton Class Object.
        private static List<ItemToPurchase> listItems; // Items In The Shopping Cart.

        // Default Constructor - Start
        private ShoppingCart()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static ShoppingCart ShoppingCartX()
        {
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
                listItems = new List<ItemToPurchase>();
            }
            return shoppingCart;
        }
        // Singleton Patern Constructor - End

        // Add Items To Shopping Cart List - Start
        public void addProduct(Product product, int quantity)
        {
            int exists = -1;
            for (int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].Product.Id == product.Id)
                {
                    if (listItems[i].Quantity + quantity <= 20)
                    {
                        listItems[i].Quantity += quantity;
                    }
                    else
                    {
                        listItems[i].Quantity = 20;
                    }
                    exists = 1;
                    break;
                }
            }
            if (exists == -1)
            {
                listItems.Add(new ItemToPurchase(product, quantity));
            }
        }
        // Add Items To Shopping Cart List - End

        // Remove Items From Shopping Cart List - Start
        public void removeProduct(Product product)
        {
            int index = -1;
            for (int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].Product.Id == product.Id)
                {
                    index = i;
                    break;
                }
            }
            if(index!=-1)
            {
                listItems.RemoveAt(index);
            } 
        }
        // Remove Items From Shopping Cart List - End

        // Change Items Quantity From Shopping Cart List - Start
        public void changeQuantity(Product product, int quantity)
        {
            int index = -1;
            for (int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].Product.Id == product.Id)
                {
                    index = i;
                    break;
                }
            }
            listItems[index].Quantity = quantity;
        }
        // Change Items Quantity From Shopping Cart List - End

        // List All Items To Purchase - Start
        public List<ItemToPurchase> printProducts()
        {
            return listItems;
        }
        // List All Items To Purchase - End

        // Update A Product's Informations In Shopping Cart - Start
        public void updateProduct(Product product)
        {
            int index = -1;
            for (int i = 0; i < listItems.Count; i++)
            {
                if (listItems[i].Product.Id == product.Id)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                listItems[index].Product.Name = product.Name;
                listItems[index].Product.Price = product.Price;
                listItems[index].Product.CoverPagePicture = product.CoverPagePicture;
            } 
        }
        // Update A Product's Informations In Shopping Cart - End

        // Sync List With Database - Start
        public void syncCart()
        {
            for(int i=0;i<listItems.Count;i++)
            {
                if(listItems[i].Product.ProductType=="Book")
                {
                    admin.syncProductType("Book");
                    books = book.listAllBooks();
                   
                    for(int j=0;j<books.Count;j++)
                    {
                        if(listItems[i].Product.Id==books[j].Id)
                        {
                            listItems[i].Product.Name = books[j].Name;
                            listItems[i].Product.Price = books[j].Price;
                            listItems[i].Product.CoverPagePicture = books[j].CoverPagePicture;
                            break;
                        }
                    }
                }
                else if (listItems[i].Product.ProductType == "Magazine")
                {
                    admin.syncProductType("Magazine");
                    magazines = magazine.listAllMagazines();

                    for (int j = 0; j < magazines.Count; j++)
                    {
                        if (listItems[i].Product.Id == magazines[j].Id)
                        {
                            listItems[i].Product.Name = magazines[j].Name;
                            listItems[i].Product.Price = magazines[j].Price;
                            listItems[i].Product.CoverPagePicture = magazines[j].CoverPagePicture;
                            break;
                        }
                    }
                }
                else if (listItems[i].Product.ProductType == "MusicCD")
                {
                    admin.syncProductType("MusicCD");
                    musicCds = musicCd.listAllMusicCds();

                    for (int j = 0; j < musicCds.Count; j++)
                    {
                        if (listItems[i].Product.Id == musicCds[j].Id)
                        {
                            listItems[i].Product.Name = musicCds[j].Name;
                            listItems[i].Product.Price = musicCds[j].Price;
                            listItems[i].Product.CoverPagePicture = musicCds[j].CoverPagePicture;
                            break;
                        }
                    }
                }
            }
        }
        // Sync List With Database - End

        // Place Order - Start
        public string placeOrder(string creditNo)
        {
            CheckPurchase checkPurchase = new CheckPurchase();
            string result = checkPurchase.Check(creditNo);
            return result;
        }
        // Place Order - End

        public string saveOrderToDatabase(long productIDX, string productTypeX, string productNameX, double productPriceX, int quantityX,DateTime orderDateX)
        {
            long customerIDX = customer.CustomerID;
            string res = ServerOperations.placeOrder(customerIDX, productIDX, productTypeX, productNameX, productPriceX, quantityX, orderDateX);
            return res;
        }

        public string completeOrder()
        {
            sendInvoidcebyEmail();
            sendInvoicebySMS();
            string res = "Order Completed.";
            return res;
        }

        // Clear Shopping Cart Items - Start
        public void cancelOrder()
        {
            listItems.Clear();
        }
        // Clear Shopping Cart Items - End

        // Send Invoice By Email - Start
        private void sendInvoidcebyEmail()
        {
            PurchaseMail mail = new PurchaseMail();
            mail.setMail(listItems);
            mail.sendMail();
        }
        // Send Invoice By Email - End

        // Send Invoice By SMS - Start
        private void sendInvoicebySMS()
        {
            PuchaseSms sms = new PuchaseSms();
            String customerNo = "00000000"; //Should get customer no
            sms.setSms(customerNo);
            sms.sendSms();
        }
        // Send Invoice By SMS - End
    }
}