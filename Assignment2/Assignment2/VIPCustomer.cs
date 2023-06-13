using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2
{
    internal class VIPCustomer : Customer
    {
        /*   public string Type { get; set; } = string.Empty;
           public string name1 { get; set; }
           public VIPCustomer() { }

           public VIPCustomer(string name)
           {
               name1 = name;
           }

           public bool takeloan(double amount)
           {
               if (amount > 0)
               {
                   return true;
               }
               return false;public string type { get; set; }

           public VIPCustomer() { }

           public VIPCustomer(string name)
           {
               _name = name;
           }

           public bool takeloan(double amount);
           }
   */

        public string? type { get; set; }

        public VIPCustomer() { }
        /*public VIPCustomer(string name)
        {
            type = name;
        }*/

        public bool takeloan(double amount)
        {
            if (amount > 0)
            {
                return true;
            }
            return false;
        }



    }
}
