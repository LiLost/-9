// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Numbers(int start, int end)
{
    if (end == start)
        return start;
    else return start + Numbers(start + 1, end);
}


Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"M = {M}; N = {N} -> {Numbers(M, N)}");
