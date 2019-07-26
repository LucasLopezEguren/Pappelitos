using System;
using Pappelitos.Domain;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pappelitos.DataAccess
{
    public class MatchRepository : BaseRepository<Match>
    {
        public MatchRepository(DbContext context)
        {
            Context = context;
        }

        public override void Add(Match match){
            Context.Set<Match>().Add(match);
            Context.SaveChanges();
        } 

        public override Match GetByName(String name){
            throw new NotImplementedException();
        } 

        public override Match GetByID(int id){
            Match toReturn = Context.Set<Match>().Where(x => x.Id == id).FirstOrDefault();
            return toReturn;
        } 

        public override IEnumerable<Match> GetAll(){
            return Context.Set<Match>().ToList();
        }

        public override bool Has(Match match){
            return Context.Set<Match>().Contains(match);
        }
    }
}
