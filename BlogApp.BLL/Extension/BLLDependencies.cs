using BlogApp.BLL.Abstract;
using BlogApp.BLL.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BlogApp.BLL.Extension;

public static class BLLDependencies
{
    public static void AddBLLDependencies(this IServiceCollection services)
    {
        //todo yeni managerlar gelince injectionları yapılcak
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(IAccountService), typeof(AccountManager));
        services.AddScoped(typeof(IBlogService), typeof(BlogManager));
    }
}