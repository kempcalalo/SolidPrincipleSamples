using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.DependencyInversionPrinciple
{
    /// <summary>
    /// This is a violation of DIP. Currently we only have 1 way of sending a notification which is via email.
    /// If we wanted a new way i.e thru SMS, then we need to create a new class and instatiate that class inside UserManager
    /// Our high level module user manager, is dependent on a low level module EmailNotifier
    /// </summary>
    public class UserManager
    {
        private readonly EmailNotifier _notifier = new EmailNotifier();

        public void CreateUser(string userId, string password, string email)
        {
            //create user code here
            _notifier.Notify(email, "User created successfully.");
        }

        public void ChangePassword(string userId, string oldPassword, string newPassword, string email)
        {
            //change password code here
            _notifier.Notify(email, "Password changed successfully.");
        }
    }
}
