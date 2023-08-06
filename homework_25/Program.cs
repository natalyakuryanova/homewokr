
/////...ввод чисел пользователем...////////
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? " ");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? " ");

////....определение начальных значений.....///
int result = A;
int n = 2;

///.......цикл...../////
while ( n <= B )
{
    result = result * A;
    n++;
}

///.......вывод результата...///
Console.WriteLine(result);