using System;
using Pappelitos.Domain;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pappelitos.DataAccess
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository(DbContext context)
        {
            Context = context;
        }

        public override void Add(Account account){
            Context.Set<Account>().Add(account);
            Context.SaveChanges();
        } 

        public override Account GetByName(String name){
            Account toReturn = Context.Set<Account>().Where(x => x.Username == name).FirstOrDefault();
            return toReturn;
        } 

        public override Account GetByID(int id){
            Account toReturn = Context.Set<Account>().Where(x => x.Id == id).FirstOrDefault();
            return toReturn;
        } 

        public override IEnumerable<Account> GetAll(){
            List<Account> toReturn = Context.Set<Account>().ToList();
            return toReturn;
        }

        public override bool Has(Account account){
            return Context.Set<Account>().Contains(account);
;
        }
    }
}
