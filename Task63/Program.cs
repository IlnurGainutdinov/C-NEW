// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void RoadToN(int number)
{
    if(number == 0)
    {
        return;
    }
    RoadToN(number - 1);
    System.Console.Write($"{number}");
    
}

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToN(number);