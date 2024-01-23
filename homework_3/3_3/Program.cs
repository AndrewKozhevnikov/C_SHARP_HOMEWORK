// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементами массива.

double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
int i = 0;
double min = array[i];
double max = array[i];
for (i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
}
Console.Write(max - min);
