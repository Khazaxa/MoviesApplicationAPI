namespace WebApi.Dto;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal? Popularity { get; set; }
    public List<string> ActorsNames { get; set; }
}