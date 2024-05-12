using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Employee : Person
    {
      
        public string Role { get; set; }
        

        public Employee(string name, string address, int telNumb, string role) : base (name, address, telNumb )
        {
            Name = name;
            Adress = address;
            TelNumb = telNumb;
            Role = role;
        }
    }
}
