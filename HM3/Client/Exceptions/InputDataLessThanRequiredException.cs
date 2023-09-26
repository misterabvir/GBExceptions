namespace Client.Exceptions;

/// <summary> Исключение: Данных слишком мало</summary>
public class InputDataLessThanRequiredException : Exception
{
    public InputDataLessThanRequiredException() : 
        base("Введенных данных cлишком мало") { }
}
