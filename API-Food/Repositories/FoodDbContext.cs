using API_Food.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Food.Repositories
{
    public class FoodDbContext : DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options)
           : base(options)
        {

        }
        public DbSet<FoodEntity> FoodItems { get; set; }

    }
}
