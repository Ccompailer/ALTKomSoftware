using ProductService.Api.Commands.DTOs;
using ProductService.Api.Commands.Results;
using ProductService.Api.Queries.DTOs;
using ProductService.Persistence.Entities;

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

    /// <summary>
    /// Метод по созданию продукта в статусе <see cref="Product.ProductStatus.Draft"/>
    /// </summary>
    /// <param name="productInfo">Данные для создания продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Созданный продукт</returns>
    Task<CreateDraftProductResult> CreateDraftProductAsync(ProductDraftDto productInfo, CancellationToken cancellationToken);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="code"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<ProductDto> GetProductByCodeAsync(string code, CancellationToken ct);
}