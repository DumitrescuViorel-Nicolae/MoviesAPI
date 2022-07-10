using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using MoviesAPI.Services;
using System.Collections.Generic;

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
        public List<Genre> Get()
        {
            return _repository.GetAllGenres();
        }

        [HttpGet("{Id}")]
        public Genre Get(int id)
        {
            var genre = _repository.GetGenreById(id);
            return genre;
        }

        [HttpPost]
        public void Post() { }
        [HttpPut]
        public void Put() { }
        [HttpDelete]
        public void Delete() { }
    }
}
