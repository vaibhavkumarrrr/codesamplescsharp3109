using Microsoft.EntityFrameworkCore;

namespace EFSqlServer
{
    public class EFSqlServerContext(string connectionString) : DbContext 
    {
        private readonly string _connectionString = connectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            if (!optionsBuilder.IsConfigured)
            {
                Console.WriteLine("Configuring SQL Server"); 
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }


        // Concrete entities
        public DbSet<Food> Foods => Set<Food>();
        public DbSet<Cat> Cats => Set<Cat>();
        public DbSet<Dog> Dogs => Set<Dog>();
        //public DbSet<FarmAnimal> FarmAnimals => Set<FarmAnimal>();
        //public DbSet<FarmAnimal> FarmAnimals => Set<FarmAnimal>();
        public DbSet<Human> Humans => Set<Human>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Enable TPC strategy for Animal hierarchy
            modelBuilder.Entity<Animal>().UseTpcMappingStrategy();
            //modelBuilder.Entity<Cat>().UseTpcMappingStrategy();
            //modelBuilder.Entity<Dog>().UseTpcMappingStrategy();
            //modelBuilder.Entity<FarmAnimal>().UseTpcMappingStrategy();
            //modelBuilder.Entity<Human>().UseTpcMappingStrategy();

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