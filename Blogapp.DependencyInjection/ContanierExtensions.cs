using Blogapp.Domain.IServices;
using Blogapp.Domain.Repositories;
using Blogapp.Domain.Repositories.Contract.Interfaces;
using Blogapp.Domain.Repositories.Impl.Repositories;
using Blogapp.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blogapp.DependencyInjection
{
    public static class ContanierExtensions
    {
        public static IServiceCollection RegisterDbContext(this IServiceCollection service)
        {
            service.AddScoped<BlogappContext>();
            return service;
        }

        public static IServiceCollection RegisterDependencies(this IServiceCollection service)
        {
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserService, UserService>();
            return service;
        }




    }
}
