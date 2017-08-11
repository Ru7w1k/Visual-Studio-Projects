using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter String: ");
            //string str = Console.ReadLine();

            //Console.WriteLine(str.ToWordUpperCase());

            Vehicle objVeh1 = new TwoWheeler
            {
                Name = "Activa",
                Number = "MH12 AA1111",
                TwoWheelerProperty = "test test"
            };

            Vehicle objVeh2 = new FourWheeler
            {
                Name = "Baleno",
                Number = "AB12 CD1234",
                FourWheelerProperty = "test test test test"
            };

            Print(objVeh1);
            Console.WriteLine();
            Print(objVeh2);
            Console.WriteLine();

            IVehicle twoWheels = new TwoWheels
            {
                Name = "Test",
                Number = "AB12 CD1234",
                TwoWheelerProperty = "test test"
            };

            IVehicle fourWheels = new FourWheels
            {
                Name = "Test4",
                Number = "XY99 ZZ0000",
                FourWheelerProperty = "test test test test"
            };

            Print(twoWheels);
            Console.WriteLine();
            Print(fourWheels);

            Console.WriteLine();
            Console.WriteLine("Area of Rectangle: " + Calculator.AreaOfRectangle(45.213, 321.654));

            Console.Read();
        }

        public static void Print(Vehicle vehicle)
        {
            vehicle.GetDetails();
            Console.WriteLine("Special Property: ");
            if(vehicle is TwoWheeler)
            {
                Console.WriteLine(((TwoWheeler)vehicle).TwoWheelerProperty);
            }
            if (vehicle is FourWheeler)
            {
                Console.WriteLine(((FourWheeler)vehicle).FourWheelerProperty);
            }
        }

        public static void Print(IVehicle vehicle)
        {
            vehicle.GetDetails();
            Console.WriteLine("Special Property: ");
            if (vehicle is TwoWheels)
            {
                Console.WriteLine(((TwoWheels)vehicle).TwoWheelerProperty);
            }
            if (vehicle is FourWheels)
            {
                Console.WriteLine(((FourWheels)vehicle).FourWheelerProperty);
            }
        }
    }
}
