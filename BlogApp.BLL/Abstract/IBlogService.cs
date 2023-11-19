using BlogApp.DTO.Concrete;
using BlogApp.Entities.Concrete;

namespace BlogApp.BLL.Abstract;

public interface IBlogService : IGenericService<BlogDto, Blog>
{

}