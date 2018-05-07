using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.OpenClosedPrinciple
{
    /// <summary>
    /// This violates the Open Closed Principle
    /// if we need to add additional type, we need to modify the method below to accomodate new shapes
    /// In essence, TotalAreaCalculator is not closed for modification, and isn't really open for extension 
    /// </summary>
    public class TotalAreaCalculator
    {
        public double Area(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    case Rectangle _:
                        var rectangle = (Rectangle)shape;
                        area += rectangle.Width * rectangle.Height;
                        break;
                    //if we need to add another type, we need to add a new condition
                    case Circle _:
                        var circle = (Circle)shape;
                        area += (circle.Radius * circle.Radius) * Math.PI;
                        break;
                }
            }
            return area;
        }
    }
}
