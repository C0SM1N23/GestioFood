using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class ProductManager
    {
        private List<object> items = new List<object>();

        public ProductManager()
        {
        }

        public void AddItem(object item)
        {
            if (item is Person person)
            {
                items.Add(person);
            }
        }
    }
    
}
