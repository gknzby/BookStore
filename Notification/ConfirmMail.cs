using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ConfirmMail : Mail
    {
        private int confirmationCode;

        // ConfirmationCode - Getter
        public int ConfirmationCode
        {
            get
            {
                return confirmationCode;
            }
        }

        public void setMail()
        {
            Random random = new Random();
            confirmationCode = random.Next(1000, 9999);
        }

        public override void sendMail()
        {
            subject = "Confirm Mail";
            content = "Email confirm code is " + confirmationCode.ToString();
            send(customer.Email, subject, content);
        }
    }
}