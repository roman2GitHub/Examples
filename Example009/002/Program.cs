// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Readint(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int PrintNumbers(int startNumber, int stopNumber)
{
    
    if (startNumber > stopNumber) return 0;
    return startNumber + PrintNumbers(startNumber+1, stopNumber);
}

int N = Readint("Введите число N:");
int M = Readint("Введите число M:");

if (N > M)
{
    Console.WriteLine("Значение N больше значения M.");
    return;
}

Console.WriteLine(PrintNumbers(N,M));
