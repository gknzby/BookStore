using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class PurchaseMail : Mail
    {
        List<ItemToPurchase> items;

        public void setMail(List<ItemToPurchase> item)
        {
            items = item;
        }

        public override void sendMail()
        {
            double total = 0;
            subject = "Kültür Mantarı";
            content = "Thank you for chosing us! You can see the items you bought, below. \n";
            for(int i = 0; i < items.Count; i++)
            {
                total += items[i].Quantity * items[i].Product.Price;
                content += items[i].Quantity.ToString() + " pcs " + items[i].Product.Name.ToString() + " : " + (items[i].Quantity * items[i].Product.Price).ToString() + "\n";
            }
            content += "Total : " + total.ToString();
            send(customer.Email, subject, content);
        }
    }
}