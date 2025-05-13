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
    /// Получение всех сущностей
    /// </summary>
    /// <returns>Не воз</returns>
    [HttpGet]
    public async Task GetAll()
    {
        // Todo
    }
}