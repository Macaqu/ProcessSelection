using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intersection.Intersection.Casting
{
    public class ColdDieCasting : ICasting
    {

        public string Name
        {
            get { return CastingTypeHelper.GetCastingTypeName(Type); ; }
        }

        public CastingType Type
        {
            get { return CastingType.ColdDieCasting; }
        }
    }
}
