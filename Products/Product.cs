using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    abstract class Product
    {
        private long id;
        private string name;
        private double price;
        private string productType;
        private string coverPagePicture;

        // Product ID - Getter / Setter
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        // Product Name - Getter / Setter
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // Product Price - Getter / Setter
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
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
            }
        }
        // Product Cover Page Picture - Getter / Setter
        public string CoverPagePicture
        {
            get
            {
                return coverPagePicture;
            }
            set
            {
                coverPagePicture = value;
            }
        }
        // Abstract PrintProperties Definition
        public abstract string[] printProperties();
    }
}