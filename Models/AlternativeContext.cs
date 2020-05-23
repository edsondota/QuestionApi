using Microsoft.EntityFrameworkCore;

namespace QuestionApi.Models
{
  public class AlternativeContext : DbContext
  {
    public AlternativeContext(DbContextOptions<AlternativeContext> options)
      : base(options)
    {
    }

    public DbSet<AlternativeContext> Alternatives { get; set; }
  }
}

