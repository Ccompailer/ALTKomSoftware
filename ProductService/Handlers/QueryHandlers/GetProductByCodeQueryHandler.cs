using MediatR;
using ProductService.Api.Queries;
using ProductService.Api.Queries.DTOs;
using ProductService.Handlers.Services;
using ProductService.Persistence.AppDbContext;

namespace ProductService.Handlers.QueryHandlers;

/// <summary>
/// 
/// </summary>
/// <param name="appContext"></param>
/// <param name="flowService"></param>
public class GetProductByCodeQueryHandler(
    IAppContext appContext,
    IProductFlowService flowService
    ) : IRequestHandler<GetProductByCodeQuery, ProductDto>
{
    private readonly IAppContext _appContext = appContext ?? throw new ArgumentNullException(nameof(appContext));
    private readonly IProductFlowService _flowService = flowService ?? throw new ArgumentNullException(nameof(flowService));
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<ProductDto> Handle(GetProductByCodeQuery request, CancellationToken cancellationToken)
    {
        var product = await _flowService.GetProductByCodeAsync(request.ProductCode, cancellationToken);

        //TODO: Сделать проверку на то что если это Default Dto,
        //то значит не был найден продукт и там пустой респонс
    }

}