using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Ingredients
    {
        public string Name { get; set; }
        public int Quantity {  get; set; }

        public Ingredients(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
        public override string ToString()
        {

            return $"Ingredient: {Name}" ;
        }
    }
}
