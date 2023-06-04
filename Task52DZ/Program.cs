// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillMatrixWithRandomNumber(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}" + "\t");
        }
        System.Console.WriteLine();
    }
}

void Sum(int[,] matrix)
{
    double middle = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        middle = Math.Round(sum / matrix.GetLength(0), 2);
        System.Console.Write($"{middle}; ");
    }

}

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWithRandomNumber(matrix);
PrintMatrix(matrix);
System.Console.Write($"Среднее арифметическое каждого столбца: ");
Sum(matrix);