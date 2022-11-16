// Задача 64: 
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Натуральные числа от {n} до 1:");
NatNumbers(n);


void NatNumbers(int n)
{
    Console.Write($"{n}, ");
    n = n - 1;
    if (n > 1) NatNumbers(n);
    else Console.Write(n);
}