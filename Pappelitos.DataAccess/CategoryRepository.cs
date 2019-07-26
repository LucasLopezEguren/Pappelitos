
using System;
using Pappelitos.Domain;
using System.Linq;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pappelitos.DataAccess
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(DbContext context)
        {
            Context = context;
        }

        public override void Add(Category category){
            Context.Set<Category>().Add(category);
            Context.SaveChanges();
        } 

        public override Category GetByName(String name){
            Category toReturn = Context.Set<Category>().Where(x => x.Name == name).FirstOrDefault();
            return toReturn;
        } 

        public override Category GetByID(int id){
            Category toReturn = Context.Set<Category>().Where(x => x.Id == id).FirstOrDefault();
            return toReturn;
        } 

        public override IEnumerable<Category> GetAll(){
            return Context.Set<Category>().ToList();
        }

        public override bool Has(Category category){
            return Context.Set<Category>().Contains(category);
        }
    }
}
