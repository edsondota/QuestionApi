using System.Collections.Generic;

namespace QuestionApi.Models
{
  public class Question
  {
    public long Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public IList<Alternative> Alternatives { get; set; }
  }
}