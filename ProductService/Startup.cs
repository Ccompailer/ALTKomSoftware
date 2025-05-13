using ProductService.Extensions.Startup;

namespace ProductService;

/// <summary>
/// Класс конфигурации сервисов веб-приложения
/// </summary>
public class Startup
{
    /// <summary>
    /// Конструктор класс для инъекции нужных зависимостей
    /// </summary>
    /// <param name="configuration">Конфигурация приложения</param>
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

    /// <summary>
    /// Метод конфикурации сервисов для приложения
    /// </summary>
    /// <param name="services">Коллекция сервисов</param>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddAuthorization();
        services.AddSwaggerDocs();
    }

    /// <summary>
    /// Метод конфигурации пайплайна middleware-ов
    /// </summary>
    /// <param name="app">Пайплайн middleware</param>
    /// <param name="env">Переменные окружения веб-приложения</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
    }
}