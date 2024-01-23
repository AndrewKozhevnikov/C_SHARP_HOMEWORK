// Задайте одномнрный массив из 10 целых чисел от 1 до 100.
// Найдите количекство элементов массива, значения которых в отрезке [10, 90].

int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9)
        if (array[i] < 91)
            count = count + 1;
}
Console.Write(count);
