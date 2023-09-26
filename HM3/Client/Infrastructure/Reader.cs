
using System.Text;

namespace Client.Infrastructure;

/// <summary>
/// Чтение данных
/// </summary>
internal class Reader
{
    /// <summary>
    /// Читает данные строки из консоли, в кодировке unicode
    /// </summary>
    /// <returns>Введенная строка</returns>
    public string ReadFromConsole()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        return Console.ReadLine() ?? string.Empty;
    }
}
