using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet2();
            snippet5();
            snippet6();
            snippet8();
            snippet9();
            snippet10();
            snippet11();
            Console.ReadLine();
        }

        public static void Snippet2()
        {
            Lion objLion = new Lion();
            objLion.AnimalSound();
            objLion.Eat();
            objLion.Habitat();
        }

        public static void snippet5()
        {
            Dog objDog = new Dog();
            Console.WriteLine(objDog.GetType().Name);
            objDog.Habitat();
        }

        public static void snippet6()
        {
            Crocodile objCrocodile = new Crocodile();
            objCrocodile.Eat();
            objCrocodile.Swim();
        }

        public static void snippet8()
        {
            Crocodile objCrocodile = new Crocodile();
            Console.WriteLine(objCrocodile.GetType().Name);
            objCrocodile.NewHabitat();
            objCrocodile.Eat();
            objCrocodile.Drink();
        }

        public static void snippet9()
        {
            Sphere objSphere = new Sphere();
            objSphere.Radius = 7;
            objSphere.Area();
            Console.WriteLine("Area of Sphere: {0:F2}", objSphere._areaOfSphere);
        }

        public static void snippet10()
        {
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
            if (objRectangle is ICalculate)
            {
                Console.WriteLine("Area of rectangle: {0:F2}", objRectangle.Area());
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
        }

        public static void snippet11()
        {
            Employee objEmployee = new Employee();
            objEmployee.AcceptDetails(10, "Jack");
            IGet objGet = objEmployee as IGet;
            if (objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
        }
    }
}
