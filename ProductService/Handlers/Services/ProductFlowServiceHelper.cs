using ProductService.Api.Commands.DTOs;
using ProductService.Persistence.Entities;

namespace ProductService.Handlers.Services;

/// <summary>
/// 
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
            productInfo.Icon)
        {
            Covers = productInfo
                .Covers
                .ToCoverMapper()
                .ToList(),
        };
    }

    /// <summary>
    /// Маппер для создание нового продукта
    /// </summary>
    /// <param name="coverInfos">Данные для создания покрытия</param>
    /// <returns>Новые покрытия</returns>
    public static IReadOnlyCollection<Cover> ToCoverMapper(this ICollection<CoverDto> coverInfos)
    {
        
    }
}