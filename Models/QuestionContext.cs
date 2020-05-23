using Microsoft.EntityFrameworkCore;

namespace QuestionApi.Models
{
  public class QuestionContext : DbContext
  {

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Question>()
        .HasMany(q => q.Alternatives)
        .WithOne(a => a.Question);
    }
    public QuestionContext(DbContextOptions<QuestionContext> options)
      : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }
  }
}
