using ProductService.Extensions.Startup;
using ProductService.Persistence.AppDbContext;

using AppContext = ProductService.Persistence.AppDbContext.AppContext;

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
        services.AddAutoMapper(typeof(Program).Assembly);

        services.AddServices();

        services.AddDbContext<IAppContext, AppContext>();

        services.AddControllers();
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