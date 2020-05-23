using Microsoft.EntityFrameworkCore;

namespace QuestionApi.Models
{
  public class QuestionContext : DbContext
  {
    public QuestionContext(DbContextOptions<QuestionContext> options)
      : base(options)
    {
    }

    public DbSet<Question> Questions { get; set; }
  }
}
