// Задайте произвольную строку.
// Выясните, является ли она палидромом.

Console.WriteLine("Введите строку: ");
String str = Console.ReadLine();
char[] arr = str.ToCharArray();
if (IsPalindrom(arr))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");

static bool IsPalindrom(char[] word)
{
    for (int i = 0; i < word.Length / 2; i++)
        if (word[i] != word[word.Length - 1 - i])
            return false;
    return true;
}
