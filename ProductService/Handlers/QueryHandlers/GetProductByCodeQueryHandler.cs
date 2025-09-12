using MediatR;
using ProductService.Api.Queries;
using ProductService.Api.Queries.DTOs;
using ProductService.Handlers.Services;
using ProductService.Persistence.AppDbContext;

namespace ProductService.Handlers.QueryHandlers;

/// <summary>
/// Класс обработчика запроса
/// </summary>
/// <param name="appContext">Контекс приложения для работы с БД</param>
/// <param name="flowService">Сервис бизнес-логики ProductService</param>
public class GetProductByCodeQueryHandler(
    IAppContext appContext,
    IProductFlowService flowService
    ) : IRequestHandler<GetProductByCodeQuery, ProductDto>
{
    private readonly IAppContext _appContext = appContext ?? throw new ArgumentNullException(nameof(appContext));
    private readonly IProductFlowService _flowService = flowService ?? throw new ArgumentNullException(nameof(flowService));

    /// <summary>
    /// Метод обработки запроса
    /// </summary>
    /// <param name="query">Запрос</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Объект продукта</returns>
    public async Task<ProductDto> Handle(GetProductByCodeQuery query, CancellationToken cancellationToken)
    {
        var product = await _flowService.GetProductByCodeAsync(query.ProductCode, cancellationToken);

        return product;
    }

}