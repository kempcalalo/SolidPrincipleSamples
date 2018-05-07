using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.Refactored
{
    public interface IPants
    {
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }
}
