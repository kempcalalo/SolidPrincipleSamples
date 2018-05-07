using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.OpenClosedPrinciple.Refactored
{
    public class Triangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width * 0.5;
        }
    }
}
