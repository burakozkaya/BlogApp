using BlogApp.Entities.Abstract;
using System.Linq.Expressions;

namespace BlogApp.DAL.Abstract;

public interface IGenericRepository<T> where T : class, IBaseEntity
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetByPredicate(Expression<Func<T, bool>> predicate);
}

