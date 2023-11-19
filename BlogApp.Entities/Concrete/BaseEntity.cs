using BlogApp.Entities.Abstract;

namespace BlogApp.Entities.Concrete;

public class BaseEntity : IBaseEntity
{
    public int Id { get; set; }
}