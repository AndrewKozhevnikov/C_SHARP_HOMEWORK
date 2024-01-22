//Напишите программу, которая перевернет одномерный массив
//(первый элемент станет последним, второй - предпоследним и т.д.).

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int a = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = a;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

int[] array = { 1, 3, 5, 6, 7, 8, 0 };
ReverseArray(array);
PrintArray(array);
