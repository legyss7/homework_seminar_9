/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите два не отрицательных числа m и n.");
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m < 0)
{
    Console.WriteLine("Число m отрицательное!");
    return;
}
if(n < 0)
{
    Console.WriteLine("Число n отрицательное!");
    return;
}

Console.Write($"m = {m}; n = {n}; -> A(m, n) = ");
Console.WriteLine(FunctionAckerman(m, n));

int FunctionAckerman(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}