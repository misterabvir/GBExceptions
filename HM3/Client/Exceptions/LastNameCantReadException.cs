namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать фамилию</summary>
public class LastNameCantReadException : Exception
{
    public LastNameCantReadException() : 
        base("Не удалось прочитать фамилию") { }
}
