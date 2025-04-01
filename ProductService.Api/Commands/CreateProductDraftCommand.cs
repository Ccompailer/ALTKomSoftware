using MediatR;
using ProductService.Api.Commands.DTOs;
using ProductService.Api.Commands.Results;

namespace ProductService.Api.Commands;

public record CreateProductDraftCommand(ProductDraftDto ProductDraft) : IRequest<CreateProductDraftResult>;