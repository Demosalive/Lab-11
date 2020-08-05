using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> everyone = new List<Person>();
            everyone.Add(new Person { Name = "John", Address = "1234" });
            everyone.Add(new Person { Name = "phil", Address = "43234" });
            everyone.Add(new Person { Name = "steve", Address = "21341" });

            everyone.Add(new Staff { Name = "larry", Address = "12345456", Pay = 12.50, School = "GC" });

            for (int i = 0; i < everyone.Count; i++)
            {
                Console.WriteLine(everyone[i].ToString());
            }

            
           // Console.WriteLine(everyone[0].Name);
          //  Console.WriteLine(everyone[0].Address);

            //Person person2 = new Person("Jackie Jones", "43452 Coulda Dr");
            //everyone.Add(person2);
            //Person[] everyone1 = new Person[1];
            //everyone1[0] = person2;
           
        }
    }
}
