using Microsoft.EntityFrameworkCore;
using fishingApi.Models;

namespace fishingApi.Data {
 public class ApplicationDbContext: DbContext {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     :base(options) {}

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // add your own configuration here
        modelBuilder.Entity<Boat>()
            .Property(c => c.B)
            .HasColumnType("decimal(14,1)");
            modelBuilder.Entity<Boat>()
            .Property(c => c.LOA)
            .HasColumnType("decimal(14,2)");

            //Seed Data
            modelBuilder.Seed();
    }

     public DbSet<Boat> Boats { get; set; }
     public DbSet<CrewMember> CrewMembers { get; set; }

 }

 public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Boat>()
                .HasData(
                     new Boat { BoatId = 1, Name = "Destroyer", BuildNumber = 10, LOA = 201.23M, B = 30.32M, Producer = "Centos Company" },
                    new Boat { BoatId = 2, Name = "Harbinger", BuildNumber = 3, LOA = 221.23M, B = 60.32M, Producer = "Centos Company" },
                    new Boat { BoatId = 3, Name = "GameChanger", BuildNumber = 5, LOA = 301.24M, B = 50.82M, Producer = "Centos Company" },
                    new Boat { BoatId = 4, Name = "LoverBoy", BuildNumber = 13, LOA = 301.27M, B = 30.382M, Producer = "Hey Company" },
                    new Boat { BoatId = 5, Name = "Hope", BuildNumber = 8, LOA = 203.23M, B = 30.32M, Producer = "None Company" },
                    new Boat { BoatId = 6, Name = "Startropper", BuildNumber = 2, LOA = 301.23M, B = 30.32M, Producer = "John Company" },
                    new Boat { BoatId = 7, Name = "Johnson", BuildNumber = 140, LOA = 751.23M, B = 30.32M, Producer = "Centos Company" },
                    new Boat { BoatId = 8, Name = "Lost", BuildNumber = 120, LOA = 6071.23M, B = 350.32M, Producer = "tom Company" },
                    new Boat { BoatId = 9, Name = "Titanic", BuildNumber = 30, LOA = 2601.23M, B = 350.32M, Producer = "Centos Company" }
                );
            modelBuilder.Entity<CrewMember>()
                .HasData(
                    new CrewMember { CrewMemberId = 1, BoatId =1, Name = "James", Age = 34, Role ="Captain", CertifiedUntil = System.DateTime.Now },
                    new CrewMember { CrewMemberId = 2, BoatId =3, Name = "Elena", Age = 24, Role ="Deck Cadet", CertifiedUntil = System.DateTime.Now },
                    new CrewMember { CrewMemberId = 3, BoatId =5, Name = "Prince", Age = 44, Role ="Chief Engineer", CertifiedUntil = System.DateTime.Now },
                    new CrewMember { CrewMemberId = 4, BoatId =6, Name = "Jeremiah", Age = 30, Role ="Motorman", CertifiedUntil = System.DateTime.Now },
                    new CrewMember { CrewMemberId = 5, BoatId =2, Name = "Gordon", Age = 28, Role ="Deck Cadet", CertifiedUntil = System.DateTime.Now },
                    new CrewMember { CrewMemberId = 6, BoatId =9, Name = "Kate", Age = 29, Role ="Chief Engineer", CertifiedUntil = System.DateTime.Now }
                );
    }
}   
}