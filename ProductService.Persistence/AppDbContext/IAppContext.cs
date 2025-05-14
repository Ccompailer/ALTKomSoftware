using Microsoft.EntityFrameworkCore;
using ProductService.Persistence.Entities;

namespace ProductService.Persistence.AppDbContext;

/// <summary>
/// Контекст продуктового сервиса с сущностями
/// </summary>
public interface IAppContext : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Сущность "Продукт"
    /// </summary>
    DbSet<Product> Products { get; set; }

    /// <summary>
    /// Сущность "Вариант"
    /// </summary>
    DbSet<Choice> Choices { get; set; }

    /// <summary>
    /// Сущность "Страховое покрытие"
    /// </summary>
    DbSet<Cover> Covers { get; set; }

    /// <summary>
    /// Сущность "Вопрос"
    /// </summary>
    DbSet<Question> Questions { get; set; }

    /// <summary>
    /// Синхронный метод сохранения данных в БД
    /// </summary>
    /// <returns>Колличестов измененных строк в БД</returns>
    int SaveChanges();

    /// <summary>
    /// Асинхронный метод сохранения данных в БД
    /// </summary>
    /// <param name="cancellationToken">Токен отменый</param>
    /// <returns>Колличестов измененных строк в БД</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}