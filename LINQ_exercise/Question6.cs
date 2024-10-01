using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_exercise
{
    internal class Question6
    {
        class PetOwner
        {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }
        class Demo_ques6
        {
            public static void SelectManyEx3()
            {
                PetOwner[] petOwners = { new PetOwner { Name="Higa", Pets = new List<string>{ "Scruffy", "Sam" } },
                 new PetOwner { Name="Ashkenazi", Pets = new List<string>{ "Walker", "Sugar" } },
                 new PetOwner { Name="Price", Pets = new List<string>{ "Scratches", "Diesel" } },
                 new PetOwner { Name="Hines", Pets = new List<string>{ "Dusty" } } };

                var query = petOwners.SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName }).Where(ownerAndPet => ownerAndPet.petName.StartsWith("S")).Select(ownerAndPet =>
                new
                {
                    Owner = ownerAndPet.petOwner.Name,
                    Pet = ownerAndPet.petName
                });
                foreach (var petOwner in query)
                {
                    Console.WriteLine(petOwner);
                }
            }

            static void Main(string[] args)
            {
                SelectManyEx3();
            }
        }
    }
}
