using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Beverage : Product
    {
        public int Quantity { get; set; }

        public Beverage(string name, decimal price, int quantity) : base(name, price)
        {
            Name = name;
            Price = price;
            Quantity = quantity;    
        }
    }
}
