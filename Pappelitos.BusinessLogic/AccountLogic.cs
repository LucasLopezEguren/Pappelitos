using System;
using Pappelitos.Domain;
using System.Collections.Generic;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        private IRepository<Account> accountRepository;
        public AccountLogic(IRepository<Account> repository)
        {
            this.accountRepository = repository;
        }
        public Account AddAccount(Account account)
        {
            accountRepository.Add(account);
            accountRepository.Save();
            return account;
        }
        public void DeleteAccount(int id)
        {
            Account toDelete = accountRepository.GetByID(id);
            accountRepository.Delete(toDelete);
            accountRepository.Save();
        }
        public Account UpdateAccount(Account account)
        {
            accountRepository.Update(account);
            accountRepository.Save();
            return account;
        }
        public void CreatePlayer (Account account, String name){
            Player newPlayer = new Player(name);
            account.Players.Add(newPlayer);
            accountRepository.Update(account);
            accountRepository.Save();
        }
        public Match CreateMatch (Account account, Match newMatch){
            account.Matches.Add(newMatch);
            accountRepository.Update(account);
            accountRepository.Save();
            return newMatch;
        }
    }
}
