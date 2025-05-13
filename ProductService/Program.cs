using Serilog;
using Serilog.Events;

namespace ProductService;

/// <summary>
/// Основной класс конфигурации веб-приложения
/// </summary>
public class Program
{
    /// <summary>
    /// Метод старта приложения
    /// </summary>
    /// <param name="args">Аргументы командной строки</param>
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();

        try
        {
            Log.Information("Starting PricingService");
            CreateWebHostBuilder(args).Build().Run();
        }
        catch (Exception e)
        {
            Log.Fatal(e, "PricingService terminated unexpectedly");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }

    private static IHostBuilder CreateWebHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
            .UseSerilog();
    }
}