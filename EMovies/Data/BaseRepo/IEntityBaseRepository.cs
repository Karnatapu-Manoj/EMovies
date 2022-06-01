using System.Linq.Expressions;

namespace EMovies.Data.BaseRepo
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T?>> GetAllAsync();

        // To have cinemas include property in movies controller
        Task<IEnumerable<T?>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T?> GetByIdAsync(int? id);
        Task AddAsync(T? entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
