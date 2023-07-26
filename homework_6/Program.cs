// See https://aka.ms/new-console-template for more information
/* Задача 6: Напишите программу, 
которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine() ?? " ");
Console.WriteLine(number1 % 2 == 0 ? "Четное" : "Не четное");

