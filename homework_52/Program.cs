/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();

int[,] array = GetArray(rows, colums, 0, 50); 
PrintArray(array); 

Console.WriteLine();

double[] arrayOne = GetArrayOne(array); 
Console.Write($"Среднее арифметическое каждого столбца -> "); 
PrintArrayDouble(arrayOne);

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

void PrintArrayDouble(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]:f2}; ");
    }
    Console.WriteLine();
}

double[] GetArrayOne(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)]; 
    int rows = inArray.GetLength(0);
    int colums = inArray.GetLength(1);

    for (int j = 0; j < colums; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += inArray[i, j];
        }
        result[j] = Convert.ToDouble(sum / rows);
    }
    return result;
}
