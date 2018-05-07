using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.DependencyInversionPrinciple.Refactored
{
    public interface INotifier
    {
        string Notify(string message);
    }
}
