using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;

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
    /// <returns>Не воз</returns>
    [HttpGet("/all")]
    public async Task GetAll()
    {
        // Todo
    }

    /// <summary>
    /// Получение продукта по коду
    /// </summary>
    /// <param name="code">Код продукта</param>
    /// <returns>Не воз</returns>
    [HttpGet("{code}")]
    public async Task GetByCode(string code)
    {
        // Todo
    }

    /// <summary>
    /// Активация продукта
    /// </summary>
    /// <param name="request">Запрос на изменение активацию продукта</param>
    /// <returns>Активированный продукт</returns>
    [HttpPatch("/activate")]
    public async Task<ActivateProductResult> Activate([FromQuery] ActivateProductCommand request)
        => await _mediator.Send(request);

    /// <summary>
    /// Создание draft-продукта
    /// </summary>
    /// <returns>Не воз</returns>
    [HttpPost]
    public async Task CreateDraft()
    {
        // Todo
    }

    /// <summary>
    /// Получение продукта по коду
    /// </summary>
    /// <returns>Не воз</returns>
    [HttpPatch("/discontinue")]
    public async Task Discontinue()
    {
        // Todo
    }
}