using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers.v1;

/// <summary>
/// Контроллер сервиса продуктов
/// </summary>
[Route("api/v1/product")]
[ApiController]
public class ProductServiceController : ControllerBase
{
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
    /// <returns>Не воз</returns>
    [HttpPatch("/activate")]
    public async Task Activate()
    {
        // Todo
    }

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