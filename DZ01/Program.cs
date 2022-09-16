/*Напишите программу, которая на вход принимает два 
числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число A: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int max = Convert.ToInt32(Console.ReadLine());

if (min < max)
{
    Console.Write($"Меньшее число: {min}, ");
    Console.Write($"Большее число: {max}");
}
else
{
    int temp = min;
    int temp2 = max;
    max = temp;
    min = temp2;
    Console.Write($"Меньшее число: {min}, ");
    Console.Write($"Большее число: {max}");
}