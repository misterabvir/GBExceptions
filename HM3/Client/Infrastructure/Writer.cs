using Client.Exceptions;
using Client.Models;

namespace Client.Infrastructure;

/// <summary>
/// Запись данных
/// </summary>
internal class Writer
{
    /// <summary>
    /// Директория для хранения данных
    /// </summary>
    const string FOLDER_NAME = "Data";
    /// <summary>
    /// Расширение файлов для хранения данных
    /// </summary>
    const string FILE_EXTENSION = ".txt";
    
    /// <summary>
    /// Записывает данные в файл, если он существует дописывает новые
    /// </summary>
    /// <param name="person">Принимает данные о человеке</param>
    /// <exception cref="PersonIsNullException">Передан null</exception>
    public void Write(Person person)
    {
        if (person == null) throw new PersonIsNullException();

        if (!Directory.Exists(FOLDER_NAME))  
            Directory.CreateDirectory(FOLDER_NAME); 

        string filename = $"{FOLDER_NAME}/{person.LastName}{FILE_EXTENSION}";
        File.AppendAllText(filename, person.ToStringInline());
    }
}
