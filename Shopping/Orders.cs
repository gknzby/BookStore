using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Orders
    {
        private long productID;
        private string productType;
        private string productName;
        private double productPrice;
        private int quantity;
        private DateTime orderDate;

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
        public string ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
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
        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }
    }
}