using Client.Exceptions;
using Client.Extensions;
using System.Text;

namespace Client.Models;

/// <summary>
/// Хранит данные очеловеке
/// </summary>
internal class Person
{
    /// <summary> Фамилия </summary>
    public string LastName { get; set; } = string.Empty;
    
    /// <summary> Имя </summary>
    public string FirstName { get; set; } = string.Empty;
    
    /// <summary> Отчество </summary>
    public string MiddleName { get; set; } = string.Empty;
    
    /// <summary> Телефонный номер </summary>
    public string PhoneNumber { get; set; } = string.Empty;
    
    /// <summary> Дата рождения </summary>
    public string BirthDate { get; set; } = string.Empty;
    
    /// <summary> Пол </summary>
    public string Gender { get; set; } = string.Empty;

    /// <summary>
    /// Отформатированный текст для вывода на консоль
    /// </summary>
    /// <returns>Отформатированный текст</returns>
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Фамилия       : {LastName}");
        builder.AppendLine($"Имя           : {FirstName}");
        builder.AppendLine($"Отчетство     : {MiddleName}");
        builder.AppendLine($"Дата рождения : {BirthDate}");
        builder.AppendLine($"Номер телефона: {PhoneNumber}");
        builder.AppendLine($"Пол           : {Gender}\r\n");
        return builder.ToString();
    }
    /// <summary>
    /// Отформатированный текст для записи в файл
    /// </summary>
    /// <returns>Отформатированный текст в одну строку</returns>
    public string ToStringInline()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append($"{LastName} ");
        builder.Append($"{FirstName} ");
        builder.Append($"{MiddleName} ");
        builder.Append($"{BirthDate} ");
        builder.Append($"{PhoneNumber} ");
        builder.Append($"{Gender}\r\n");
        return builder.ToString();
    }

    /// <summary>
    /// Валидация полноты данных
    /// </summary>
    /// <exception cref="LastNameCantReadException">Свойство Фамилия пустая</exception>
    /// <exception cref="FirstNameCantReadException">Свойство Имя пустое</exception>
    /// <exception cref="MiddleNameCantReadException">Свойство Отчество пустое</exception>
    /// <exception cref="BirthDateCantReadException">Свойство Дата рождения путое</exception>
    /// <exception cref="PhoneNumberCantReadException">Свойство Телефонный номер пустое</exception>
    /// <exception cref="GenderCantReadException">Свойство Пол пустое</exception>
    public void Validate()
    {
        if (LastName.IsNullOrEmpty()) throw new LastNameCantReadException();
        if (FirstName.IsNullOrEmpty()) throw new FirstNameCantReadException();
        if (MiddleName.IsNullOrEmpty()) throw new MiddleNameCantReadException();
        if (BirthDate.IsNullOrEmpty()) throw new BirthDateCantReadException();
        if (PhoneNumber.IsNullOrEmpty()) throw new PhoneNumberCantReadException();
        if (Gender.IsNullOrEmpty()) throw new GenderCantReadException();
    }
}
