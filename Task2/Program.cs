//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.Clear();
Console.WriteLine("Input number one ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Input number two ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"{numberA} is max");
}
else
{
    Console.WriteLine($"{numberB} is max");
}