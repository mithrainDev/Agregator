using Agregator.Application.Common.Interfaces.Percsistence;
using Agregator.Infrastructure.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Agregator.Infrastructure.Persistence.GenericRepository;

public sealed class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }
        _dbSet.Remove(entity);
    }

    public T Find(object id)
    {
        return _dbSet.Find(id);
    }

    public T Find(Expression<Func<T, bool>> predicate = null)
    {
        IQueryable<T> query = _dbSet;

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return query.First();
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToArray();
    }

    public void Update(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
}
