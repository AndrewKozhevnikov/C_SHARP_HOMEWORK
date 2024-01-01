// Задача 3. Написать программу, которая
// принимает на вход целое число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

Console.Write("Введите целое число из отрезка [10, 99]: ");
int n = int.Parse(Console.ReadLine()!);

// int n = 121;

if (n < 10)
    Console.WriteLine("Число не должна быть меньше 10.");
else
{
    if (n > 99)
        Console.WriteLine("Число не должна быть больше 99.");
    else
    {
        if (n / 10 > n % 10)
            Console.WriteLine(n / 10);
        else
            Console.WriteLine(n % 10);
    }
}
