using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Food : Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
      
        public List<Ingredients> Ingredients { get; set; }

        public Food(string name, decimal price, List<Ingredients> ingredients) : base(name, price)
        {
            Name = name;
            Price = price;
           
            Ingredients = ingredients;
            
        }
    }
}
