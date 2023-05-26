// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum; 
}


System.Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {number} равна {Sum(number)}");
