/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

int m = 0, n = 0;
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
Console.Write($"M = {m}; N = {n}. -> ");
for (int i = m; i <= n; i++)
{
    if (i != n)
    {
        Console.Write($"{i},");
    }
    else
    {
        Console.WriteLine($"{i}");
    }    
}