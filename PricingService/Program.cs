using Serilog;
using Serilog.Events;
using Steeltoe.Discovery.Client;
using Steeltoe.Discovery.Eureka;

namespace PricingService;

public class Program
{
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
            .UseSerilog()
            .AddServiceDiscovery(builder => builder.UseEureka());
    }
}