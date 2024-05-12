using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Customer : Person
    {
   
    
        public int LoyaltyPoints { get; set; }

        public Customer(int loyaltyPoints, string name, string adress, int telNumb) : base(name, adress, telNumb)
        {
            LoyaltyPoints = loyaltyPoints;
            Name = name;    
            Adress = adress;
            TelNumb = telNumb;  
        }
    }
}
