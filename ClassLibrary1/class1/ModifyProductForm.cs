using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1.class1
{
    public class ModifyProductForm : Product
    {
        public ModifyProductForm(string name, decimal price, ProductType type) : base(name, price, type)
        {
            Name = name;
            Price = price;
            ProductType = type; 
            
        }
        public void Modify(string newName, decimal newPrice)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                Name = newName;
            }

            if (newPrice > 0)
            {
                Price = newPrice;
            }

            
        }
    }
}
