using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web;
using MVCSendGripJenkinsProDev.Controllers;
using System.Web.Http;
using System.Net.Http;
using MVCSendGripJenkinsProDev.Models;
using System.Net;

namespace MVCSendGridJenkinsProDev.Tests
{
    [TestClass]
    public class NegativeTests
    {
        Email _email;

        [TestInitialize]
        public void SetupTest()
        {
            _email = new Email
            {

            };
        }

        [TestMethod]
        public void SubmitController_GivenEmptyObject_Return400()
        {
            SubmitController controller = new SubmitController();
            Email testEmail = _email;

            HttpResponseMessage result = controller.Post(_email);

            Assert.IsTrue(result.StatusCode == HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void SubmitController_GivenNullToEmailAddress_Return400()
        {
            SubmitController Controller = new SubmitController();
            Email testEmail = _email;

            testEmail.Subject = string.Empty;
            testEmail.DeliveryType = "Random";

            HttpResponseMessage result = Controller.Post(testEmail);

            Assert.IsTrue(result.StatusCode == HttpStatusCode.BadRequest);
            
        }


        [TestMethod]
        public void SubmitController_GivenEmtpySubject_Return400()
        {
            SubmitController Controller = new SubmitController();
            Email testEmail = _email;

            testEmail.Subject = string.Empty;
            testEmail.DeliveryType = "Random";
            testEmail.To = "test@test.com";

            HttpResponseMessage result = Controller.Post(testEmail);

            Assert.IsTrue(result.StatusCode == HttpStatusCode.BadRequest);
        }

        [TestMethod]
        public void SubmitController_GivenRandomDeliveryType_Return501()
        {
            SubmitController Controller = new SubmitController();
            Email testEmail = _email;

            testEmail.DeliveryType = "Random";
            testEmail.Subject = "xxx";
            testEmail.To = "test@test.com";

            HttpResponseMessage result = Controller.Post(testEmail);

            Assert.IsTrue(result.StatusCode == HttpStatusCode.NotImplemented);
        }




        [TestCleanup]
        public void CleanUp()
        {
            _email = null;
        }
    }

    [TestClass]
    public class PositiveTests
    {

    }

    
}
