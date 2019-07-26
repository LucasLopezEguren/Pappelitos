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

        } 

        public override Player GetByName(String name){
            Player toReturn = null;
            return toReturn;
        } 

        public override Player GetByID(int id){
            Player toReturn = null;
            return toReturn;
        } 

        public override IEnumerable<Player> GetAll(){
            List<Player> toReturn = null;
            return toReturn;
        }

        public override bool Has(Player player){
            List<Player> toCompare = this.GetAll().ToList();
            return toCompare.Contains(player);
        }
    }
}
