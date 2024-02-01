// Задайте двумерный массив символов (тип char[,]).
// Создать строку из символов этого массива.

char[,] charArr = {
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
string result = CreateString(charArr);
Console.WriteLine(result);

string CreateString(char[,] mass)
{
    string buf = " ";
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            buf = buf + mass[i, j];
        }
    }
    return buf;
}
