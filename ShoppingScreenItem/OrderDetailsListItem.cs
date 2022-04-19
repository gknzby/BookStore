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
    public partial class OrderDetailsListItem : UserControl
    {
        private string productName;
        private string productType;
        private int quantity;
        private double price;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                lblProductName.Text = "Product Name: " + value;
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
                lblProductType.Text = "Product Type: " + value;
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
                lblQuantity.Text = "Quantity: " + value.ToString();
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                lblProductPrice.Text = "Price: " + value.ToString("F", CultureInfo.InvariantCulture) + " TL";
            }
        }

        public OrderDetailsListItem()
        {
            InitializeComponent();
        }
    }
}