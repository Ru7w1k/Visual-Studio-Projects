using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    class CountryMaster : AreaMaster
    {
        public override areaType AreaType
        {
            get
            {
                return areaType.Country;
            }

            set
            {
                base.AreaType = areaType.Country;
            }
        }

        public CountryMaster() : base()
        {

        }

        public CountryMaster(int id, string code, string name, string description, areaType areatype, int areaId) : base(id, code, name, description, areatype, areaId)
        {
            
        }

    }
}
