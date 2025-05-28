namespace ProductService.Handlers.Services;

/// <summary>
/// Интерфейс сервиса бизнес-логики ProductService
/// </summary>
public interface IProductFlowService
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="productId">Идентификатор продукта</param>
    /// <param name="ct">Токен отмены <see cref="CancellationToken"/></param>
    /// <returns><see cref="Task"/></returns>
    Task ActiveProductAsync(Guid productId, CancellationToken ct);
}