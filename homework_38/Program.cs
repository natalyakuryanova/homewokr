/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] array = GenArray(4);
Console.WriteLine($"Сгенерированный массив: [{string.Join("; ",  array)}]");

double [] GenArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++ )
    {
        res[i] = Math.Round((new Random().NextDouble() * 100), 2);
    }
    return res;
}

double minValue = array[0];
double maxValue = array[0];
int index = 0;
while (index < array.Length)
{
    if (array[index] < minValue)
    {
        minValue = array[index]; 
    }
    if (array[index] > maxValue)
    {
        maxValue = array[index];
    }
    index++;
}
Console.WriteLine(minValue);
Console.WriteLine(maxValue);