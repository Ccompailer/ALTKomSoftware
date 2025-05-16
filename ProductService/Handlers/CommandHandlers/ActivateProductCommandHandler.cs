using MediatR;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;
using ProductService.Persistence.AppDbContext;

namespace ProductService.Handlers.CommandHandlers;

/// <summary>
/// Обработчик команды по созданию продукта
/// </summary>
public class ActivateProductCommandHandler : IRequestHandler<ActivateProductCommand, ActivateProductResult>
{
    private readonly ILogger<ActivateProductCommandHandler> _logger;
    private readonly IAppContext _appContext;

    /// <summary>
    /// Конструктор класс обработчика
    /// </summary>
    /// <param name="appContext">Контекст ProductService</param>
    /// <param name="logger">Логгер для обработчика</param>
    public ActivateProductCommandHandler(IAppContext appContext, ILogger<ActivateProductCommandHandler> logger)
    {
        _appContext = appContext;
        _logger = logger;
    }

    /// <summary>
    /// Основной метод обработчика
    /// </summary>
    /// <param name="command">Команда на создание с параметрами</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Созданный продукт</returns>
    public Task<ActivateProductResult> Handle(ActivateProductCommand command, CancellationToken cancellationToken)
    {
        
    }
}