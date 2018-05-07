using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.Refactored
{
    public class BaseballCap: IProduct, IHat
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int HatSize { get; set; }
    }
}
