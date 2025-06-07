using System.Reflection;
using ProductService.Api.Abstractions.DTOs;
using ProductService.Api.Commands.DTOs;
using ProductService.Api.Queries.DTOs;
using ProductService.Api.Queries.DTOs.Questions;
using ProductService.Persistence.Entities;
using CoverDto = ProductService.Api.Commands.DTOs.CoverDto;

namespace ProductService.Handlers.Services;

/// <summary>
/// Класс хэлпер для ProductFlowService
/// </summary>
public static class ProductFlowServiceHelper
{
    /// <summary>
    /// Маппер для создание нового продукта
    /// </summary>
    /// <param name="productInfo">Данные для создания продукта</param>
    /// <returns>Новый продукт</returns>
    public static Product ToProductMapper(this ProductDraftDto productInfo)
    {
        var product = new Product(
            productInfo.Name,
            productInfo.Description,
            productInfo.Image,
            productInfo.Code,
            productInfo.MaxNumberOfInsured,
            productInfo.Icon);

        product.AddCovers(productInfo.Covers.ToCoversMapper());
        product.AddQuestions(productInfo.Questions.ToQuestionsMapper());

        return product;
    }

    /// <summary>
    /// Маппер для создания покрытий продукта
    /// </summary>
    /// <param name="coverInfos">Данные для создания покрытия</param>
    /// <returns>Новые покрытия</returns>
    public static IReadOnlyCollection<Cover> ToCoversMapper(this ICollection<CoverDto> coverInfos)
        => coverInfos.Select(cd =>
            new Cover(
                cd.Code,
                cd.Name,
                cd.Description,
                cd.Optional,
                cd.SumInsured)).ToList();

    /// <summary>
    /// Маппер для создания вопросов
    /// </summary>
    /// <param name="questionInfos">Данные для создания вопросов</param>
    /// <returns>Новые вопросы</returns>
    public static IReadOnlyCollection<Question> ToQuestionsMapper(this ICollection<AbstractQuestionDto> questionInfos)
    {
        var result = questionInfos.Select<AbstractQuestionDto, Question>(qi =>
            qi switch
            {
                ChoiceQuestionDto choiceQuestion => new ChoiceQuestion(
                    choiceQuestion.QuestionCode,
                    choiceQuestion.Text,
                    choiceQuestion.Index,
                    ToChoicesMapper(choiceQuestion.Choices)),
                NumericQuestionDto numericQuestion => new NumericQuestion(
                    numericQuestion.QuestionCode,
                    numericQuestion.Text,
                    numericQuestion.Index),
                DateQuestionDto dateQuestion => new DateQuestion(
                    dateQuestion.QuestionCode,
                    dateQuestion.Text,
                    dateQuestion.Index),
                _ => throw new ArgumentOutOfRangeException(nameof(qi), qi, null)
            });

        return result.ToList();

        static List<Choice> ToChoicesMapper(ICollection<ChoiceDto> choiceInfos)
            => choiceInfos
                .Select(ci => new Choice(ci.Code, ci.Label))
                .ToList();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="product"></param>
    /// <returns></returns>
    public static ProductDto ToProductDto(this Product product)
    {
        return new ProductDto(
            product.Code,
            product.Name,
            product.Image,
            product.Description,
            product.MaxNumberOfInsured,
            product.ProductIcon,
            ToQuestionDtos(product.QuestionsReadOnly),
            product.CoversReadOnly);

        static List<AbstractQuestionDto> ToQuestionDtos(IReadOnlyList<Question> questions)
        {
            return questions.Select<Question, AbstractQuestionDto>(q =>
                q switch
                {
                    NumericQuestion => new NumericQuestionDto(q.Code, q.Index, q.Text),
                    DateQuestion => new DateQuestionDto(q.Code, q.Index, q.Text),
                    ChoiceQuestion => new ChoiceQuestionDto(q.Code, q.Index, q.Text, new List<ChoiceDto>())
                }).ToList();
        }
    }
}