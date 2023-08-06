/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
///.....ввод числа пользователем...///
Console.Write("Введите число : ");
string number = Console.ReadLine() ?? " ";
int userNumber = int.Parse(number);

int result = 0;
int index = 0;
while (index < number.Length)
{
    int temp = number[index] - '0';
    result = result + temp; 

    index++;
}
Console.WriteLine($"Сумма цифр равна {result}");
  