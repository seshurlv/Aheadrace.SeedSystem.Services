using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aheadrace.SeedSystem.Services.Controllers;
using Aheadrace.SeedSystem.Facade.Login;
using Aheadrace.SeedSystem.Business.Login;
using Aheadrace.SeedSystem.Repository.Login;

namespace Aheadrace.SeedSystem.Tests.Login
{
    [TestClass]
    public class LoginUnitTest
    {
        private LoginController _loginController;

        public LoginUnitTest()
        {
            _loginController = new LoginController(new LoginFacade(new LoginBLL(new LoginRepository())));
        }

        [TestMethod]
        public void GetServiceToken()
        {
            string username = "g1";
            string password = "p";
            var result = _loginController.GetServiceToken(username, password);
            Assert.IsNotNull(result);
        }        
    }
}
