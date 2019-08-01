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
                Username = "TestAccount",
                Mail = "John@Bravo"
            };
            var mock = new Mock<IRepository<Account>>(MockBehavior.Strict);
            mock.Setup(m => m.Add(It.IsAny<Account>()));
            mock.Setup(m => m.Save());

            var mockPlayer = new Mock<IRepository<Player>>(MockBehavior.Strict);
            mockPlayer.Setup(m => m.Save());

            var mockMatch = new Mock<IRepository<Pappelitos.Domain.Match>>(MockBehavior.Strict);
            mockMatch.Setup(m => m.Save());

            IAccountLogic accountLogic = new AccountLogic(mock.Object, mockPlayer.Object, mockMatch.Object);
            var result = accountLogic.AddAccount(account);

            mock.VerifyAll();
            Assert.AreEqual(account.Username, result.Username);
        }

        [TestMethod]
        public void GetUserById()
        {
            var account = new Account
            {
                Id = 123,
                Username = "Username",
                Mail = "John@Bravo"
            };

            var mock = new Mock<IRepository<Account>>();
            mock.Setup(m => m.GetById(account.Id)).Returns(account);

            var mockPlayer = new Mock<IRepository<Player>>(MockBehavior.Strict);
            mockPlayer.Setup(m => m.Save());

            var mockMatch = new Mock<IRepository<Pappelitos.Domain.Match>>(MockBehavior.Strict);
            mockMatch.Setup(m => m.Save());

            IAccountLogic accountLogic = new AccountLogic(mock.Object, mockPlayer.Object, mockMatch.Object);

            Account result = accountLogic.GetById(account.Id);

            mock.VerifyAll();
            Assert.AreEqual(result.Id, account.Id);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            var account = new Account
            {
                Id = 123,
                Username = "Username",
                Mail = "John@Bravo"
            };
            
            var mock = new Mock<IRepository<Account>>();
            mock.Setup(m => m.Update(It.IsAny<Account>()));
            mock.Setup(m => m.Save());

            var mockPlayer = new Mock<IRepository<Player>>(MockBehavior.Strict);
            mockPlayer.Setup(m => m.Save());

            var mockMatch = new Mock<IRepository<Pappelitos.Domain.Match>>(MockBehavior.Strict);
            mockMatch.Setup(m => m.Save());

            IAccountLogic accountLogic = new AccountLogic(mock.Object, mockPlayer.Object, mockMatch.Object);

            account.Username = "NewUsername";
            Account result = accountLogic.UpdateAccount(account);

            mock.VerifyAll();
            Assert.AreEqual(result.Username, "NewUsername");
        }
    }
}
