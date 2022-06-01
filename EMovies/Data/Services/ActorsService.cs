using EMovies.Data.BaseRepo;
using EMovies.Models;

namespace EMovies.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        //public async Task AddAsync(Actor? actor)
        //{
        //    _context?.Actors?.Add(actor);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        //    _context?.Actors?.Remove(result);
        //    await _context.SaveChangesAsync();
        //}



        //public async Task<Actor> UpdateAsync(int id, Actor newActor)
        //{
        //    _context.Update(newActor);
        //    await _context.SaveChangesAsync();
        //    return newActor;
        //}
    }
}
