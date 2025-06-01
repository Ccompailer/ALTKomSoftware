namespace ProductService.Api.Queries.DTOs;

public record CoverDto(
    string Code,
    string Name,
    string Description,
    bool Optional,
    decimal? SumInsured);