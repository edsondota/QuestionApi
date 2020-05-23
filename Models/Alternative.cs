namespace QuestionApi.Models
{
  public class Alternative {
    public long Id { get; set; }
    public long QuestionId { get; set; }
    public Question Question { get; set; }
    public string Title { get; set; }
    public bool IsCorrect { get; set; }
  }
}