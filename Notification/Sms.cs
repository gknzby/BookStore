using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    // Sms Gondermek Parali Oldugu Icin Sadece Gonderme Kismina Kadar Yapilmis Servera Baglanip Gonderme Islemi Eklenmemistir.
    abstract class Sms
    {
        protected string customerNo;
        protected string content;

        public abstract void sendSms();
    }
}