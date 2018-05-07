using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.SingleResponsibilityPrinciple.Service_Refactored
{
    public class InvitationService
    {
        UserNameService _userNameService;
        EmailService _emailService;
        string _host;
        int _port;
        public InvitationService(UserNameService userNameService, EmailService emailService, string server, int port)
        {
            _userNameService = userNameService;
            _emailService = emailService;
            _host = server;
            _port = port;
        }
        public void SendInvite(string email, string firstName, string lastName)
        {
            _userNameService.Validate(firstName, lastName);
            if (_emailService.Validate(email))
            {
                SmtpClient client = new SmtpClient(_host, _port);
                client.Send(new MailMessage("no-reply@gmail.com", email) { Subject = "Sending a test invite." });
            }
        }
    }
}
