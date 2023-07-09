// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число с которого начинается сумма: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное число на котором заканчивается сумма: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {m}; N = {n} -> {SumNumbers(m,n)}");

int SumNumbers(int start, int end)
{
    if (start == end) return n;
    return (start + SumNumbers(start+1,end));
}