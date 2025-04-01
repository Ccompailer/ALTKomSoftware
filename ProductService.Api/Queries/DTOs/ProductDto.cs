namespace ProductService.Api.Queries.DTOs;

public record ProductDto(
    string Code,
    string Name,
    string Image,
    string Description,
    IList<CoverDto> Covers);