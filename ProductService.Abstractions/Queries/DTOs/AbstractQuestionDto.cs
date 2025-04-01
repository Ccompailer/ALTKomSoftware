namespace ProductService.Abstractions.Queries.DTOs;

public abstract record AbstractQuestionDto(
    string QuestionCode,
    int Index,
    string Text)
{
    public abstract QuestionType QuestionType { get; }
}

public enum QuestionType
{
    Choice,
    Date,
    Numeric
}