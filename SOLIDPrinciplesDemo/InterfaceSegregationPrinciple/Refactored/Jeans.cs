using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.Refactored;using IProduct = SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.IProduct;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.Refactored
{
    public class Jeans : IProduct, IPants
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }
        public int Inseam { get; set; }
        public int WaistSize { get; set; }
    }
}
