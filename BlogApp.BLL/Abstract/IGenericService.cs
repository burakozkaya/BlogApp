using BlogApp.DTO.Abstract;
using BlogApp.Entities.Abstract;
using System.Linq.Expressions;

namespace BlogApp.BLL.Abstract;

public interface IGenericService<TDto, T>
    where T : class, IBaseEntity where TDto : class, IBaseDto
{
    void Insert(TDto dto);
    void Update(TDto dto);
    void Delete(TDto dto);
    T GetById(int id);
    IEnumerable<TDto> GetAll();
    IEnumerable<TDto> GetByPredicate(Expression<Func<T, bool>> predicate);
}