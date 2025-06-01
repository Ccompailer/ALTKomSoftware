using MediatR;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;
using ProductService.Handlers.Services;

namespace ProductService.Handlers.CommandHandlers;

/// <summary>
/// Класс обработчика создания нового продукта
/// </summary>
/// <param name="productFlowService">Сервис работы с продуктами и хэлпер классами</param>
public class CreateDraftProductCommandHandler(IProductFlowService productFlowService)
    : IRequestHandler<CreateDraftProductCommand, CreateDraftProductResult>
{
    private readonly IProductFlowService _productFlowService = productFlowService;

    /// <summary>
    /// Основной метод обработчика
    /// </summary>
    /// <param name="request">Команда на создание продукта</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Созданный продукт</returns>
    public async Task<CreateDraftProductResult> Handle(CreateDraftProductCommand request, CancellationToken cancellationToken)
    {
       var result = await _productFlowService.CreateDraftProductAsync(request.ProductDraft, cancellationToken);

       return result;
    }
}