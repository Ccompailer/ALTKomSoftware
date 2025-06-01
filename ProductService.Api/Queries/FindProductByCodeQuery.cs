using MediatR;
using ProductService.Api.Queries.DTOs;

namespace ProductService.Api.Queries;

public record FindProductByCodeQuery(string ProductCode) : IRequest<ProductDto>;