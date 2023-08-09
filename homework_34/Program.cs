/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] array = GenArray(5, 100, 1000);
Console.WriteLine($"Сгенерированный массив: [{string.Join(", ",  array)}]");

int count = 0;
int index = 0;

while (index < array.Length)
{
    if (array[index] % 2 == 0)
    {
        count++;
    }
    index++;

}

// ввод массива//
int[] GenArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max);
    }
    return res;
} 

Console.WriteLine($"Количество четных чисел в массиве:{count}");