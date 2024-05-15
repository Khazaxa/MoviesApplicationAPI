using Core;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    public class MoviesController(MoviesContext _context) : ControllerBase
    {
        [HttpGet, Route("movies")]
        public async Task<ActionResult<PagedResult<Movie>>> GetPagedMovies(int pageNumber = 1, int pageSize = 1)
        {
            var movies = _context.Movies.AsQueryable();

            var totalCount = await movies.CountAsync();
            var pagedMovies = await movies.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Movie>
            {
                Items = pagedMovies,
                TotalCount = totalCount,
                PageSize = pageSize,
                PageNumber = pageNumber
            };
        }
        
        [HttpGet("api/movies")]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetPopularMovies([FromQuery] StartDateDto startDateDto, [FromQuery] EndDateDto endDateDto)
        {
            DateOnly startDate = new DateOnly(startDateDto.StartYear, startDateDto.StartMonth, startDateDto.StartDay);
            DateOnly endDate = new DateOnly(endDateDto.EndYear, endDateDto.EndMonth, endDateDto.EndDay);

            var movies = await _context.Movies
                .AsQueryable()
                .Where<Movie>(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value >= startDate && m.ReleaseDate.Value <= endDate)
                .OrderByDescending<Movie, decimal?>(m => m.Popularity)
                .Take<Movie>(5)
                .ToListAsync();

            var movieDtos = new List<MovieDto>();

            foreach (var movie in movies)
            {
                var actorsNames = await _context.MovieCasts
                    .Where(mc => mc.MovieId == movie.MovieId)
                    .Select(mc => mc.Person.PersonName)
                    .ToListAsync();

                movieDtos.Add(new MovieDto
                {
                    Id = movie.MovieId,
                    Title = movie.Title,
                    Popularity = movie.Popularity,
                    ActorsNames = actorsNames
                });
            }

            return Ok(movieDtos);
        }
        
        [HttpPost("movies/{id}/keywords")]
        public async Task<IActionResult> AddKeywordToMovie(int id, [FromBody] Keyword keyword)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound(new { message = $"Movie with id {id} not found." });
            }

            var existingKeyword = await _context.Keywords.FirstOrDefaultAsync(k => k.KeywordName == keyword.KeywordName);
            if (existingKeyword == null)
            {
                _context.Keywords.Add(keyword);
                await _context.SaveChangesAsync();
            }
            else
            {
                keyword = existingKeyword;
            }

            var movieKeyword = await _context.MovieKeywords.FirstOrDefaultAsync(mk => mk.MovieId == id && mk.KeywordId == keyword.KeywordId);
            if (movieKeyword != null)
            {
                return BadRequest(new { message = "The keyword is already associated with the movie." });
            }

            movieKeyword = new MovieKeyword { MovieId = id, KeywordId = keyword.KeywordId };
            _context.MovieKeywords.Add(movieKeyword);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(AddKeywordToMovie), new { id = movie.MovieId, keywordId = keyword.KeywordId }, movieKeyword);
        }
    }
}