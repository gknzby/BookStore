using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    abstract class User
    {
        private long customerID;
        private string username;
        private string name;
        private string email;
        private string adress;
        private string password;
        private int isAdmin;
        private int accountConfirmed;
        private int emailConfirmed;

        // Customer ID - Getter / Setter
        public long CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        // Username - Getter / Setter
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        // Name - Getter / Setter
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        // Email - Getter / Setter
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        // Adress - Getter / Setter
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }
        // Password - Getter / Setter
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        // IsAdmin - Getter / Setter
        public int IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }
        // AccountConfirmed - Getter / Setter
        public int AccountConfirmed
        {
            get
            {
                return accountConfirmed;
            }
            set
            {
                accountConfirmed = value;
            }
        }
        // EmailConfirmed - Getter / Setter
        public int EmailConfirmed
        {
            get
            {
                return emailConfirmed;
            }
            set
            {
                emailConfirmed = value;
            }
        }
    }
}