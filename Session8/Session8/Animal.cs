using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    public abstract class Animal
    {
        //Non-abstract method implement ation 
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }
        //Abstract method declaration
        public abstract void AnimalSound();
        public abstract void Habitat();
    }

    interface IAnimal 
    {
        void AnimalType();
        void Habitat();
        void Drink();
    }

    interface ICarnivorous
    {
        void Eat();
    }

    interface IReptile : IAnimal, ICarnivorous
    {
        void NewHabitat();
    }



}
