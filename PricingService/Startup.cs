using PricingService.Extensions.Startup;
using Steeltoe.Discovery.Client;

namespace PricingService;

public class Startup
{
    private IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        // register Eureka client
        services.AddDiscoveryClient(Configuration);
        
        services.AddAuthorization();
        services.AddSwaggerDocs();
    }

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