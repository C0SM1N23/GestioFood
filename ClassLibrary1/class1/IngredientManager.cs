using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class IngredientManager
    {
        public List<string> Ingredients { get; set; }

        public IngredientManager(List<string> ingredients)
        {
            Ingredients = ingredients;
        }

        public void AddIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public void IncreaseStock(string ingredient, int quantity)
        {
            int index = Ingredients.IndexOf(ingredient);
            if (index != -1)
            {
                Ingredients[index] += quantity;
            }
        }

    }
}