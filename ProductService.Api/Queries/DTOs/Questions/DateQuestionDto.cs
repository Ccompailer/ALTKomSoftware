using ProductService.Api.Abstractions.DTOs;

namespace ProductService.Api.Queries.DTOs.Questions;

public record DateQuestionDto(
    string QuestionCode,
    int Index,
    string Text) : AbstractQuestionDto(QuestionCode, Index, Text)
{
    public override QuestionType QuestionType => QuestionType.Date;
}