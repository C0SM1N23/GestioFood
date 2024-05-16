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

        public Beverage(string name, decimal price,ProductType productType, int quantity) : base(name, price, productType)
        {
            Name = name;
            Price = price;
            Quantity = quantity;   
           
        }

        public Beverage(string name, decimal price, ProductType type) : base(name, price, type)
        {
        }
    }
}
