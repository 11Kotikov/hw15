// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumbersAre(int n)
{
    System.Console.WriteLine($"Your number is {n}");
    if (n > 1) NaturalNumbersAre(n - 1);
    if (n < 0) NaturalNumbersAre(n + 1);
}
System.Console.WriteLine("Please input integer number");
int num = Convert.ToInt32(Console.ReadLine());
NaturalNumbersAre(num);
