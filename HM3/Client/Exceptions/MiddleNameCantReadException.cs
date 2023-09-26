namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать отчество</summary>
public class MiddleNameCantReadException : Exception
{
    public MiddleNameCantReadException() : 
        base("Не удалось прочитать отчество") { }
}
