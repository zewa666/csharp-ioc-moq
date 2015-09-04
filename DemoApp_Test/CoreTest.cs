using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autofac.Extras.Moq;
using Moq;

namespace DemoApp_Test
{
    [TestClass]
    public class CoreTest
    {
        [TestInitialize]
        public void BeforeEach()
        {
            
        }

        [TestMethod]
        public void Should_Return_Registered_Person()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<DemoApp.MyService.ITheService>()
                    .Setup(srv => srv.RegisterPerson(It.IsAny<DemoApp.MyService.Person>()))
                    .Returns<DemoApp.MyService.Person>(p => "[MOCK] Successfully registered " + p.FirstName + " " + p.LastName);

                var sut = mock.Create<DemoApp.BusinessLogic.Core>();
                Assert.AreEqual("[MOCK] Successfully registered Vildan Softic", sut.Init());
            }
        }
    }
}
