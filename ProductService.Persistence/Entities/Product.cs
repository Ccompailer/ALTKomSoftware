namespace ProductService.Persistence.Entities;

/// <summary>
/// Сущность "Продукт"
/// </summary>
public class Product
{
    /// <summary>
    /// Перечесление с возможными статусами продукта
    /// </summary>
    public enum ProductStatus
    {
        /// <summary>
        /// Продукт находится в разработке или черновике, еще не активен.
        /// </summary>
        Draft,

        /// <summary>
        /// Продукт активен и доступен для использования или продажи.
        /// </summary>
        Active,

        /// <summary>
        /// Продукт снят с производства или больше не поддерживается/не продается.
        /// </summary>
        Discontinued,
    }

    /// <summary>
    /// Конструктор для EF Core
    /// </summary>
    public Product()
    {
    }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="name">Имя продукта</param>
    /// <param name="description">Описание продукта</param>
    /// <param name="image">Фото</param>
    /// <param name="code">Уникальный код продукта</param>
    /// <param name="maxNumberOfInsured">Максимальное количество застрахованных объектов по данному продукту</param>
    /// <param name="productIcon">Иконка, представляющая продукт</param>
    public Product(
        string name,
        string description,
        string image,
        string code,
        int maxNumberOfInsured,
        string productIcon)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Image = image;
        Code = code;
        MaxNumberOfInsured = maxNumberOfInsured;
        ProductIcon = productIcon;
    }

    /// <summary>
    /// Уникальный идентификатор продукта
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Название продукта
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Код продукта
    /// </summary>
    public string Code { get; }

    /// <summary>
    /// Описание продукта
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Изображение продукта
    /// </summary>
    public string Image { get; }

    /// <summary>
    /// Список покрытий, доступных по данному продукту
    /// </summary>
    public IList<Cover> Covers { get; }

    /// <summary>
    /// Список вопросов, связанных с данным продуктом (например, для анкеты)
    /// </summary>
    public IList<Question> Questions { get; }

    /// <summary>
    /// Максимальное количество застрахованных объектов, разрешенное по продукту
    /// </summary>
    public int MaxNumberOfInsured { get; }

    /// <summary>
    /// Иконка продукта
    /// </summary>
    public string ProductIcon { get; }
}