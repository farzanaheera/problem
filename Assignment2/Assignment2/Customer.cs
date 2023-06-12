using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
  
        public class Customer
        {
        protected  readonly string _name;
        /*
        public Customer(string name)
            {
                _name = name;
            }
       */
           private void ChangeName(string name)      //cannot change _name bcz its readonly
              {
                  _name = name;
              }
           

            protected string GenerateCustomerId(string phoneNumber)
            {
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    return phoneNumber;
                }
                else
                    return "";
            }

            public static void PayBill(double amount)
            {
                double temp = amount;
            }
        }
    }

