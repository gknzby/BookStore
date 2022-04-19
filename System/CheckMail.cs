using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class CheckMail
    {
        Customer customer = Customer.CustomerX();

        public bool IsMailConfirmed()
        {
            if (customer.EmailConfirmed == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}