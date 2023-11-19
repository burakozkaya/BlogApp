using AutoMapper;
using BlogApp.BLL.Abstract;
using BlogApp.DAL.Abstract;
using BlogApp.DTO.Concrete;
using BlogApp.Entities.Concrete;

namespace BlogApp.BLL.Concrete;

public class BlogManager : GenericService<BlogDto, Blog>, IBlogService
{
    public BlogManager(IUow uow, IMapper mapper) : base(uow, mapper)
    {
    }
}