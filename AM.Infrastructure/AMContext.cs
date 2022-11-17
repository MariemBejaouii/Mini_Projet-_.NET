using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    public class AMContext :DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=MariemBejaouiDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Plane>? Planes { get; set; }
        public DbSet<Flight>? Flights { get; set; }
        public DbSet<Passenger>? Passengers { get; set; }
       

       protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.Entity<Stuff>().ToTable("Stuff");
            modelBuilder.Entity<Traveller>().ToTable("Traveller");
            modelBuilder.ApplyConfiguration(new TicketConfiguration());


        }


        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            modelConfigurationBuilder.Properties<DateTime>().HaveColumnType("date");


        }



    }
}
