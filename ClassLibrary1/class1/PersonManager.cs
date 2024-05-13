using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class PersonManager
    {
        private List<Person> items = new List<Person>();

        public PersonManager()
        {
        }

        public void AddItem(Person item)
        {
            if (item is Person person)
            {
                items.Add(person);
            }
        }
    }
    
}
