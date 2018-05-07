using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.InterfaceSegregationPrinciple.Refactored
{
    /// <summary>
    /// So we split the properties into 3 smaller interfaces
    /// The IProduct will serve as the common denominator of all our products, regardless of its type
    /// </summary>
    public interface IProduct
    {
        int Id { get; set; }
        double Weight { get; set; }
        int Stock { get; set; }
    }
}
