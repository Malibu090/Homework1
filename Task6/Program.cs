﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Clear();
Console.WriteLine("Input number ");
int numberA = int.Parse(Console.ReadLine());
if (numberA % 2==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}