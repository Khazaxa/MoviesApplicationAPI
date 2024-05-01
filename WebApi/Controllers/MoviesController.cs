// using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController, Route("movies")]
    public class MoviesController() : ControllerBase
    {

        [HttpGet, Route("")]
        public async Task<IActionResult> GetMovies(int pageNumber = 1, int pageSize = 1)
        {
            return Ok();
        }
    }
}