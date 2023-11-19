using Microsoft.AspNetCore.Identity;

namespace BlogApp.Entities.Concrete;

public class AppUser : IdentityUser
{
    //todo profil fotosu eklenebilir
    public string Name { get; set; }
    public string Surname { get; set; }
}