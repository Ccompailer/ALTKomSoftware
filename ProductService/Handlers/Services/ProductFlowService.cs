using ProductService.Api.Commands.DTOs;
using ProductService.Api.Commands.Results;
using ProductService.Persistence.AppDbContext;
using ProductService.Persistence.Entities;

namespace ProductService.Handlers.Services;

/// <summary>
/// Сервис бизнес-логики ProductService
/// </summary>
/// <param name="appContext">Контекст приложения для работы с БД</param>
/// <param name="logger">Логгер</param>
public class ProductFlowService(IAppContext appContext, ILogger<ProductFlowService> logger)
    : IProductFlowService
{
    private readonly ILogger<ProductFlowService> _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    private readonly IAppContext _appContext = appContext ?? throw new ArgumentNullException(nameof(appContext));

    /// <inheritdoc />
    public async Task ActiveProductAsync(Guid productId, CancellationToken ct)
    {
        var product = await _appContext.Products.FindAsync([productId], ct);
        if (product is null)
        {
            logger.LogInformation("Product [{ProductId}] doesn't exist", productId);
            return;
        }

        product.SetActiveStatus();
        await _appContext.SaveChangesAsync(ct);
    }

    /// <inheritdoc />
    public Task<CreateDraftProductResult> CreateDraftProductAsync(ProductDraftDto productInfo, CancellationToken cancellationToken)
    {
        var product = new Product(
            productInfo.Name,
            productInfo.Description,
            productInfo.Image,
            productInfo.Code,
            productInfo.MaxNumberOfInsured,
            productInfo.Icon);
    }
}