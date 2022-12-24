using Microsoft.EntityFrameworkCore;
using SportsApplication.Models;

namespace SportsApplication
{
    public class SportsContextClass : DbContext
    {
        public SportsContextClass() { }
        public SportsContextClass(DbContextOptions<SportsContextClass> options) : base(options)
        {

        }
        public static bool isMigration = true;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            if (isMigration)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-HU6GJD4;Database=CompanyDbName;Trusted_Connection=True;MultipleActiveResultSets=true;User Id=sa; Password=13491a03g3");
            }
        }
        //public class DbModelBuilder
        //{

        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Football>().HasKey<int>(f => f.FootballKey).HasRequried(f => f.Tropies);

        //    //modelBuilder.Entity<FootballClub>.Property(p => p.Club_Name).HasMaxLength(15).HasForeignKey<int>(p => p.Player_Id);

        //}
        public DbSet<Cricket> Crickets { get; set; }
        public DbSet<Ipl> Ipls { get; set; }
        public DbSet<Bigbash> Bigbashs { get; set; }
        public DbSet<Football> Footballs { get; set; }
        public DbSet<FootballClub> FootballClubs { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }


    }

  
}
