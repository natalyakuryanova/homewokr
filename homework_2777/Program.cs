/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
///.....ввод числа пользователем...///

Console.Clear();

// Получаем исходное число
int num = GetNumberFromUser("Введите число: ","Ошибка ввода данных" );
//Console.WriteLine(num);

// Вызов функции вычисления суммы цифр
int count = GetCount(num);
Console.WriteLine($"Сумма цифр в числе {count}");


//////.......Определение методов..........////////
static int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out var userNumber);
        if (isCorrect)
        {   
            return userNumber;  
        }
        Console.WriteLine(errorMessage);
    }
}

int GetCount(int number)
{
    int result = 0;
    while(number > 1)
    {
        int rem = number % 10;
        result = result + rem;
        number = number/10;
    } 
    return result;
}
