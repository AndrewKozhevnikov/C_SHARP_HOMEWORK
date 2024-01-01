// Задача 4. Написать программу. На входе число (number). 
// На выходе все четные числа от 1 до number (включительно), 
// после каждого числа пробел.

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);

int i = 1;

while (i <= number)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
    i = i + 1;
}
