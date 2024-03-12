using Application.Contracts;
using Application.Exceptions;
using Domain.Commons;
using Infrastructure.Persistants;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class GenericRepositoryImplementaton<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepositoryImplementaton(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
              _context.Set<T>().Add(entity);
        }

        public void AddRangeAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await Table().AnyAsync(expression);
        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            if (!await AnyAsync(x => x.Id == Id))
            {
                throw new NotFoundException("کاربر یافت نشد");
            }

            return await TableTracking().FirstOrDefaultAsync(x => x.Id == Id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync().ConfigureAwait(false) > 0;
        }


        public IQueryable<T> Table()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> TableTracking()
        {
            return _context.Set<T>();
        }

        public void Update(T entity)
        {
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AttachRange(entities);
            foreach(var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
