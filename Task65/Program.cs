// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void FromMToN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    FromMToN(m, n-1);
    System.Console.Write($"{n} ");

}

System.Console.WriteLine("Введите число М: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
FromMToN(m,n);
