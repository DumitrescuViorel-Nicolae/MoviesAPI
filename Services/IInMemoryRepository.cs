using MoviesAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public interface IInMemoryRepository
    {
        Task<List<Genre>> GetAllGenres();
        Genre GetGenreById(int Id);
    }
}
