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
    public partial class OrdersListItem : UserControl
    {
        OrderDetailsPopupForm orderDetailsPopupForm;
        Customer customer = Customer.CustomerX();
        List<Orders> myOrders;

        private DateTime orderDate;
        private int totalQuantity;
        private double totalPrice;

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
                lblOrderDate.Text = "Order Date: " + value.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        public int TotalQuantity
        {
            get
            {
                return totalQuantity;
            }
            set
            {
                totalQuantity = value;
                lblTotalQuantity.Text = "Total Quantity: " + value.ToString();
            }
        }
        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                lblTotalPrice.Text = "Total Price: " + value.ToString("F", CultureInfo.InvariantCulture) + " TL";
            }
        }

        public OrdersListItem()
        {
            InitializeComponent();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "OrdersListItem - btnOrderDetails");

            myOrders = customer.listOrders();

            int firstIndex = -1;
            int lastIndex = -1;

            for (int i = 0; i < myOrders.Count; i++)
            {
                if (myOrders[i].OrderDate == OrderDate)
                {
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                        lastIndex = i;
                    }
                    else
                    {
                        lastIndex = i;
                    }
                }
            }

            if(orderDetailsPopupForm==null || orderDetailsPopupForm.IsDisposed)
            {
                orderDetailsPopupForm = new OrderDetailsPopupForm(firstIndex, lastIndex, OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            orderDetailsPopupForm.Show();
        }
    }
}