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
            mock.Setup(m => m.Has(area)).Returns(false);
            mock.Setup(m => m.Save());

            IAccountLogic accountLogic = new AccountLogic(mock.Object);
            var result = accountLogic.AddArea(account);

            mock.VerifyAll();
            Assert.AreEqual(account.Username, result.Username);

        }
    }
}
