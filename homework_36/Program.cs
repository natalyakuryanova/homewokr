/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] array = GenArray(4, -10, 18);
Console.WriteLine($"Сгенерированный массив: [{string.Join(", ",  array)}]");


int[] GenArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++ )
    {
        res[i] = new Random().Next(min, max);
    }
    return res;
}

int sum = 0;
int index = 1;

while (index < array.Length)
{
   
    sum = sum + array[index];
    index = index + 2;

} 
Console.WriteLine($"Сумма элементов нечетных позиций: {sum}");
