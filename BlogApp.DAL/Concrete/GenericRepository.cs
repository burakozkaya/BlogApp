using BlogApp.DAL.Abstract;
using BlogApp.DAL.Context;
using BlogApp.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlogApp.DAL.Concrete;

public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity
{
    //todo Custom Repolar eklencek
    protected AppDbContext Context;
    protected DbSet<T> DbSet;
    public GenericRepository(AppDbContext context)
    {
        Context = context;
        DbSet = context.Set<T>();
    }
    public void Insert(T entity)
    {
        DbSet.Add(entity);
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }

    public void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public T GetById(int id)
    {
        return DbSet.Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return DbSet.ToList();
    }

    public IEnumerable<T> GetByPredicate(Expression<Func<T, bool>> predicate)
    {
        return DbSet.Where(predicate).ToList();
    }
}