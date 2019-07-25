using System;
using Pappelitos.Domain;

namespace Pappelitos.BusinessLogic.Interface
{
    public interface IAccountLogic 
    {
        Account AddAccount(Account toAdd);
        Account UpdateAccount(Account toUpdate);
        void DeleteAccount(int id);
    }
}
