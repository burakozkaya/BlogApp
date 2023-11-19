using BlogApp.DAL.Abstract;
using BlogApp.DAL.Concrete;
using BlogApp.DAL.Context;
using BlogApp.Entities.Abstract;

namespace BlogApp.DAL.UnitOfWork;

public class Uow : IUow
{
    private AppDbContext _appDbContext;
    public Uow(AppDbContext context, AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public void SaveChanges()
    {
        _appDbContext.SaveChanges();
    }

    public IGenericRepository<T> GetRepository<T>() where T : class, IBaseEntity
    {
        return new GenericRepository<T>(_appDbContext);
    }
}