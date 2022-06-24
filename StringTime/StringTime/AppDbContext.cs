using Microsoft.EntityFrameworkCore;

namespace StringTime
{
    public class AppDbContext : DbContext
    {
        public DbSet<StringTime> StringTimes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StringTime>().ToTable("StringTimes");
            builder.Entity<StringTime>().HasKey(s => s.Id);
            builder.Entity<StringTime>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<StringTime>().Property(p => p.Words).IsRequired().HasMaxLength(100);

            //builder.Entity<StringTime>().HasData(
            //    new StringTime {Id = 100, Words = "Paris"},
            //    new StringTime { Id = 101, Words = "Barcelona" },
            //    new StringTime { Id = 102, Words = "Algiers" }
            //    );
        }
    }
}
