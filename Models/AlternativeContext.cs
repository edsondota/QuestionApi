using Microsoft.EntityFrameworkCore;

namespace QuestionApi.Models
{
  public class AlternativeContext : DbContext
  {

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Alternative>()
        .HasOne(a => a.Question)
        .WithMany(q => q.Alternatives);
    }

    public AlternativeContext(DbContextOptions<AlternativeContext> options)
      : base(options)
    {
    }

    public DbSet<Alternative> Alternatives { get; set; }
  }
}

