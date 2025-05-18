namespace ProductService.Persistence.Entities;

/// <summary>
/// Сущность "Покрытие"
/// </summary>
public class Cover
{
    /// <summary>
    /// Конструктор для EF Core
    /// </summary>
    public Cover()
    {
    }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="code">Код</param>
    /// <param name="name">Имя</param>
    /// <param name="description">Описание (обоснование)</param>
    /// <param name="isOptional">Является ли опциональным покрытием</param>
    /// <param name="sumInsured">Страховая сумма</param>
    public Cover(string code, string name, string description, bool isOptional, decimal? sumInsured)
    {
        Id = Guid.NewGuid();
        Code = code;
        Name = name;
        IsOptional = isOptional;
        Description = description;
        SumInsured = sumInsured;
    }

    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Код
    /// </summary>
    public string Code { get; }

    /// <summary>
    /// Является ли опциональным покрытием
    /// </summary>
    public bool IsOptional { get; }

    /// <summary>
    /// Описание (обоснование)
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Страховая сумма
    /// </summary>
    public decimal? SumInsured { get; }
}