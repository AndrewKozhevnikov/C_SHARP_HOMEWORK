//Задайте массив, заполненный случайными трехзначными числами.
//Напишите программу, которая покажет количество четных числе в массиве.

int[] SetArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int NumberEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Введите количество случайных трехзначный целых чисел массива: ");
int num = int.Parse(Console.ReadLine()!);
int start = 100;
int stop = 1000;
int[] mass = SetArray(num, start, stop);
PrintArray(mass);
int result = NumberEvenElements(mass);
Console.WriteLine("Количество четных числе в массиве: " + result);
