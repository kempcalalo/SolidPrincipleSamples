using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLIDPrinciplesDemo.DependencyInversionPrinciple.Refactored;
using SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple;
using SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Refactored;
using SOLIDPrinciplesDemo.OpenClosedPrinciple.Refactored;
using Srp = SOLIDPrinciplesDemo.SingleResponsibilityPrinciple;
using SOLIDPrinciplesDemo.SingleResponsibilityPrinciple.Refactored;
using LSPRectangle = SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Rectangle;
using LSPSquare = SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Square;
using LSPRectangleRefactored = SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Refactored.Rectangle;
using LSPSquareRefactored = SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple.Refactored.Square;
using OCPRectangle = SOLIDPrinciplesDemo.OpenClosedPrinciple.Refactored.Rectangle;

namespace SolidPrinciplesTest
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

        [TestMethod]
        public void CalculateArea_AllShapes()
        {
            //This is the refactored implementation that follows the OCP.

            var myCalc = new TotalAreaCalculator();
            var myShapes = new List<Shape>
            {
                new Circle() {Radius = 4},
                new OCPRectangle() {Height = 4, Width = 3},
                new Triangle() {Height = 5, Width = 3}
            };

            Assert.AreEqual(69.77, Math.Round(myCalc.Area(myShapes), 2));

        }
        #endregion

        #region LiskovSubstitutionPrinciple
        [TestMethod]
        public void CalculateArea_RectanglefromSquare()
        {
            //This is a violation of LSP since square is not substituble for its parent rectangle. This test will fail.
            LSPRectangle newRectangle = new LSPSquare();
            newRectangle.Height = 4;
            newRectangle.Width = 6;
            var result = AreaCalculator.CalculateArea(newRectangle);
            Assert.AreEqual(24, result);
        }
        [TestMethod]
        public void CalculateArea_RectangleAndSquare()
        {
            //This is the refactored implementation that follows the LSP.

            var quadrilaterals = new List<Quadrilateral>{
                new LSPRectangleRefactored{ Height=4, Width=6 },
                new LSPSquareRefactored{ Sides=3 }
            };
            var areas = new List<int>();
            foreach (var quad in quadrilaterals)
            {
                if (quad.GetType() == typeof(LSPRectangleRefactored))
                {
                    areas.Add(((LSPRectangleRefactored)quad).Area());
                }
                if (quad.GetType() == typeof(LSPSquareRefactored))
                {
                    areas.Add(((LSPSquareRefactored)quad).Area());
                }

            }
            Assert.AreEqual(24, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
        #endregion

        #region DependencyInversionPrinciple

        [TestMethod]
        public void Notify_EmailNotifier()
        {
            //This is the refactored implementation that follows the DIP. We will plug in a notifier that we want on the UserManager
            var myEmailNotifier = new EmailNotifier();
            var myUserManager = new UserManager(myEmailNotifier);

            var output = myUserManager.CreateUser("1", "testpassword", "test@email.com");

            Assert.AreEqual(output, "Email Notifier: User created successfully!");

        }
        [TestMethod]
        public void Notify_SMSNotifier()
        {
            //This is the refactored implementation that follows the DIP. We will plug in a notifier that we want on the UserManager
            var mySmSNotifier = new SmsNotifier();
            var myUserManager = new UserManager(mySmSNotifier);

            var output = myUserManager.CreateUser("1", "testpassword", "test@email.com");

            Assert.AreEqual(output, "SMS Notifier: User created successfully!");

        }
        #endregion
    }
}
