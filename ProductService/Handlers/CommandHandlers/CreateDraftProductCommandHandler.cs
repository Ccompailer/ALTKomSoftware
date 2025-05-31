using MediatR;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;
using ProductService.Handlers.Services;

namespace ProductService.Handlers.CommandHandlers;

/// <summary>
/// афыафы
/// </summary>
/// <param name="productFlowService">афыа</param>
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
    public Task<CreateDraftProductResult> Handle(CreateDraftProductCommand request, CancellationToken cancellationToken)
    {
        // string Code,
        // string Name,
        // string Image,
        // string Description,
        // int MaxNumberOfInsured,
        // string Icon,
        //     IList<CoverDto> Covers,
        // IList<AbstractQuestionDto> Questions

        request.ProductDraft.
    }
}