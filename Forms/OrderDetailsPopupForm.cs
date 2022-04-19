using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class OrderDetailsPopupForm : Form
    {
        Customer customer = Customer.CustomerX();
        List<Orders> myOrders;
        int firstIndex = -1;
        int lastIndex = -1;

        public OrderDetailsPopupForm()
        {
            InitializeComponent();
        }

        public OrderDetailsPopupForm(int first, int last,string orderDate)
        {
            InitializeComponent();
            firstIndex = first;
            lastIndex = last;
            lblHeader.Text = "Order Date: " + orderDate;
        }

        private void OrderDetailsPopupForm_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ServerOperations.saveButtonClick(customer.Username, "OrderDetailsPopupForm - btnExit");
            this.Close();
        }

        private void populateItems()
        {
            flwLytPnlOrderDetails.Controls.Clear();
            myOrders = customer.listOrders();

            OrderDetailsListItem[] orderDetailsListItem = new OrderDetailsListItem[lastIndex - firstIndex + 1];

            for (int i = 0; i < orderDetailsListItem.Length; i++)
            {
                orderDetailsListItem[i] = new OrderDetailsListItem();
                orderDetailsListItem[i].ProductName = myOrders[firstIndex + i].ProductName;
                orderDetailsListItem[i].ProductType = myOrders[firstIndex + i].ProductType;
                orderDetailsListItem[i].Quantity = myOrders[firstIndex + i].Quantity;
                orderDetailsListItem[i].Price = myOrders[firstIndex + i].ProductPrice;

                flwLytPnlOrderDetails.Controls.Add(orderDetailsListItem[i]);
            }
        }
    }
}