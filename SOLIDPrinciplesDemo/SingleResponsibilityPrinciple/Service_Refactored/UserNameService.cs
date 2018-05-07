using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.SingleResponsibilityPrinciple.Service_Refactored
{
    public class UserNameService
    {
        public bool Validate(string firstName, string lastName)
        {
            if (!String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName))
            {
                return true;
            }
            else
                return false;
        }
    }
}
