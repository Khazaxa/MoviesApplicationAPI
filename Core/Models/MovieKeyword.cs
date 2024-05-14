namespace Core.Models;

public class MovieKeyword
{
    public int? MovieId { get; set; }

    public int? KeywordId { get; set; }

    public virtual Keyword? Keyword { get; set; }

    public virtual Movie? Movie { get; set; }
}
