using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConAbstractClass2;

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
            //Scooter scooter = new Scooter();
            //scooter.ScooterType();

            //Car car = new Car();
            //car.CarType();

            // Polymorphism
            //Calculator calc = new Calculator();
            //calc.Sum();
            //calc.Sum(10, 20);
            //calc.Sum(45.12f, 234.123f);

            // Overriding
            BaseClass baseClass = new DerivedClass();
            baseClass.MyMethod();

            baseClass = new BaseClass();
            baseClass.MyMethod();
        }
    }
}
