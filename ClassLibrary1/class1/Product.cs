using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }

        protected Product(string name, decimal price, ProductType type)
        {
            Name = name;
            Price = price;
            ProductType = type;
        }
    }

}
