using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.SingleResponsibilityPrinciple
{
    /// <summary>
    ///  This is a sample of a violation of SRP
    ///  As we can see below, the method SendInvite does more than one thing
    /// </summary>
    public class InvitationService
    {
        public void SendInvite(string email, string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name is not valid!");
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }
            var client = new SmtpClient("localhost", 25);

            //Send the email
            //client.Send(new MailMessage("test@gmail.com", email) { Subject = "Sending a test invite." });
        }
    }
}
