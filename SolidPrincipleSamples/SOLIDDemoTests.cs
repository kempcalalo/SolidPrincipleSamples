using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Srp = SOLIDPrinciplesDemo.SingleResponsibilityPrinciple;
using SOLIDPrinciplesDemo.SingleResponsibilityPrinciple.Service_Refactored;

namespace SolidPrincipleSamplesTest
{
    [TestClass]
    public class SOLIDDemoTests
    {
        #region SingleResponsibiltyPrinciple
        [TestMethod]
        public void SendInvite_SentSuccessfullyWithoutExceptions()
        {
            //This is the violation of SRP.

            //arrange
            Srp.InvitationService myInvitationService = new Srp.InvitationService();

            //act
            myInvitationService.SendInvite("test@gmail.com", "Thanos", "Gamora");
        }

        [TestMethod]
        public void Validate_EmailAddress_ReturnTrue()
        {
            //arrange
            EmailService myEmailService = new EmailService();
            string emailAddress = "valid@email.com";

            //act
            bool isValidEmail = myEmailService.Validate(emailAddress);

            //assert
            Assert.IsTrue(isValidEmail);
        }

        [TestMethod]
        public void Validate_UserName_ReturnTrue()
        {
            //arrange
            UserNameService myUserNameService = new UserNameService();
            string firstName = "John";
            string lastName = "Smith";

            //act
            bool isValidUserName = myUserNameService.Validate(firstName, lastName);

            //assert
            Assert.IsTrue(isValidUserName);
        }

        [TestMethod]
        public void SendInvite_SendSuccessfullyWihoutExceptions_Refactored()
        {
            //arrange
            UserNameService myUserNameService = new UserNameService();
            EmailService myEmailService = new EmailService();
            string host = "localhost";
            int port = 25;
            InvitationService myInvitationService = new InvitationService(myUserNameService, myEmailService, host, port);
            string email = "test@myEmail.com";
            string firstName = "John";
            string lastName = "Smith";
            //act
            myInvitationService.SendInvite(email, firstName, lastName);

        }
        #endregion

        #region OpenClosedPrinciple
        #endregion
    }
}
