using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple
{
    /// <summary>
    /// Now this violates ISP since we have methods that we must implement but we will not be using.
    /// </summary>
    public class BaseballCap : IProduct
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public int Stock { get; set; }

        public int Inseam
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int WaistSize
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
    }
}
