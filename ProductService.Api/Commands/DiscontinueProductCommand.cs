using MediatR;
using ProductService.Api.Commands.Results;

namespace ProductService.Api.Commands;

public record DiscontinueProductCommand(Guid ProductId) : IRequest<DiscontinueProductResult>;