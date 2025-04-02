using ProductService.Api.Abstractions.DTOs;

namespace ProductService.Api.Queries.DTOs;

public record ProductDto(
    string Code,
    string Name,
    string Image,
    string Description,
    int MaxNumberOfInsured,
    string Icons,
    IList<AbstractQuestionDto> Questions,
    IList<CoverDto> Covers);