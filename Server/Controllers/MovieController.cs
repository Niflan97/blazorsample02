using blazorsample02.Server.Data;
using blazorsample02.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blazorsample02.Server.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]

    public class MovieController : ControllerBase
    {
        private readonly DataContext _DbContext;

        public MovieController(DataContext dbContext)
        {
            _DbContext = dbContext;
        }


        [HttpGet]
        private IEnumerable<Movies> GetMovies()
        {
            return _DbContext.Movie.ToList();

        }

    }
}

