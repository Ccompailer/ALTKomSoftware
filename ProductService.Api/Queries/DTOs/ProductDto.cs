using ProductService.Api.Abstractions.DTOs;

namespace ProductService.Api.Queries.DTOs;

public record ProductDto(
    string Code,
    string Name,
    string Image,
    string Description,
    int MaxNumberOfInsured,
    string Icon,
    IList<AbstractQuestionDto> Questions,
    IList<CoverDto> Covers)
{
    /// <inheritdoc />
    public virtual bool Equals(ProductDto? other)
    {
        if (other is null)
        {
            return false;
        }

        return other.Code == Code &&
               other.Covers.Count == Covers.Count &&
               other.Description == Description &&
               other.Icon == Icon &&
               other.MaxNumberOfInsured == MaxNumberOfInsured &&
               other.Name == Name &&
               other.Image == Image &&
               other.Questions.Count == Questions.Count;
    }
}
