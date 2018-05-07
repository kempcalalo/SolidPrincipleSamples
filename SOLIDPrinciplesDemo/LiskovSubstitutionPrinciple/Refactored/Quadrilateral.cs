using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Refactored
{
    /// <summary>
    /// Here we have moved an abstract method Area in the Quadrilateral class and each subclass will give its own definition to the Area method.
    /// We also got rid of the AreaCalculator class since each shape will have their own area calculator
    /// </summary>
    public abstract class Quadrilateral
    {
        public abstract int Area();
    }
}
