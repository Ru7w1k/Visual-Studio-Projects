using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaMaster am = new AreaMaster();
            AreaMaster am1 = new CountryMaster(1, "IND", "India", "Anything", areaType.Country, 0);
            AreaMaster am2 = new StateMaster(2, "MH", "Maharashtra", "Anything", areaType.State, 1);
            AreaMaster am3 = new CityMaster(3, "PUN", "Pune", "Anything", areaType.City, 2);
            AreaMaster am4 = new DistrictMaster(4, "PD", "Pune District", "Anything", areaType.District, 3);

            AreaMaster.AddToCollection(am1);
            AreaMaster.AddToCollection(am2);
            AreaMaster.AddToCollection(am3);
            AreaMaster.AddToCollection(am4);
            
            foreach (var areaMaster in AreaMaster.GetCollection())
            {
                Console.WriteLine(areaMaster);
            }
            
            Console.WriteLine("What Do You Want To Search?\n1. City\n2. State\n3. Country");
            int num;
            while (true)
            {
                Console.WriteLine("Enter The Number");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    break;
                }
            }

            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter City: ");
                    string city = Console.ReadLine();
                    am = new AreaMaster();
                    am = am.GetAreaMasterByCity(city);
                    if(am != null)
                    {
                        AreaMaster tmp = am.GetAreaMasterById(am.AreaID);
                        Console.WriteLine("Name: {0}\nState: {1}\nCountry: {2}\nCode: {3}\nDescription: {4}", am.Name, tmp.Name, tmp.GetAreaMasterById(tmp.AreaID).Name, am.Code, am.Description);
                    }
                    else
                    {
                        Console.WriteLine("No City Found!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter State: ");
                    string state = Console.ReadLine();
                    am = new AreaMaster();
                    am = am.GetAreaMasterByState(state);
                    if (am != null)
                    {
                        Console.WriteLine("Name: {0}\nCountry: {1}\nCode: {2}\nDescription: {3}", am.Name, am.GetAreaMasterById(am.AreaID).Name, am.Code, am.Description);
                    }
                    else
                    {
                        Console.WriteLine("No State Found!");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter Country: ");
                    string country = Console.ReadLine();
                    am = new AreaMaster();
                    am = am.GetAreaMasterByCountry(country);
                    if (am != null)
                    {
                        Console.WriteLine("Name: {0}\nCode: {1}\nDescription: {2}", am.Name, am.Code, am.Description);
                    }
                    else
                    {
                        Console.WriteLine("No Country Found!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Number!");
                    break;
            }


            Console.Read();
        }
    }
}
