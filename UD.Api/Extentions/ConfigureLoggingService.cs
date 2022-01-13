using LoggerService;

namespace UD.Api.Extentions;

public static class ConfigureLoggingService
{
    public static void ConfigureLoggerService(this IServiceCollection services) =>
     services.AddSingleton<ILoggerManager, LoggerManager>();

}