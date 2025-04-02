using ProductService.Api.Abstractions.DTOs;

namespace ProductService.Api.Commands.DTOs;

public record ProductDraftDto(
    string Code,
    string Name,
    string Image,
    string Description,
    int MaxNumberOfInsured,
    string Icon,
    IList<CoverDto> Covers,
    IList<AbstractQuestionDto> Questions);