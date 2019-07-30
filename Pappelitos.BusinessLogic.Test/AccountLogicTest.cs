using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pappelitos.BusinessLogic;
using Pappelitos.Domain;
using Moq;
using Pappelitos.DataAccess.Interface;
using Pappelitos.BusinessLogic.Interface;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Pappelitos.BusinessLogic.Test
{
    [TestClass]
    public class AccountLogicTest
    {
       [TestMethod]
        public void CreateAccountTest()
        {
            var account = new Account
            {
                Username = "TestAccount"
            };
            var mock = new Mock<IRepository<Account>>(MockBehavior.Strict);
            mock.Setup(m => m.Add(It.IsAny<Account>()));
            mock.Setup(m => m.Save());

            var mockPlayer = new Mock<IRepository<Player>>(MockBehavior.Strict);
            mockPlayer.Setup(m => m.Save());

            IAccountLogic accountLogic = new AccountLogic(mock.Object, mockPlayer.Object);
            var result = accountLogic.AddAccount(account);
            
            mock.VerifyAll();
            Assert.AreEqual(account.Username, result.Username);

        }
    }
}
