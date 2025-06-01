using MediatR;

namespace ProductService.Api.Commands;

public record DiscontinueProductCommand(Guid ProductId) : IRequest<DiscontinueProductCommand>;