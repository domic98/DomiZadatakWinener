using DomiZadatakWin.Models;
using Microsoft.EntityFrameworkCore;

namespace DomiZadatakWin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Partner> Partners { get; set; }
        public DbSet<Policy> Policies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Partner>().HasData(
       new Partner
       {
           Id = 1,
           FirstName = "John",
           LastName = "Doe",
           Address = "Adresa 190",
           PartnerNumber = "12345678901234567890",
           CroatianPIN = "12345678901",
           PartnerTypeId = 1, // Personal
           CreatedAtUtc = DateTime.UtcNow,
           CreateByUser = "john@example.com",
           IsForeign = false,
           ExternalCode = "ABC1238663564",
           Gender = 'M'
       },
       new Partner
       {
           Id = 2,
           FirstName = "Jane",
           LastName = "Doe",
           Address = "Adresa 56",
           PartnerNumber = "09876543210987654321",
           CroatianPIN = "18344658941",
           PartnerTypeId = 2, // Legal
           CreatedAtUtc = DateTime.UtcNow,
           CreateByUser = "jane@example.com",
           IsForeign = true,
           ExternalCode = "XYZ4563986685446",
           Gender = 'F'
       },
       new Partner
       {
           Id = 3,
           FirstName = "Alice",
           LastName = "Smith",
           Address = "Adresa 123",
           PartnerNumber = "11122233344455566677",
           CroatianPIN = "47314358990",
           PartnerTypeId = 1, // Personal
           CreatedAtUtc = DateTime.UtcNow,
           CreateByUser = "alice@example.com",
           IsForeign = false,
           ExternalCode = "DEF789487678756",
           Gender = 'F'
       },
       new Partner
       {
           Id = 4,
           FirstName = "Bob",
           LastName = "Johnson",
           Address = "Adresa 15",
           PartnerNumber = "44455566677788899900",
           CroatianPIN = "623478695206",
           PartnerTypeId = 2, // Legal
           CreatedAtUtc = DateTime.UtcNow,
           CreateByUser = "bob@example.com",
           IsForeign = true,
           ExternalCode = "GHI12345697644",
           Gender = 'M'
       },
       new Partner
       {
           Id = 5,
           FirstName = "Charlie",
           LastName = "Brown",
           Address = "Adresa 23",
           PartnerNumber = "99900011122233344455",
           CroatianPIN = "70345653248",
           PartnerTypeId = 1, // Personal
           CreatedAtUtc = DateTime.UtcNow,
           CreateByUser = "charlie@example.com",
           IsForeign = false,
           ExternalCode = "JKL45634754656",
           Gender = 'N'
       }
   );
            modelBuilder.Entity<Policy>().HasData(
       new Policy
       {
           Id = 1,
           PolicyNumber = "POL001",
           PolicyAmount = 1500.00m,
           PartnerId = 1 // ID partnera "John"
       },
       new Policy
       {
           Id = 2,
           PolicyNumber = "POL002",
           PolicyAmount = 3000.00m,
           PartnerId = 2 // ID partnera "Jane"
       },
       new Policy
       {
           Id = 3,
           PolicyNumber = "POL003",
           PolicyAmount = 2000.00m,
           PartnerId = 3 // ID partnera "Alice"
       },
       new Policy
       {
           Id = 4,
           PolicyNumber = "POL004",
           PolicyAmount = 6000.00m,
           PartnerId = 4 // ID partnera "Bob"
       },
       new Policy
       {
           Id = 5,
           PolicyNumber = "POL005",
           PolicyAmount = 2500.00m,
           PartnerId = 5 // ID partnera "Charlie"
       }
   );



            modelBuilder.Entity<Partner>()
                .HasMany(p => p.Policies)
                .WithOne(policy => policy.Partner)
                .HasForeignKey(policy => policy.PartnerId);
        }
    }
}
