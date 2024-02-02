// Напишите пронрамму, которая на вход принимает позиции элемента в
// двумерном массиве и возвращает значение этого элемента или
// указывает, что такого элемента нет.

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

int[,] matrix = CreateMatrix(3, 5);
ShowMatrix(matrix);

Console.Write("Введите позицию (строки, начиная с 0) элемента двумерного массива: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию (столбца, начиная с 0) элемента двумерного массива: ");
int j = int.Parse(Console.ReadLine()!);
if (i < 2 && j < 4)
    Console.Write("Значение элемента: " + matrix[i, j]);
else
    Console.Write("Элемента с такой позицией нет");
