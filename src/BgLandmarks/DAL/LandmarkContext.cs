using DAL.Entities;
using DAL.Seeder;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class LandmarkContext : DbContext
    {
        public LandmarkContext(DbContextOptions<LandmarkContext> options)
            : base(options)
        {
        }

        public DbSet<Landmark> Landmarks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Landmark>(l =>
            {
                l.HasNoKey();
            });

            modelBuilder.Entity<Landmark>().HasData(new LandmarkSeeder().Landmarks);
        }
    }
}
