using MediatR;
using ProductService.Api.Commands.Results;

namespace ProductService.Api.Commands;

public record CreateProductDraftCommand() : IRequest<CreateProductDraftResult>;