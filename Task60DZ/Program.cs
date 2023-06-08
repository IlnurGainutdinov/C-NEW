// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWithRandomNumber(int[, ,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                matrix[i, j, n] = rnd.Next(10, 100);
            }
            
        }
    }
}

void PrintMatrix(int[, ,] matrix)
{
    for (int n = 0; n < matrix.GetLength(2); n++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i,j,n]}{(i,j,n)}" + "\t"); 
            }
            System.Console.WriteLine();
            
        }
        
    }
    
}




System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество страниц: ");
int k = Convert.ToInt32(Console.ReadLine());

int[, ,] matrix = new int[m,n,k];
FillMatrixWithRandomNumber(matrix);
PrintMatrix(matrix);


