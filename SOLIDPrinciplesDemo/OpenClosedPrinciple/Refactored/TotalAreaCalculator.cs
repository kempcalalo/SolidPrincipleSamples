using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.OpenClosedPrinciple.Refactored
{
    /// <summary>
    /// This will take in any type that is a subset of the type Shape. No need to modify the Area method below
    /// </summary>
    public class TotalAreaCalculator
    {
        public double Area(List<Shape> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }
    }
}
