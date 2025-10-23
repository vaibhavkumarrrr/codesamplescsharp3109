using Microsoft.EntityFrameworkCore;
using csharp.training.congruent.classes;
namespace csharp.training.congruent.apps
{
    public class EFSqlServerContext : DbContext 
    {
        private readonly string _connectionString = string.Empty;

        public EFSqlServerContext():base()
        {
            _connectionString = "Server=(localdb)\\mssqllocaldb;Trusted_Connection=True;";
        }  
        public EFSqlServerContext(string connectionString)
        {
            _connectionString = connectionString;
        }   


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          Console.WriteLine($"Using SQL Server with connection string: {_connectionString}");
            optionsBuilder.UseSqlServer(_connectionString).UseLazyLoadingProxies(); 
        }


        // Concrete entities
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Cat> Cats => Set<Cat>();
        public DbSet<Dog> Dogs => Set<Dog>();
        //public DbSet<FarmAnimal> FarmAnimals => Set<FarmAnimal>();
        public DbSet<FarmAnimal> FarmAnimals => Set<FarmAnimal>();
        public DbSet<Human> Humans => Set<Human>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().UseTpcMappingStrategy();

            // Configure relationships
            modelBuilder.Entity<Pet>()
                .HasMany(p => p.Humans)
                .WithMany(h => h.Pets)
                .UsingEntity(j => j.ToTable("HumanPetLinks"));

            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Food)
                .WithMany()
                .HasForeignKey("FoodId");

            modelBuilder.Entity<Human>()
                .HasOne(h => h.FavoriteAnimal)
                .WithMany()
                .HasForeignKey("FavoriteAnimalId");

            // Optional: Configure precision for FarmAnimal.Value
            //modelBuilder.Entity<FarmAnimal>()
              //  .Property(f => f.Value)
                //.HasPrecision(18, 2);
        }
    }
}