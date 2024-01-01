// Задача 2. Написать программу. На входе 3 числа. На выходе максимальное из этих чисел.

Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("максимальное число " + max);
