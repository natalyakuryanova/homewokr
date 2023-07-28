Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine() ?? " ");
if (num < 100 || num > 1000)
{
    Console.WriteLine("Ошибка! Неверное значение!");
    return;
}
int a1 = num / 10;
int result = a1 % 10;
Console.WriteLine(result);