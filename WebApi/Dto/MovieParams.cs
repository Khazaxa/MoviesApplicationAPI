using System.ComponentModel.DataAnnotations;
using Core.Validate;

namespace WebApi.Dto;

public class MovieParams
{
    public string? Title { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Budget must be a positive number.")]
    public int? Budget { get; set; }

    public string? Homepage { get; set; }

    public string? Overview { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Popularity must be a positive number.")]
    public decimal? Popularity { get; set; }

    [RequiredIf("MovieStatus", "Released", ErrorMessage = "ReleaseDate is required when MovieStatus is 'Released'.")]
    public DateOnly? ReleaseDate { get; set; }

    [Range(0, long.MaxValue, ErrorMessage = "Revenue must be a positive number.")]
    public long? Revenue { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Runtime must be a positive number.")]
    public int? Runtime { get; set; }

    [Required]
    [Core.Validate.AllowedValues("Released", "InProduction", ErrorMessage = "MovieStatus must be either 'Released' or 'InProduction'.")]
    public string? MovieStatus { get; set; }

    public string? Tagline { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "VoteAverage must be a positive number.")]
    public decimal? VoteAverage { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "VoteCount must be a positive number.")]
    public int? VoteCount { get; set; }
}