// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9, 10);
    }
    return arr;
}

int[] CopyArray(int length, int[] array)
{
    int[] arraycopy = new int[length];
    for (int j = 0; j < arraycopy.Length; j++)
    {
        arraycopy[j] = array[j];
    }
    return arraycopy;
} 

System.Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(",", array));


int[] methodcopy = CopyArray(length, array);
System.Console.WriteLine(string.Join(",", methodcopy));