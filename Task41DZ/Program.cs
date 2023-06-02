// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int[] FillArrayWithNumber(int length, int[] array)
{
    
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1} элемент");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}

int CountSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

System.Console.WriteLine("Введите количество элементов: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];


FillArrayWithNumber(length, array);
System.Console.WriteLine($"Количество элементов больше нуля равно {CountSum(array)}");