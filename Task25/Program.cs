// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Stepen(int numberA, int numberB)
{
    int step = 1;
    for(int i = 1; i <= numberB; i++)
    {
        step = step * numberA;
    }
    return step;
}


System.Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {Stepen(numberA, numberB)}");

