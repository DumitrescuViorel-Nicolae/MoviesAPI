using MoviesAPI.Models;
using System.Collections.Generic;

namespace MoviesAPI.Services
{
    public interface IInMemoryRepository
    {
        List<Genre> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
