using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercise
{
    internal class Question5
    {
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Demo { 
            public static void OrderByEx1()
            {
                Pet[] pets = { new Pet { Name="Barley", Age=8 },
                       new Pet { Name="Boots", Age=4 },
                       new Pet { Name="Whiskers", Age=1 } };

                IEnumerable<Pet> query = pets.OrderBy(pet => pet.Age);

                foreach (var pet in query)
                    {
                        Console.WriteLine($"{pet.Name}, {pet.Age}");
                    }
            }

            static void Main(string[] args)
            {
                OrderByEx1();
            }
        }
    }
}
