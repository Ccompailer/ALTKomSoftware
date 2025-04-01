using ProductService.Abstractions.Queries.DTOs;

namespace ProductService.Api.Queries.DTOs.Questions;

public record NumericQuestionDto(
    string QuestionCode,
    int Index,
    string Text) : AbstractQuestionDto(QuestionCode, Index, Text)
{
    public override QuestionType QuestionType => QuestionType.Numeric;
}