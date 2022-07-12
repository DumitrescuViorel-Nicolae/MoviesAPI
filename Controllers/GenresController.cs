using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using MoviesAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController
    {
        private readonly IInMemoryRepository _repository;

        public GenresController(IInMemoryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await _repository.GetAllGenres();
        }

        [HttpGet("{Id}")]
        public ActionResult<Genre> Get(int id)
        {
            var genre = _repository.GetGenreById(id);
            return genre;
        }
    }
}
