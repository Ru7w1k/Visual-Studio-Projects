using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    class CityMaster : AreaMaster
    {
        public override areaType AreaType
        {
            get
            {
                return areaType.City;
            }

            set
            {
                base.AreaType = areaType.City;
            }
        }

        public CityMaster() : base()
        {

        }

        public CityMaster(int id, string code, string name, string description, areaType areatype, int areaId) : base(id, code, name, description, areatype, areaId)
        {

        }
    }
}
