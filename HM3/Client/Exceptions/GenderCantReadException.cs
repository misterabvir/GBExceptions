namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать пол</summary>
public class GenderCantReadException : Exception
{
    public GenderCantReadException() : 
        base("Не удалось прочитать пол") { }
}
