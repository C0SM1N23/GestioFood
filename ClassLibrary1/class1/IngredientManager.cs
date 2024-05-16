using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class IngredientManager
    {
        public List<Ingredients> Ingredients { get; set; }

        public IngredientManager(List<Ingredients> ingredients)
        {
            Ingredients = ingredients;
        }

        public IngredientManager()
        {
        }

        public void AddIngredient(Ingredients ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void AddStock(Ingredients ingredient, int quantity)
        {
            foreach(Ingredients i in Ingredients)
            {
                if(i== ingredient)
                {
                    ingredient.Quantity += quantity;
                }
            }
        }
        public List<Ingredients> getIngredients()
        {
            return Ingredients;
        }

    }
}