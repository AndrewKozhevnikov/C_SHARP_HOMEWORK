// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Функция Аккермана: " + Ack(m, n));

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (n == 0)
        return Ack(m - 1, 1);
    else
        return Ack(m - 1, Ack(m, n - 1));
}
