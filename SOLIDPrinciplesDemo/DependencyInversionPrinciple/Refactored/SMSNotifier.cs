using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.DependencyInversionPrinciple.Refactored
{
    public class SmsNotifier : INotifier
    {
        public string MobileNumber { get; set; }
        public string Notify(string message)
        {
           //send SMS here
            return "SMS Notifier: " + message;
        }
    }
}
