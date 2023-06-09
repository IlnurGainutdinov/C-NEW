// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FromMToN(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    return n + FromMToN(m, n-1);
}


System.Console.WriteLine("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FromMToN(m, n));