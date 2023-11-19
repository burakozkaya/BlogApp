namespace BlogApp.Entities.Concrete;

public class Blog : BaseEntity
{
    //todo proje gelince entityler düzenlencek
    public string AppUserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    //Nav Property
    public AppUser AppUser { get; set; }
}