using APlus.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APlus.Data.Entity
{
    public class EntityDBContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public EntityDBContext()
        {

        }
        public EntityDBContext(DbContextOptions<EntityDBContext> options)
            : base(options)
        {

        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanService> PlanServices { get; set; }
        public DbSet<SubscriptionUser> SubscriptionUsers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var connectionString = configuration.GetConnectionString("DbCoreConnectionString");
            optionsBuilder.UseSqlServer(connectionString, builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
