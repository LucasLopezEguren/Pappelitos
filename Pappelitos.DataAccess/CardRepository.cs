using System;
using Pappelitos.Domain;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pappelitos.DataAccess
{
    public class CardRepository : BaseRepository<Card>
    {
        public CardRepository(DbContext context)
        {
            Context = context;
        }

        public override void Add(Card card){
            Context.Set<Card>().Add(card);
            Context.SaveChanges();
        } 

        public override Card GetByName(String name){
            Card toReturn = Context.Set<Card>().Where(x => x.Word == name).FirstOrDefault();
            return toReturn;
        } 

        public override Card GetByID(int id){
            Card toReturn = Context.Set<Card>().Where(x => x.Id == id).FirstOrDefault();
            return toReturn;
        } 

        public override IEnumerable<Card> GetAll(){
            return Context.Set<Card>().ToList();
        }

        public override bool Has(Card card){
            return Context.Set<Card>().Contains(card);
        }
    }
}
