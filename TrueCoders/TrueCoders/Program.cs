using System;
using System.Collections.Generic;
namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tanner = new People();
            var Micheal = new People();
            var Timothy = new People();
            var Charlie = new People();

            Tanner.Age = 20;
            Tanner.FirstName = "Tanner";
            Tanner.LastName = "Riddle";
            Tanner.HairColor = "Brown";

            Micheal.Age = 32;
            Micheal.FirstName = "Micheal";
            Micheal.LastName = "Doyle";
            Micheal.HairColor = "Black";

            Timothy.Age = 19;
            Timothy.FirstName = "Timothy";
            Timothy.LastName = "Tidwell";
            Timothy.HairColor = "Brown";

            Charlie.Age = 25;
            Charlie.FirstName = "Charlie";
            Charlie.LastName = "Doyle";
            Charlie.HairColor = "Black";

            List<People> trueCoders = new List<People>();
            trueCoders.Add(Timothy);
            trueCoders.Add(Micheal);
            trueCoders.Add(Tanner);
            trueCoders.Add(Charlie);

            foreach (People person in trueCoders)
            {
                Console.WriteLine($"Name:{person.FirstName} {person.LastName}, Age:{person.Age}, Hair Color:{person.HairColor}");
            }
        }
    }
}
