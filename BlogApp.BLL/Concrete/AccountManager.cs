using BlogApp.BLL.Abstract;
using BlogApp.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace BlogApp.BLL.Concrete;

public class AccountManager : IAccountService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AccountManager(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
}

