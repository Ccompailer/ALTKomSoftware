namespace ProductService.Persistence.Entities;

/// <summary>
/// Сущность "Вопрос"
/// </summary>
public class Question
{
    /// <summary>
    /// Конструктор для EF Core
    /// </summary>
    public Question()
    {
    }

    /// <summary>
    /// Конструктор с параметрами
    /// </summary>
    /// <param name="code">Код вопроса</param>
    /// <param name="text">Текст вопроса</param>
    /// <param name="index">Порядковый номер вопроса</param>
    public Question(string code, string text, int index)
    {
        Id = Guid.NewGuid();
        Code = code;
        Text = text;
        Index = index;
    }

    /// <summary>
    /// Уникальный идентификатор вопроса
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Код вопроса
    /// </summary>
    public string Code { get; protected set; }

    /// <summary>
    /// Порядковый номер вопроса в списке
    /// </summary>
    public int Index { get; protected set; }

    /// <summary>
    /// Текст вопроса
    /// </summary>
    public string Text { get; protected set; }

    /// <summary>
    /// Продукт, к которому относится данный вопрос
    /// </summary>
    public Product Product { get; protected set; }
}

/// <summary>
/// Представляет вопрос с выбором ответа из предопределенного списка.
/// Наследует от базового класса <see cref="Question"/>
/// </summary>
public class ChoiceQuestion : Question
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="ChoiceQuestion"/>
    /// </summary>
    public ChoiceQuestion()
    {
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="ChoiceQuestion"/>
    /// с заданными параметрами и списком вариантов выбора
    /// </summary>
    /// <param name="code">Код вопроса (передается в базовый конструктор)</param>
    /// <param name="text">Текст вопроса (передается в базовый конструктор)</param>
    /// <param name="index">Порядковый номер вопроса (передается в базовый конструктор)</param>
    /// <param name="choices">Список вариантов выбора для данного вопроса</param>
    public ChoiceQuestion(
        string code,
        string text,
        int index,
        List<Choice> choices)
        : base(code, text, index)
    {
       Choices = choices;
    }

    /// <summary>
    /// Список вариантов выбора (ответов) для данного вопроса
    /// </summary>
    public IList<Choice> Choices { get; set; }

    /// <summary>
    /// Возвращает предопределенный список вариантов выбора "Да" / "Нет"
    /// </summary>
    /// <returns>Список объектов <see cref="Choice"/> для вариантов "Да" и "Нет"</returns>
    public static List<Choice> YesNoChoice()
    {
        return
        [
            new Choice("YES", "Yes"),
            new Choice("NO", "No")
        ];
    }
}

/// <summary>
/// Представляет вопрос, требующий ответа в формате даты.
/// Наследует от базового класса <see cref="Question"/>
/// </summary>
public class DateQuestion : Question
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="DateQuestion"/> с заданными параметрами
    /// </summary>
    /// <param name="code">Код вопроса (передается в базовый конструктор)</param>
    /// <param name="text">Текст вопроса (передается в базовый конструктор)</param>
    /// <param name="index">Порядковый номер вопроса (передается в базовый конструктор)</param>
    public DateQuestion(string code, string text, int index)
        : base(code, text, index)
    {
    }
}

/// <summary>
/// Представляет вопрос, требующий ответа в числовом формате.
/// Наследует от базового класса <see cref="Question"/>
/// </summary>
public class NumericQuestion : Question
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="NumericQuestion"/> с заданными параметрами
    /// </summary>
    /// <param name="code">Код вопроса (передается в базовый конструктор)</param>
    /// <param name="text">Текст вопроса (передается в базовый конструктор)</param>
    /// <param name="index">Порядковый номер вопроса (передается в базовый конструктор)</param>
    public NumericQuestion(string code, string text, int index)
        : base(code, text, index)
    {
    }
}