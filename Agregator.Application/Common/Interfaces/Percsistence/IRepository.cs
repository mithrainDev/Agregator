using System.Linq.Expressions;

namespace Agregator.Application.Common.Interfaces.Percsistence;

public interface IRepository<T> where T : class
{
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    public IEnumerable<T> GetAll();
    public T Find(object id);
    public T Find(Expression<Func<T, bool>> predicate);
}
