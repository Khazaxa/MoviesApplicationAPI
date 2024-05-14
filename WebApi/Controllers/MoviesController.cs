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
        
        [HttpGet, Route("{id}")]
        public async Task<ActionResult<MovieDto>> GetMovieById(int id)
        {
            var movie = await _context.Movies
                .Where(m => m.MovieId == id)
                .Select(m => new MovieDto
                {
                    Id = m.MovieId,
                    Title = m.Title,
                    Company = _context.MovieCompanies
                        .Where(mc => mc.MovieId == m.MovieId)
                        .Select(mc => mc.Company.CompanyName)
                        .FirstOrDefault(),
                    Genre = _context.MovieGenres
                        .Where(mg => mg.MovieId == m.MovieId)
                        .Select(mg => mg.Genre.GenreName)
                        .FirstOrDefault(),
                    Popularity = (double)m.Popularity
                })
                .FirstOrDefaultAsync();

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }
        
        [HttpPost]
        public async Task<ActionResult<MovieParams>> CreateMovie(MovieParams movieEntity)
        {
            var movie = new Movie
            {
                Title = movieEntity.Title,
                Budget = movieEntity.Budget,
                Homepage = movieEntity.Homepage,
                Overview = movieEntity.Overview,
                Popularity = movieEntity.Popularity,
                ReleaseDate = movieEntity.ReleaseDate,
                Revenue = movieEntity.Revenue,
                Runtime = movieEntity.Runtime,
                MovieStatus = movieEntity.MovieStatus,
                Tagline = movieEntity.Tagline,
                VoteAverage = movieEntity.VoteAverage,
                VoteCount = movieEntity.VoteCount
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMovieById), new { id = movie.MovieId }, movieEntity);
        }
    }
}