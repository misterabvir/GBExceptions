namespace Client.Exceptions;

/// <summary> Исключение: Данных слишком много</summary>
public class InputDataMoreThanRequiredException : Exception {
    public InputDataMoreThanRequiredException() : 
        base("Введенных данных cлишком много") { }
}
