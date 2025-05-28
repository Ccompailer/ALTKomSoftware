using ProductService.Handlers.Services;

namespace ProductService.Extensions.Startup;

/// <summary>
/// Класс с методами расширений для ServiceCollection в Startup
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Метода расширения для добавления документации Swagger
    /// </summary>
    /// <param name="services">Коллекция сервисов</param>
    public static void AddSwaggerDocs(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    /// <summary>
    /// Метода расширения для добавления сервисов в контейнер зависимостей
    /// </summary>
    /// <param name="services">Коллекция сервисов</param>
    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<IProductFlowService, ProductFlowService>();
    }
}