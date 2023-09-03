/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();

int rows = 3;
int colums = 4;

int[,] array = GetArray(rows, colums, 0, 15);
PrintArray(array);
Console.WriteLine(" ");
StreamlineArray(array);
PrintArray(array);

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

void StreamlineArray(int[,] inArray)
{    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int s = j+1; s < inArray.GetLength(1); s++)
            {
                if(inArray[i,s] < inArray[i,maxPosition]) 
                {
                    maxPosition = s;
                }
            } 
            int temp =  inArray[i, j];
            inArray[i, j] = inArray[i, maxPosition];
            inArray[i, maxPosition] = temp; 
        }
    }
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