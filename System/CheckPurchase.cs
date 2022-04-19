using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class CheckPurchase
    {
        CheckCard checkCard = new CheckCard();
        CheckMail checkMail = new CheckMail();
        Customer customer = Customer.CustomerX();

        public string Check(string creditNo)
        {
            if (!checkMail.IsMailConfirmed())
            {
                return "Please confirm your email.";
            }
            if (!checkCard.PaymentOk(creditNo))
            {
                return "Please check your credit information.";
            }
            return "Payment succesfull! Thank you for shopping us.";
        }
    }
}