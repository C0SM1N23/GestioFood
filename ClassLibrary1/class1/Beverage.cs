using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Beverage : Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Beverage(string name, decimal price) : base(name, price) 
        {
            Name = name;
            Price = price;
        }
    }
}
