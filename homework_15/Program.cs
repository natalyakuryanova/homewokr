
Console.WriteLine("Введите номер дня недели");
string userInput = Console.ReadLine() ?? " ";
int a = int.Parse(userInput);
if ( a==1|| a==2 || a==3 || a==4 || a==5 )
{
    Console.WriteLine("Нет");
}
else if (a==6 || a==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Ошибка! Введите корректное значение");
}