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
            builder.Entity<StringTime>().Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Entity<StringTime>().Property(p => p.Words);
        }
    }
}
