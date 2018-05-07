using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.DependencyInversionPrinciple.Refactored
{
    public class UserManager
    {
        private readonly INotifier _myNotifier;
        public UserManager(INotifier myNotifier)
        {
            _myNotifier = myNotifier;
        }

        public string CreateUser(string userid, string password, string email)
        {
            //create user here
            return _myNotifier.Notify("User created successfully!");
        }

        public void ChangePassword(string userid, string oldpassword, string newpassword)
        {
            //change password here
            _myNotifier.Notify("Password changed successfully");
        }
    }
}
