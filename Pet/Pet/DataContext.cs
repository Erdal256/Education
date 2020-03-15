using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions dbContext): base(dbContext)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            for (int i = 1; i <= 1000; i++)
            {
                modelBuilder.Entity<Models.Pet>().HasData(new Models.Pet()
                {
                    Id = i,
                    Prop1 = "asdf" + i,
                    Prop2 = "asdf" + i,
                    Prop3 = "asdf" + i,
                    Prop4 = "asdf" + i

                });
            }
        }
        public DbSet<Models.Pet> Pets { get; set; }
    }
}
