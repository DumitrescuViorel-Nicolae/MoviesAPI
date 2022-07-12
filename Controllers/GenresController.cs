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
        private readonly IInMemoryRepositoryService _repository;

        public GenresController(IInMemoryRepositoryService repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genre>>> GetAll()
        {
            return await _repository.GetAllGenres();
        }

        [HttpGet("{Id}", Name ="getGenre")]
        public ActionResult<Genre> Get(int id)
        {
            var genre = _repository.GetGenreById(id);
            return genre;
        }
        [HttpPost]
        public ActionResult AddGenre(Genre genre) {
            _repository.AddGenre(genre);
            return new CreatedAtRouteResult("getGenre", new { Id = genre.Id }, genre);
        }
    }
}
