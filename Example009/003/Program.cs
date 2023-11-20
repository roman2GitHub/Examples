﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Readint(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}


int N = Readint("Введите число N:");
int M = Readint("Введите число M:");

Console.WriteLine(A(N, M));
