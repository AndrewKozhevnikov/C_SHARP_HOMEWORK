// Задайте значение M и N. Написать программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию.

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
if (m > n)
    Console.Write("M должно быть меньше N");
else
{
    Console.Write("Все натуральные числа от M до N: ");
    PrintNumbers(m, n);
}

void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m} ");
        PrintNumbers(m + 1, n);
    }
}
