using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookStore
{
    class Customer : User
    {
        private static Customer customer; // Singleton Class Object.
        private static List<Customer> myInformations; // Loged In Customer/Admin Informations.
        private static List<Orders> myOrders; // Loged In Customer/Admin Orders.

        // Default Constructor - Start
        private Customer()
        {

        }
        // Default Constructor - End

        // Singleton Patern Constructor - Start
        public static Customer CustomerX()
        {
            if (customer == null)
            {
                customer = new Customer();
                myInformations = new List<Customer>();
                myOrders = new List<Orders>();
            }
            return customer;
        }
        // Singleton Patern Constructor - End

        // Login Process - Start
        public string login(string usernameX, string passwordX)
        {
            string res = ServerOperations.login(usernameX, passwordX);
            if (res != "Your Account Still Waiting For Confirmation." && res != "Wrong Username or Password." && res != "Please Fill The All Spaces.")
            {
                myInformations = JsonConvert.DeserializeObject<List<Customer>>(res);

                CustomerID = myInformations[0].CustomerID;
                Name = myInformations[0].Name;
                Username = myInformations[0].Username;
                Email = myInformations[0].Email;
                Adress = myInformations[0].Adress;
                IsAdmin = myInformations[0].IsAdmin;
                AccountConfirmed = myInformations[0].AccountConfirmed;
                EmailConfirmed = myInformations[0].EmailConfirmed;

                res = "Customer Login Successful.";
                if (myInformations[0].IsAdmin == 1)
                {
                    res = "Admin Login Successful.";
                }
            }
            return res;
        }
        // Login Process - End

        // Customer Registeration - Start
        public string saveCustomer(string usernameX, string nameX, string emailX, string adressX, string passwordX)
        {
            string res = ServerOperations.saveCustomer(usernameX, nameX, emailX, adressX, passwordX);
            return res;
        }
        // Customer Registeration - End

        // Update Database - Start
        public string updateCustomer(string updateTypeX, List<Customer> x)
        {
            string customerIDX = x[0].CustomerID.ToString();
            string usernameX = x[0].Username;
            string nameX = x[0].Name;
            string emailX = x[0].Email;
            string adressX = x[0].Adress;
            string passwordX = x[0].Password;
            string isAdminX = x[0].IsAdmin.ToString();
            string accountConfirmedX = x[0].AccountConfirmed.ToString();
            string emailConfirmedX = x[0].EmailConfirmed.ToString();

            string res = ServerOperations.updateCustomer(updateTypeX, customerIDX, usernameX, nameX, emailX, adressX, passwordX, isAdminX, accountConfirmedX, emailConfirmedX);
            if (res != "Wrong Update Type Choice." && res != "User Doesnt Exists." && res != "Failed To Update." && res != "Please Fill The All Spaces.")
            {
                myInformations.Clear();
                myInformations = JsonConvert.DeserializeObject<List<Customer>>(res);

                CustomerID = myInformations[0].CustomerID;
                Name = myInformations[0].Name;
                Username = myInformations[0].Username;
                Email = myInformations[0].Email;
                Adress = myInformations[0].Adress;
                IsAdmin = myInformations[0].IsAdmin;
                AccountConfirmed = myInformations[0].AccountConfirmed;
                EmailConfirmed = myInformations[0].EmailConfirmed;

                res = "Update Successful.";
            }
            return res;
        }
        // Update Database - End

        // Print All Details Of Customer - Start
        public List<Customer> printCustomerDetails()
        {
            return myInformations;
        }
        // Print All Details Of Customer - End

        public void syncOrders()
        {
            string res = ServerOperations.listOrders(CustomerID);

            if (res != "No Order Exists." && res != "Please Fill The All Spaces.")
            {
                myOrders = JsonConvert.DeserializeObject<List<Orders>>(res);
            }
        }

        public List<Orders> listOrders()
        {
            return myOrders;
        }
    }
}