using MediatR;
using ProductService.Api.Commands;
using ProductService.Api.Commands.Results;

namespace ProductService.Handlers.CommandHandlers;

/// <summary>
/// 
/// </summary>
public class ActivateProductCommandHandler : IRequestHandler<ActivateProductCommand, ActivateProductResult>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<ActivateProductResult> Handle(ActivateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}