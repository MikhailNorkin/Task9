/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = 0, n = 0, sum = 0;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n} -> ");
for (int i = m; i <= n; i++)
{
    sum = sum + i;
    if (i == n)
    {
        Console.WriteLine($"{sum}");
    }
}