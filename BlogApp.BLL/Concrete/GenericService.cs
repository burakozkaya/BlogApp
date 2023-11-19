using AutoMapper;
using BlogApp.BLL.Abstract;
using BlogApp.DAL.Abstract;
using BlogApp.DTO.Abstract;
using BlogApp.Entities.Abstract;
using System.Linq.Expressions;

namespace BlogApp.BLL.Concrete;

public class GenericService<TDto, T> : IGenericService<TDto, T> where T : class, IBaseEntity
where TDto : class, IBaseDto
{
    //todo custom managerlar yazılcak
    protected readonly IUow _uow;
    private readonly IMapper _mapper;
    protected IGenericRepository<T> _genericRepository;

    public GenericService(IUow uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
        _genericRepository = _uow.GetRepository<T>();
    }
    public void Insert(TDto dto)
    {
        //todo entityler gelince map profileları yazılcak

        var Tentity = _mapper.Map<T>(dto);
        _genericRepository.Insert(Tentity);
        _uow.SaveChanges();
    }

    public void Update(TDto dto)
    {
        var Tentity = _mapper.Map<T>(dto);
        _genericRepository.Update(Tentity);
        _uow.SaveChanges();
    }

    public void Delete(TDto dto)
    {
        var Tentity = _mapper.Map<T>(dto);
        _genericRepository.Delete(Tentity);
        _uow.SaveChanges();
    }

    public T GetById(int id)
    {
        return _genericRepository.GetById(id);
    }

    public IEnumerable<TDto> GetAll()
    {
        var entityList = _genericRepository.GetAll();
        var dtoList = _mapper.Map<IEnumerable<TDto>>(entityList);
        return dtoList;
    }

    public IEnumerable<TDto> GetByPredicate(Expression<Func<T, bool>> predicate)
    {
        var entityList = _genericRepository.GetByPredicate(predicate);
        var dtoList = _mapper.Map<IEnumerable<TDto>>(entityList);
        return dtoList;
    }
}