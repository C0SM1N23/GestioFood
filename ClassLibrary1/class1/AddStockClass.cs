using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class AddStockClass
    {
       
        
            public string Ingredient { get; set; }
            public int CurrentQuantity { get; set; }

            public AddStock(string ingredient, int currentQuantity)
            {
                Ingredient = ingredient;
                CurrentQuantity = currentQuantity;
            }

            public void IncreaseStock(int amount)
            {
                CurrentQuantity += amount;
                
            }
        
    }
}
