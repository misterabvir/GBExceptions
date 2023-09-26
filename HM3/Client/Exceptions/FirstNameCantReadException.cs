namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать имя</summary>
public class FirstNameCantReadException : Exception
{
    public FirstNameCantReadException() : 
        base("Не удалось прочитать имя") { }
}
