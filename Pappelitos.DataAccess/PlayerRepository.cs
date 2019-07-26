using System;
using Pappelitos.Domain;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pappelitos.DataAccess
{
    public class PlayerRepository : BaseRepository<Player>
    {
        public PlayerRepository(DbContext context)
        {
            Context = context;
        }

        public override void Add(Player player){
            Context.Set<Player>().Add(player);
            Context.SaveChanges();
        } 

        public override Player GetByName(String name){
            Player toReturn = Context.Set<Player>().Where(x => x.Name == name).FirstOrDefault();
            return toReturn;
        } 

        public override Player GetByID(int id){
            Player toReturn = Context.Set<Player>().Where(x => x.Id == id).FirstOrDefault();
            return toReturn;
        } 

        public override IEnumerable<Player> GetAll(){
            return Context.Set<Player>().ToList();
        }

        public override bool Has(Player player){
            return Context.Set<Player>().Contains(player);
        }
    }
}
