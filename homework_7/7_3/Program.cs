// Задайте произвольный массив.
// Выведите его элементы, начиная с конца. Использовать рекурсию.

int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReversely(array, array.Length - 1);

void PrintArrayReversely(int[] array, int i)
{
    if (i < 0)
        return;
    Console.Write(array[i] + " ");
    PrintArrayReversely(array, i - 1);
}
