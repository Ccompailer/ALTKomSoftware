namespace ProductService.Persistence.Entities;

/// <summary>
/// Сущность "Выбора"
/// </summary>
public class Choice
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public Choice()
    {
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="code">Код</param>
    /// <param name="label">Лэйбл</param>
    public Choice(string code, string label)
    {
        Code = code;
        Label = label;
    }

    /// <summary>
    /// Код
    /// </summary>
    public string Code { get; }

    /// <summary>
    /// Лэйбл
    /// </summary>
    public string Label { get; }
}