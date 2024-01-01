// Задаяа 1. Написать программу. На входе 2 числа. На выходе, какое число больше.

Console.Write("введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine()!);

if (firstNumber > secondNumber)
    Console.WriteLine("первое число больше");
else
{
    if (firstNumber < secondNumber)
        Console.WriteLine("второе число больше");
    else
        Console.WriteLine("числа равны");
}
