namespace ProductService.Api.Commands.DTOs;

public record CoverDto(
    string Code,
    string Name,
    string Description,
    bool Optional,
    decimal? SumInsured);