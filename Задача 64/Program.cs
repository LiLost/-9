// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Numbers(int start, int end)
{
    if (end == start)
    {
        Console.WriteLine($"{start}");
        return start.ToString();
    }
    Console.WriteLine($"{start}");
    return start + " " + Numbers(start - 1, end);
}


Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Numbers(N, 1));