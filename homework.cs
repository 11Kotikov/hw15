// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbersAre(int n)
// {
//     System.Console.WriteLine($"Your number is {n}");
//     if (n > 1) NaturalNumbersAre(n - 1);
//     if (n < 0) NaturalNumbersAre(n + 1);
// }
// System.Console.WriteLine("Please input integer number");
// int num = Convert.ToInt32(Console.ReadLine());
// NaturalNumbersAre(num);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumDigitsMtoN(int m, int n)
// {
//     if (m==n) return 0;
//     if (Math.Max(m,n) != Math.Min(n,m)) return Math.Min(n,m) + SumDigitsMtoN(Math.Min(n,m) + 1, Math.Max(m,n));
//     return Math.Min(n,m);
// }
// System.Console.WriteLine("Please input the first integer number");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Please input the second integer number");
// int y = Convert.ToInt32(Console.ReadLine());
// int res = SumDigitsMtoN(x, y);
// System.Console.WriteLine($"If we sum each number between {x} and {y}, we will get the {res}");

// Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack (int m, int n)
{
    if (m==0) return n+1;
    if (m>0 && n==0) return Ack (m-1,1);
    if (n > 0 && m > 0) return Ack(m-1, Ack(m,n-1));
    return 0;
}
System.Console.WriteLine("Please input the first positive integer number");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please input the second positive integer number");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine (Ack(m, n));
