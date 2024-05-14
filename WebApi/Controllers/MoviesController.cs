using Core;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}