using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignments
{
    public enum VehicleType
    {
        TwoWheeler,
        FourWheeler
    }

    public class Vehicle
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual VehicleType Type { get; set; }

        public virtual void GetDetails()
        {
            Console.WriteLine("This is a vehicle Class");
        }
    }

    public class TwoWheeler : Vehicle
    {
        public override VehicleType Type { get { return VehicleType.TwoWheeler; } }

        public string TwoWheelerProperty { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("This is a Two Wheeler");
            Console.WriteLine("Name: {0}\nNumber: {1}\nType: {2}", Name, Number, Type.ToString());
        }


    }

    public class FourWheeler : Vehicle
    {
        public override VehicleType Type { get { return VehicleType.FourWheeler; } }

        public string FourWheelerProperty { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("This is a Four Wheeler");
            Console.WriteLine("Name: {0}\nNumber: {1}\nType: {2}", Name, Number, Type.ToString());
        }

    }
}
