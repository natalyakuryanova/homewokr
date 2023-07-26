// See https://aka.ms/new-console-template for more information
/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Введите три числа через пробел");
string instr = Console.ReadLine();
// instr = "45 66 7"
var mass = instr.Split(' ').Select(Int32.Parse).ToArray();

//int number1 = int.Parse(Console.ReadLine() ?? " ");
int max = 0;
if (mass[0] > max)  max = mass[0] ;
if (mass[1] > max)  max = mass[1] ;
if (mass[2] > max)  max = mass[2] ;

Console.WriteLine(max);

