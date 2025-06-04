using MediatR;
using ProductService.Api.Queries.DTOs;

namespace ProductService.Api.Queries;

public record GetProductByCodeQuery(string ProductCode) : IRequest<ProductDto>;