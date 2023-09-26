using Client.Infrastructure;
using Client.Models;

Reader reader = new Reader();
Parser parser = new Parser();
Writer writer = new Writer();

try
{
	string input = reader.ReadFromConsole();
    Person person = parser.Parse(input);
	writer.Write(person);
    Console.WriteLine(person);
    Console.WriteLine("Данные успешно добавлены");
}
catch (Exception exception)
{
	Console.Error.WriteLine(exception.GetType().Name);
	Console.Error.WriteLine(exception.Message);
	Console.Error.WriteLine(exception.StackTrace);
}


/*
 * INPUT: Иванов Иван Петрович 01.01.1990 1234567890 Мужской
 * OUTPUT: 
 *		Фамилия       : Иванов
 *		Имя           : Иван
 *		Отчетство     : Петрович
 *		Дата рождения : 01.01.1990
 *		Номер телефона: 1234567890
 *		Пол           : Мужской
 *		Данные успешно добавлены
 * INFILE: "Иванов.txt" 
 *		|Иванов Иван Петрович 01.01.1990 1234567890 Мужской
 *
 *********************************************************************** 
 *	 INPUT: Иванов 01.01.1990 Максим 1234567890 Мужской Сулейманович
 *	 OUTPUT: 
 *		Фамилия       : Иванов
 *		Имя           : Максим
 *		Отчетство     : Сулейманович
 *		Дата рождения : 01.01.1990
 *		Номер телефона: 1234567890
 *		Пол           : Мужской
 *		Данные успешно добавлены
 *	 INFILE: "Иванов.txt"
 *			|Иванов Иван Петрович 01.01.1990 1234567890 Мужской
 *			|Иванов Максим Сулейманович 01.01.1990 1234567890 Мужской
 *
 ***********************************************************************
 *	 INPUT: 07.03.1997 Михайлова Зинаида f 5555555555 Прокофьевна
 *	 OUTPUT: 
 *		Фамилия       : Михайлова
 *		Имя           : Зинаида
 *		Отчетство     : Прокофьевна
 *		Дата рождения : 07.03.1997
 *		Номер телефона: 5555555555
 *		Пол           : Женский
 *		Данные успешно добавлены
 *	 INFILE: "Михайлова.txt"
 *			|Михайлова Зинаида Прокофьевна 07.03.1997 5555555555 Женский
 *
 ***********************************************************************
 *	INPUT: 07.03.1997 Петрова Елена unnecessary f 4444444444 Дормидонтовна 
 *	OUTPUT:
 *		InputDataMoreThanRequiredException
 *		Введенных данных cлишком много
 *		   at Client.Infrastructure.Parser.Validate(String[] words) in ...\Client\Infrastructure\Parser.cs:line 39
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 12
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 13
 *
 ***********************************************************************
 *	INPUT: 07.03.1997 Петрова f 4444444444 Дормидонтовна 
 *	OUTPUT:
 *		InputDataLessThanRequiredException
 *		Введенных данных cлишком мало
 *		   at Client.Infrastructure.Parser.Validate(String[] words) in ...\Client\Infrastructure\Parser.cs:line 40
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 12
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 13
 *
 ***********************************************************************
 *	INPUT: 07.03.1997 Петрова Елена f wrong Дормидонтовна
 *	OUTPUT:
 *		PhoneNumberCantReadException
 *		Не удалось прочитать телефоный номер
 *		   at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 47
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 33
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 14
 ***********************************************************************
 *	INPUT: wrong Петрова Елена f 4444444444 Дормидонтовна
 *	OUTPUT:
 *		BirthDateCantReadException
 *		Не удалось прочитать дату рождения
 *		   at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 46
 *		   at Client.Infrastructure.Parser.Parse(String input) ...\Client\Infrastructure\Parser.cs:line 33
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 14
 ***********************************************************************
 *	INPUT: 07.03.1997 Петрова Елена S 4444444444 Дормидонтовна
 *	OUTPUT:
 *		...
 *		Не удалось прочитать пол
 *		   at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 48
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 33
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 14
 *
 ***********************************************************************
 *	INPUT: 07.03.1997 1111111111 1111111111 f 1111111111 1111111111
 *	OUTPUT:
 *		FirstNameCantReadException
 *		Не удалось прочитать имя
 *			at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 73
 *			at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 42
 *			at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 11
 * 
 ************************************************************************
 *	INPUT: 07.03.1997 1111111111 Петрова f 1111111111 1111111111
 *	OUTPUT:
 *		LastNameCantReadException
 *		Не удалось прочитать фамилию
 *		   at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 43
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 33
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 14
 * 
 ***********************************************************************
 *	INPUT: 07.03.1997 Кругов 1111111111 m 1111111111 Серафим
 *	OUTPUT:
 *		MiddleNameCantReadException
 *		Не удалось прочитать отчество
 *		   at Client.Models.Person.Validate() in ...\Client\Models\Person.cs:line 45
 *		   at Client.Infrastructure.Parser.Parse(String input) in ...\Client\Infrastructure\Parser.cs:line 33
 *		   at Program.<Main>$(String[] args) in ...\Client\Program.cs:line 14 
 */


