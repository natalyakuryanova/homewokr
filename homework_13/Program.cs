Console.WriteLine("Введите число");
string a = Console.ReadLine() ?? " ";

//-------- Проверка ----------------//
int num = int.Parse(a);
if (num < 100)
{
    Console.WriteLine("Ошибка! Третьей цифры нет");
    return;
}

//------- Вывод результата----------//
Console.WriteLine(a[2]);
