using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Class
            //Dog dog = new Dog();
            //AbstractClass thePet = dog;

            //thePet.Eat();
            //dog.Sound();

            //Console.Read();

            // Inheritance Class
            Scooter scooter = new Scooter();
            scooter.ScooterType();

            Car car = new Car();
            car.CarType();
        }
    }
}
