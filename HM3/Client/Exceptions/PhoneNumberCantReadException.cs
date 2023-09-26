namespace Client.Exceptions;

/// <summary> Исключение: Не удалось прочитать телефоный номер</summary>
public class PhoneNumberCantReadException : Exception
{
    public PhoneNumberCantReadException() : 
        base("Не удалось прочитать телефоный номер") { }
}
