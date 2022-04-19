using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class CheckCard
    {
        public bool PaymentOk(string creditNo)
        {
            if(creditNo.Length == 16)
            {                
                if (Payment(creditNo))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool Payment(string creditNo)
        {
            // Checks Credit Card Is Valid Or Not.Since We Cant Do That It Always Returns True. 
            return true;
        }
    }
}