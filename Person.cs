using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person() { }
        public Person(string Name, string Address) 
        {
            this.Name = Name;
            this.Address = Address;
        }
        
        public virtual string ToString()
        {
            //Console.WriteLine(Name);
            //Console.WriteLine(Address);
            return $"{Name} {Address}";
        }
    }
}
