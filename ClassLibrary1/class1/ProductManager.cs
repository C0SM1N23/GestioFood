using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        
        public void AddProduct(Product product)
        {
            if(product is Food food)
            {
                products.Add(food);
            }
            else if (product is Beverage beverage)
            { 
                products.Add(beverage); 
            }
                

        } 
    }
}
