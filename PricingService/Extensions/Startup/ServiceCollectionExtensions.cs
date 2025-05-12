namespace PricingService.Extensions.Startup;

public static class ServiceCollectionExtensions
{
    public static void AddSwaggerDocs(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }
}