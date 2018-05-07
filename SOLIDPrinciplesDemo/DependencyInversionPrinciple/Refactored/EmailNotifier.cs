using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.DependencyInversionPrinciple.Refactored
{
    public class EmailNotifier : INotifier
    {
        public string EmailAddress { get; set; }
        public string Notify(string message)
        {
            //send email here
            return "Email Notifier: " + message;
        }
    }
}
