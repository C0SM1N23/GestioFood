using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Food : Product
    {
        public List<Ingredients> Ingredients { get; set; }
        

       

        public Food(string name, decimal price, ProductType productType, List<Ingredients> ingredients) : base(name, price, productType )
        {
            Name = name;
            Price = price;
            Ingredients = ingredients;

            
            
        }
        public override string ToString()
        {
            return $"Name: {Name} ";
        }


    }
}
