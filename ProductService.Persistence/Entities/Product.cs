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
        Status = ProductStatus.Draft;
        Covers = new List<Cover>();
        Questions = new List<Question>();
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
    /// Максимальное количество застрахованных объектов, разрешенное по продукту
    /// </summary>
    public int MaxNumberOfInsured { get; }

    /// <summary>
    /// Иконка продукта
    /// </summary>
    public string ProductIcon { get; }

    /// <summary>
    /// Список покрытий, доступных по данному продукту
    /// </summary>
    public IReadOnlyList<Cover> CoversReadOnly => Covers.AsReadOnly();

    /// <summary>
    /// Список вопросов, связанных с данным продуктом (например, для анкеты)
    /// </summary>
    public IReadOnlyList<Question> QuestionsReadOnly => Questions.AsReadOnly();

    /// <summary>
    /// Статус продукта
    /// </summary>
    public ProductStatus Status { get; private set; }

    private IList<Cover> Covers { get; }

    private IList<Question> Questions { get; }

    /// <summary>
    /// Setter для установки статуса <see cref="ProductStatus.Active"/>
    /// </summary>
    public void SetActiveStatus()
    {
        IsDraft();
        Status = ProductStatus.Active;
    }

    /// <summary>
    /// Добавление покрытий по продукту
    /// </summary>
    /// <param name="covers">Покрытия по продукту</param>
    public void AddCovers(IReadOnlyCollection<Cover> covers)
        => Covers.ToList().AddRange(covers);

    /// <summary>
    /// Добавление вопросв по продукту
    /// </summary>
    /// <param name="questions">Вопросы по продукту</param>
    public void AddQuestions(IReadOnlyCollection<Question> questions)
        => Questions.ToList().AddRange(questions);

    private void IsDraft()
    {
        if (Status is not ProductStatus.Draft)
        {
            throw new ApplicationException("Only draft version can be modified and activated");
        }
    }
}