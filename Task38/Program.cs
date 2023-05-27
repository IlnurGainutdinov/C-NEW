// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumber(int size)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.NextDouble() + rand.Next(1,10), 2);
    }
    return arr;
}

System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

double max = array[0];
double min = array[0];


for(int i = 0; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array[i];
    }
    if(min > array[i])
    {
        min = array[i];
    }
}
double diff = Math.Round(max - min, 2);
System.Console.WriteLine($"Разница равна {diff}");
