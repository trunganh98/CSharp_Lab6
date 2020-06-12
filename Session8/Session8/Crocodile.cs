using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Crocodile : ITerrestriaAnimal, IMarineAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The Crocodile eats flesh");
        }

        public void Swim()
        {
            Console.WriteLine("The Crocodile can swim four times faster than an Olympic swimmer");
        }

        public void Drink()
        {
            Console.WriteLine("Drinks fresh juice");
        }

        public void NewHabitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }

    }
}
