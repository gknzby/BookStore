using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    // Sms Gondermek Parali Oldugu Icin Sadece Gonderme Kismina Kadar Yapilmis Servera Baglanip Gonderme Islemi Eklenmemistir.
    class PuchaseSms : Sms
    {
        public void setSms(string customerNo)
        {
            this.customerNo = customerNo;
        }

        public override void sendSms()
        {
            content = "Thank you for shopping us. We sent you an purchase informatin mail.";
            string[] data = { customerNo, content };
        }
    }
}