using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    class DistrictMaster : AreaMaster
    {
        public override areaType AreaType
        {
            get
            {
                return areaType.District;
            }

            set
            {
                base.AreaType = areaType.District;
            }
        }

        public DistrictMaster() : base()
        {

        }

        public DistrictMaster(int id, string code, string name, string description, areaType areatype, int areaId) : base(id, code, name, description, areatype, areaId)
        {
            
        }
    }
}
