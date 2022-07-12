using MoviesAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public class InMemoryRepository : IInMemoryRepository
    {
        private List<Genre> _genres;

        public InMemoryRepository()
        {
            _genres = new List<Genre>() { new Genre(){Id = 1, Name = "Comedy" },
                new Genre(){Id = 2, Name = "Drama"}
                };
        }
        public async Task<List<Genre>> GetAllGenres()
        {
            await Task.Delay(3000);
            return _genres;
        }

        public Genre GetGenreById(int Id)
        {
            return _genres.FirstOrDefault(item => item.Id == Id);
        }
        
        
    }
}
