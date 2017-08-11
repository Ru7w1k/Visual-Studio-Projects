using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignments
{
    public interface IVehicle
    {
        void GetDetails();
    }

    public class TwoWheels : IVehicle
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public VehicleType Type { get { return VehicleType.TwoWheeler; } }
        public string TwoWheelerProperty { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("This is a Two Wheeler");
            Console.WriteLine("Name: {0}\nNumber: {1}\nType: {2}", Name, Number, Type.ToString());
        }
    }

    public class FourWheels : IVehicle
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public VehicleType Type { get { return VehicleType.FourWheeler; } }
        public string FourWheelerProperty { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("This is a Four Wheeler");
            Console.WriteLine("Name: {0}\nNumber: {1}\nType: {2}", Name, Number, Type.ToString());
        }
    }

}
