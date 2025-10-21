using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductService.Api.Commands;
using ProductService.Api.Queries;
using ProductService.Api.Queries.DTOs;
using ProductService.Handlers.Services;

namespace ProductService.Controllers.v1;

/// <summary>
/// Контроллер сервиса продуктов
/// </summary>
[Route("api/v1/product")]
[ApiController]
public class ProductServiceController(IMediator mediator)
    : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    /// <summary>
    /// Получение всех продуктов
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Возвращает все продукты</returns>
    [HttpGet("/all")]
    [ProducesResponseType(typeof(IReadOnlyCollection<ProductDto>), StatusCodes.Status200OK)]
    public async Task<IResult> GetAll(CancellationToken cancellationToken)
    {
        var allProducts = await _mediator.Send(new GetAllProductsQuery(), cancellationToken);

        return Results.Ok(allProducts);
    }

    /// <summary>
    /// Получение продукта по коду
    /// </summary>
    /// <param name="code">Код продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Не воз</returns>
    [HttpGet("{code}")]
    [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IResult> GetByCode(string code, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(
            new GetProductByCodeQuery(code), cancellationToken);

        return result.Equals(ProductFlowServiceHelper.CreateDefaultProductDto())
            ? Results.NotFound(result)
            : Results.Ok(result);
    }

    /// <summary>
    /// Активация продукта
    /// </summary>
    /// <param name="request">Запрос на изменение активацию продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Активированный продукт</returns>
    [HttpPatch("/activate")]
    [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
    public async Task<IResult> Activate(
        [FromQuery] ActivateProductCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);

        return Results.Ok(result);
    }

    /// <summary>
    /// Создание draft-продукта
    /// </summary>
    /// <param name="request">Запрос на создание продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Идентификатор нового продукта</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
    public async Task<IResult> CreateDraft(
        [FromBody] CreateDraftProductCommand request,
        CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);

        return Results.Ok(result);
    }

    /// <summary>
    /// Снятие продукта с производства.
    /// </summary>
    /// <param name="productId">Идентификатор продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>HTTP 200</returns>
    [HttpPatch("/discontinue/{productId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IResult> Discontinue(Guid productId, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(new DiscontinueProductCommand(productId), cancellationToken);

        return Results.Ok(result);
    }
}