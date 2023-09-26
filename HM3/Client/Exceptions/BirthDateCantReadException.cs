namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать дату рождения</summary>
public class BirthDateCantReadException : Exception
{
    public BirthDateCantReadException() :
        base("Не удалось прочитать дату рождения") { }
}
