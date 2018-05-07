using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Refactored
{
    public class Square : Quadrilateral
    {
        public int Sides { get; set; }

        public override int Area()
        {
            return Sides * Sides;
        }
    }
}
