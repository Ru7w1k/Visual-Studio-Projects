using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    public enum areaType
    {
        Country,
        State,
        City,
        District
    }

    public class AreaMaster
    {
        static protected List<AreaMaster> AreaCollection = new List<AreaMaster>();
        
        //Properties
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual areaType AreaType { get; set; }
        public int AreaID { get; set; }

        // Default Constructor
        public AreaMaster()
        {
            
        }

        // Parameterized Constructor
        public AreaMaster(int id, string code, string name, string description, areaType areatype, int areaId) 
        {
            ID = id;
            Code = code;
            Name = name;
            Description = description;
            AreaType = areatype;
            AreaID = areaId;         
        }

        public static void AddToCollection(AreaMaster areaMaster)
        {
            AreaCollection.Add(areaMaster);
        }

        public static List<AreaMaster> GetCollection()
        {
            return AreaCollection;
        }

        public AreaMaster GetAreaMasterByCity(string city)
        {
            foreach (var areaMaster in AreaCollection.Where(area => area.AreaType == areaType.City))
            {
                if(string.Equals(areaMaster.Name, city))
                {
                    return areaMaster;
                }
            }
            return null;
        }

        public AreaMaster GetAreaMasterByState(string state)
        {
            foreach (var areaMaster in AreaCollection.Where(area => area.AreaType == areaType.State))
            {
                if (string.Equals(areaMaster.Name, state))
                {
                    return areaMaster;
                }
            }
            return null;
        }

        public AreaMaster GetAreaMasterByCountry(string country)
        {
            foreach (var areaMaster in AreaCollection.Where(area => area.AreaType == areaType.Country))
            {
                if (string.Equals(areaMaster.Name, country))
                {
                    return areaMaster;
                }
            }
            return null;
        }

        public AreaMaster GetAreaMasterById(int id)
        {
            foreach (var areaMaster in AreaCollection)
            {
                if (areaMaster.ID == id)
                {
                    return areaMaster;
                }
            }
            return null;
        }



        public override string ToString()
        {
            return string.Format("ID: {0}\nCode: {1}\nName: {2}\nDesc: {3}\nAreaType: {4}\nAreaID: {5}", ID, Code, Name, Description, AreaType, AreaID);
        }

    }


}
