// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] CreateMatrix(int rowCount, int columsCount) // Функция создания массива
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

void ShowMatrix(int[,] matrix) // Функция вывода массива
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

int[,] matrix = CreateMatrix(3, 3); // Точка входа в программу, создание массива случайных чисел
ShowMatrix(matrix); // Вывод массива случайных чисел на экран

void ReplaceRows(int[,] array) // Функция замены местами первой и последней строк массива
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[2, i];
        array[2, i] = array[0, i];
        array[0, i] = tmp;
    }
}

ReplaceRows(matrix); // Изменение первоначального массива по функции
Console.WriteLine("Массив с поменянными перовой и последней сроками:");
ShowMatrix(matrix); // Вывод измененного массива на экран
