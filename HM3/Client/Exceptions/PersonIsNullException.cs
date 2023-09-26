namespace Client.Exceptions;

/// <summary> Исключение: Переданный объект типа Person не существует в памяти</summary>
public class PersonIsNullException : Exception
{
    public PersonIsNullException() :
        base("Переданный объект типа Person не существует в памяти")
    { }
}