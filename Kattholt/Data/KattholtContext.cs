using System.Transactions;
using Kattholt.Models;
using Microsoft.EntityFrameworkCore;

namespace Kattholt.Data;

public class KattholtContext : DbContext
{

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<CatTransactions> CatTransactions { get; set; }
    
    public string DbPath { get; }

    public KattholtContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "kattholt.db");
        
        Console.WriteLine(DbPath);
        
    }
    
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Address>().HasData(new Address(){Id = 1, StreetName = "Hafnargata", HouseNumer = 12, ZipCode = 230});
        modelBuilder.Entity<Cat>().HasData(new Cat() {Id = 1, Name = "Kisi", TrackingNumber = 144354});
        
        
        modelBuilder.Entity<Owner>().HasData(
            new Owner()
            {
                Id = 1, 
                Name = "Hjörtur", 
                AddressId = 1,
                CatId = 1
            }
        );
        
        modelBuilder.Entity<Owner>().HasData(
            new Owner()
            {
                Id = 2, 
                Name = "Fannar", 
                AddressId = 1,
                CatId = 1
            }
        );

        modelBuilder.Entity<CatTransactions>().HasData(
            new CatTransactions()
            {
            Id = 1,
            CatId = 1,
            NewOwnerId = 2,
            OldOwnerId = 1,
            AdoptedTime = DateTime.Now
            }
        );



    }
}