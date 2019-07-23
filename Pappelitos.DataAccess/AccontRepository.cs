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

        } 

        public override Account GetByName(String name){
            Account toReturn = null;
            return toReturn;
        } 

        public override Account GetByID(int id){
            Account toReturn = null;
            return toReturn;
        } 

        public override IEnumerable<Account> GetAll(){
            List<Account> toReturn = null;
            return toReturn;
        }

        public override bool Has(Account account){
            return false;
        }
    }
}
