using BlogApp.DAL.Abstract;
using BlogApp.DAL.Context;
using BlogApp.DAL.UnitOfWork;
using BlogApp.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.DAL.Extension;

public static class DalDependencies
{
    public static void AddDalDependencies(this IServiceCollection service, string connectionString)
    {
        service.AddDbContext<AppDbContext>
        (x => x.UseSqlServer(connectionString));

        service.AddIdentity<AppUser, AppRole>(x =>
        {

        }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();

        service.AddScoped(typeof(IUow), typeof(Uow));
    }
}