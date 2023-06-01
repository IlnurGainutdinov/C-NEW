// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
System.Console.Write("0 1 ");
int sum = 0;
for (int i = 0; i < N - 2; i++)
{
    sum = a + b;
    a = b;
    b = sum;
    System.Console.Write($"{sum} ");
}
