using MoviesAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public class InMemoryRepositoryService : IInMemoryRepositoryService
    {
        private List<Genre> _genres;

        public InMemoryRepositoryService()
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

        public void AddGenre(Genre genre)
        {
            genre.Id = _genres.Max(x => x.Id) + 1;
            _genres.Add(genre);
        }

        
        
    }
}
