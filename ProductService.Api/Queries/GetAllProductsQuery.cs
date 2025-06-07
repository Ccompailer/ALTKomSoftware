using MediatR;
using ProductService.Api.Queries.DTOs;

namespace ProductService.Api.Queries;

public record GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
{
}