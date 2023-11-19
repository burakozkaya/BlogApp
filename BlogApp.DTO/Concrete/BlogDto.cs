using BlogApp.DTO.Abstract;

namespace BlogApp.DTO.Concrete;

public class BlogDto : IBaseDto
{
    //todo son entity gelince içi düzenlencek ve yeni dtolar yazılcak
    public string AppUserId { get; set; }
    public string Title { get; set; }
}