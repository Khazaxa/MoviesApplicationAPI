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
    }
}