using BlogApp.Entities.Abstract;

namespace BlogApp.DAL.Abstract;

public interface IUow
{
    void SaveChanges();
    IGenericRepository<T> GetRepository<T>() where T : class, IBaseEntity;
}