namespace Client.Extensions;

/// <summary>
/// Расширения для работы со строками
/// </summary>
internal static class StringExtensions
{
    const int PHONE_NUMBER_LENGTH = 10;
    const string DATETIME_FORMAT = "dd.MM.yyyy";
    const string GENDER_MALE = "m";
    const string GENDER_FEMALE = "m";

    /// <summary>
    /// Является ли строка телефонным номером
    /// </summary>
    /// <param name="word">Строка</param>
    public static bool IsPhoneNumber(this string word) =>
        word.All(char.IsDigit) && word.Length == PHONE_NUMBER_LENGTH;

    /// <summary>
    /// Является ли строка датой ("dd.MM.yyyy")
    /// </summary>
    /// <param name="word">Строка</param>
    public static bool IsDate(this string word) =>
        DateTime.TryParseExact(word, DATETIME_FORMAT, null, System.Globalization.DateTimeStyles.None, out _);

    /// <summary>
    /// Является ли строка указанием на гендер ("f" или "m")
    /// </summary>
    /// <param name="word">Строка</param>
    public static bool IsGender(this string word) =>
        word == GENDER_MALE || word == GENDER_FEMALE;

    /// <summary>
    /// Является ли строка пустой или null
    /// </summary>
    /// <param name="word">Строка</param>
    public static bool IsNullOrEmpty(this string word) => string.IsNullOrEmpty(word);
}
