// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrixWithRandomNumber(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0,11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}" + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindNumber(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number)
            {
                System.Console.WriteLine($"Число {number} стоит под индексом{(i,j)}");
                count++;
            }

        }
    }
    if (count == 0)
    {
        System.Console.WriteLine("Такого числа нет в массиве");
    }
        
    
}

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[m,n];
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


FillMatrixWithRandomNumber(matrix);
PrintMatrix(matrix);
FindNumber(matrix, number);