using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple
{
    /// <summary>
    /// This interface below is a violation of ISP because IProduct represents properties that will not be applicable to other types of products
    /// The properties below only correspond to a pants.
    /// </summary>
    public interface IProduct
    {
        int Id { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
        int Inseam { get; set; }
        int WaistSize { get; set; }
    }
}
