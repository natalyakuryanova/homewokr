/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int rows = 3;
int colums = 4;

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

int minSum = SumLine(array, 0);
int indexMinSum = 0;
for (int i = 1; i < array.GetLength(0); i++)
{
    int sum = SumLine(array, i);
    if (sum < minSum)
    {
        minSum = sum;
        indexMinSum = i+1;
    }
}

Console.WriteLine($"Строка c наименьшей суммой элементов: {indexMinSum}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
return sum;
}




 

