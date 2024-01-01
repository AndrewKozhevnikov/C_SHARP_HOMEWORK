// Задача 3. Написать программу. На входе число number. На выходе, является ли оно четным (делится на 2 без остатка).

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
    Console.WriteLine("четное");
else
    Console.WriteLine("нечетное");
