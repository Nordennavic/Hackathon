using Hackathon.Models.PlanParameters;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Models
{
    public class MotiveOfficeDBContext : DbContext
    {
        public MotiveOfficeDBContext()
        {
            Database.EnsureCreated();
        }
        public MotiveOfficeDBContext(DbContextOptions<MotiveOfficeDBContext> options) : base(options)
        {
        }

        public DbSet<DbUser> Users { get; set; }

        public DbSet<PhonePlan> PhonePlans { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public const string ConnectionString =
            "Server=tcp:hackatonmotiv.database.windows.net,1433;Initial Catalog=DB_MOTIV;Persist Security Info=False;User ID=Hackaton;Password=Team2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhonePlan>();
        }*/
    }


}

