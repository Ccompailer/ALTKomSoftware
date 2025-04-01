namespace ProductService.Api.Commands.DTOs;

public record ProductDraftDto(
    string Code,
    string Name,
    string Image,
    string Description,
    int MaxNumberOfInsured,
    string Icon);