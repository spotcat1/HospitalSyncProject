

using Domain.Commons;
using System.Linq.Expressions;

namespace Application.Contracts
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid Id);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void AddRangeAsync(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);


        IQueryable<T> Table();
        IQueryable<T> TableTracking();

        Task<bool> SaveChangesAsync();
    }
    
}
