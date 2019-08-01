using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface IAccountLogic 
    {
        Account AddAccount(Account toAdd);
        Account UpdateAccount(Account toUpdate);
        void DeleteAccount(int id);
        void CreatePlayer (Account account, String name);
        Match CreateMatch (Account account, Match newMatch);
        Account GetById (int id);
    }
}
