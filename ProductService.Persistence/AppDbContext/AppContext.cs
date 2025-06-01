using Microsoft.EntityFrameworkCore;
using ProductService.Persistence.Entities;

namespace ProductService.Persistence.AppDbContext;

/// <inheritdoc cref="IAppContext" />
public class AppContext : DbContext, IAppContext
{
    /// <summary>
    /// Конструктор контекста
    /// </summary>
    /// <param name="options">Настройки подключения к БД</param>
    public AppContext(DbContextOptions<AppContext> options)
        : base(options)
    {
    }

    /// <inheritdoc />
    public DbSet<Product> Products { get; set; }

    /// <inheritdoc />
    public DbSet<Choice> Choices { get; set; }

    /// <inheritdoc />
    public DbSet<Cover> Covers { get; set; }

    /// <inheritdoc />
    public DbSet<Question> Questions { get; set; }
}