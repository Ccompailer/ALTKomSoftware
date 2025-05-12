using ProductService.Api.Abstractions.DTOs;

namespace ProductService.Api.Queries.DTOs.Questions;

public record ChoiceQuestionDto(
    string QuestionCode,
    int Index,
    string Text,
    IList<ChoiceDto> Choices) : AbstractQuestionDto(QuestionCode, Index, Text)
{
    public override QuestionType QuestionType => QuestionType.Choice;
}