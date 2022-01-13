using Contracts;
using Repository;

namespace UD.Api.Extentions;

public static class ConfigureRepositoryManager
{
    public static void ConfigRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();
}