using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Dog : IAnimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }

        void IAnimal.AnimalType()
        {
            
        }

        void IAnimal.Drink()
        {
            throw new NotImplementedException();
        }

        void IAnimal.Habitat()
        {
            
        }
    }
}
