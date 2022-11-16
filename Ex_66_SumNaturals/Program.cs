// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма натуральных чисел от {n} до {m}:  ");
if (n > m)
{
    int temp = n;
    n = m;
    m = temp;
}
Console.WriteLine(SumNumbers(n, m));

int SumNumbers(int first, int second)
{
if ( first == second) return first;
return SumNumbers(first, second - 1) + second;
}