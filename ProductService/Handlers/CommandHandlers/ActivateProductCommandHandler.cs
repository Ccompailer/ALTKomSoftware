using MediatR;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;
using ProductService.Handlers.Services;
using ProductService.Persistence.AppDbContext;

namespace ProductService.Handlers.CommandHandlers;

/// <summary>
/// Обработчик команды по созданию продукта
/// </summary>
public class ActivateProductCommandHandler : IRequestHandler<ActivateProductCommand, ActivateProductResult>
{
    private readonly IProductFlowService _flowService;
    private readonly ILogger<ActivateProductCommandHandler> _logger;
    private readonly IAppContext _appContext;

    /// <summary>
    /// Конструктор класс обработчика
    /// </summary>
    /// <param name="appContext">Контекст ProductService</param>
    /// <param name="logger">Логгер для обработчика</param>
    /// <param name="flowService">Сервис бизнес-логики ProductService</param>
    public ActivateProductCommandHandler(
        IAppContext appContext,
        ILogger<ActivateProductCommandHandler> logger,
        IProductFlowService flowService)
    {
        _appContext = appContext;
        _logger = logger;
        _flowService = flowService;
    }

    /// <summary>
    /// Основной метод обработчика
    /// </summary>
    /// <param name="command">Команда на создание с параметрами</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Созданный продукт</returns>
    public async Task<ActivateProductResult> Handle(ActivateProductCommand command, CancellationToken cancellationToken)
    {
        await _flowService.ActiveProductAsync(command.ProductId, cancellationToken);

        return new ActivateProductResult(command.ProductId);
    }
}