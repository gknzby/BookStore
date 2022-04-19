using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ItemToPurchase
    {
        private Product product;
        private int quantity;

        // Product - Getter / Setter
        public Product Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
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
            }
        }

        // Add Items To Shopping Cart List - Start
        public ItemToPurchase(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        // Add Items To Shopping Cart List - End

        //////////////////////////////////////////////////////////////////// Asagisi Gereksiz Ise Sil
        /* 
        public string[] printProducts()
        {
            string[] temp = product.printProperties();
            Array.Resize<string>(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = quantity.ToString();
            return temp;
        }
        */
    }
}