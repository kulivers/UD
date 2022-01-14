using Repository;
using Contracts;

namespace UD.Api.Extentions;

public static class ConfigureRepositoryManagerClass
{
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();
}