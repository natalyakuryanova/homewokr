﻿/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите число: ");
string number = Console.ReadLine();
if (number.Length == 5)
{
CheckingNumber(number);
}
else 
{
    Console.WriteLine($"Вы ввели неверное значение");
}


// // // // // // // // // // // // // // // // // // // 
//  новый метод  который проверяет и выводит результат
// // // // // // // // // // // // // // // // // // // 
void CheckingNumber(string number)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine($"Число: {number} - является палиндромом"); 
    }
    else 
    {
        Console.WriteLine($"Число {number} - не является палиндром");
    }
}
// // // // // // // // // // // // // // // // // // // 
//  новый метод закончился 
// // // // // // // // // // // // // // // // // // // 