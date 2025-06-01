using MediatR;
using ProductService.Api.Commands.Results;

namespace ProductService.Api.Commands;

public record ActivateProductCommand(Guid ProductId) : IRequest<ActivateProductResult>;