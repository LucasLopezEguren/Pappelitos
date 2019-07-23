using System;
using Microsoft.EntityFrameworkCore;
using Pappelitos.Domain;

namespace Pappelitos.DataAccess
{
    public class PappelitosContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Card> Cards { get; set; }

        public PappelitosContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
