using EMovies.Data.BaseRepo;
using EMovies.Models;

namespace EMovies.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie?> GetMovieByIdAsync(int id);
    }
}
