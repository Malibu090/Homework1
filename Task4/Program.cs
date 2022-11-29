//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.Write("Input number one ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input number two ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Input number three ");
int numberC = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.Write($"{numberA} is max");
    }
    else
    {
        Console.Write($"{numberC} is max");
    }
}
else if (numberB > numberC)
     {
         Console.Write($"{numberB} is max");
     }
     else
     {
        Console.Write($"{numberC} is max");
     }

