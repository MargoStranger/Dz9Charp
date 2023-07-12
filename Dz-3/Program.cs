// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = {GetAkerman(m, n)}");

int GetAkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return GetAkerman(m - 1, 1);
    return GetAkerman(m - 1, GetAkerman(m, n - 1)); 
}