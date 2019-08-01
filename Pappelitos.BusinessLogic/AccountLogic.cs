using System;
using Pappelitos.Domain;
using Pappelitos.BusinessLogic.Interface;
using Pappelitos.DataAccess.Interface;

namespace Pappelitos.BusinessLogic
{
    public class AccountLogic : IAccountLogic
    {
        private IRepository<Account> accountRepository;
        private IRepository<Player> playerRepository;
        private IRepository<Match> matchRepository;
        public AccountLogic(IRepository<Account> aAccountRepository, 
                            IRepository<Player> aPlayerRepository,
                            IRepository<Match> aMatchRepository)
        {
            this.accountRepository = aAccountRepository;
            this.playerRepository = aPlayerRepository;
            this.matchRepository = aMatchRepository;
        }
        public Account AddAccount(Account account)
        {
            accountRepository.Add(account);
            accountRepository.Save();
            return account;
        }

        public Account GetById(int id)
        {
            Account account = this.accountRepository.GetById(id);
            return account;
        }

        public void DeleteAccount(int id)
        {
            Account toDelete = accountRepository.GetById(id);
            accountRepository.Delete(toDelete);
            accountRepository.Save();
        }

        public Account UpdateAccount(Account account)
        {
            accountRepository.Update(account);
            accountRepository.Save();
            return account;
        }

        public void CreatePlayer(Account account, String name)
        {
            Player newPlayer = new Player(name);
            playerRepository.Add(newPlayer);
            playerRepository.Save();
            account.Players.Add(newPlayer);
            accountRepository.Update(account);
            accountRepository.Save();
        }

        public Match CreateMatch(Account account, Match newMatch)
        {
            account.Matches.Add(newMatch);
            accountRepository.Update(account);
            accountRepository.Save();
            return newMatch;
        }
    }
}
