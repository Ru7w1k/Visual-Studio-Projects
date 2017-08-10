using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProblem
{
    class StateMaster : AreaMaster
    {
        public override areaType AreaType
        {
            get
            {
                return areaType.State;
            }

            set
            {
                base.AreaType = areaType.State;
            }
        }

        public StateMaster() : base()
        {

        }

        public StateMaster(int id, string code, string name, string description, areaType areatype, int areaId) : base(id, code, name, description, areatype, areaId)
        {

        }
    }
}
