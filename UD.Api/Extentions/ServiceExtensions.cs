namespace UD.Api.Extentions;

public static class ServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            //use WithMethods("POST", "GET") that will allow only specific HTTP methods.
            //you can make the same changes for the AllowAnyHeader()
            //method by using, for example, the WithHeaders("accept", "contenttype") method to allow only specific header
        });

    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options => { });
}