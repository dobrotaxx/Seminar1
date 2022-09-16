/*Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());
int min = A;
int max = B;

if (min < B)
{
    max = B;
}
else 
{
    max = A;
}
if (C < max)
{
    Console.Write($"Наибольшее число: {max}");
}
else
{
    max = C;
    Console.Write($"Наибольшее число: {max}");
}