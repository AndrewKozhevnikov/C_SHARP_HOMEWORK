// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания двумерного массива
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix) // Функция вывода двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 3); // Точка входа в программу, создание двумерного массива
ShowMatrix(matrix); // Вывод двумерного массива на экран

int[] SumOfRows(int[,] array) // Функция создания одномерного массива из сумм элементов строк двумерного массива
{
    int sum = 0;
    int[] newMass = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
        newMass[i] = sum;
        sum = 0;
    }
    return newMass;
}

void Print(int[] arr) // Функция вывода одномерного массива
{
    int size = arr.Length;
    Console.Write("Суммы элементов строк массива: ");
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

Print(SumOfRows(matrix));

void MinSum(int[] arr)
{
    int min = arr[0];
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            n = i;
        }
    }
    Console.WriteLine("Индекс строки с наименьшей суммой элементов: " + n);
}

MinSum(SumOfRows(matrix));
