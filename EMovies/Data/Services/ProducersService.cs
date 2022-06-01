using EMovies.Data.BaseRepo;
using EMovies.Models;

namespace EMovies.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
