/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите два натуральных числа M и N. Число М должно быть меньше числа N.");
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m <= 0)
{
    Console.WriteLine("Число M не натуральное!");
    return;
}
if(n <= 0)
{
    Console.WriteLine("Число N не натуральное!");
    return;
}
if(m > n)
{
    Console.WriteLine("Число М должно быть меньше числа N.");
    return;
}

Console.Write($"M = {m}; N = {n}; -> ");
Console.WriteLine(PowNum(m, n));

int PowNum(int i, int j)
{
    if(i == j) return i;
    return  i + PowNum(i + 1, j);
}