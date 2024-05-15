using Core;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [ApiController, Route("movies")]
    public class MoviesController(MoviesContext _context) : ControllerBase
    {
        [HttpGet]
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
    }
}