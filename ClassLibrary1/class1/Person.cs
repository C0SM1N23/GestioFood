using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.class1
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int TelNumb { get; set; }

        public Person(string name, string adress, int telNumb)
        {
            Name = name;
            Adress = adress;
            TelNumb = telNumb;
        }
    }
}
