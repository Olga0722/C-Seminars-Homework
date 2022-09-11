// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) 
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();    
}

int Count (int[] array, int min, int max)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i] <=max && array[i]>= min) count++;
    }
    return count;
}

// Если просим задать пользователя значение:

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите мин возможное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимально возможное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(123, 0, 1000);

ShowArray(array); // можно показать массив, который получился
Console.WriteLine();
Console.Write($"Количество чисел в интервале от 10 до 99 равно {Count (array,min,max)}");
*/


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateRandomArray(int size, int minValue, int maxValue)

{
    int[] newArray = new int[size]; //обязательная строчка при создании любого массива!!!

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int [] NewArray(int[] array)
{
    if (array.Length%2 ==0)
    {
        int[] result = new int[array.Length/2];
        for (int i = 0; i<result.Length; i++)
        {
            result[i] = array[i]*array[array.Length - 1-i];
        }
        return result;
    }
    else
    {
        int[] result = new int[array.Length/2+1];
        for (int i = 0; i<result.Length-1; i++)
        {
            result[i] = array[i]*array[array.Length-1-i];
        }
        result[result.Length-1] = array[result.Length-1];
        return result;
    }
}

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите мин возможное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите максимально возможное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int[] result = NewArray(array);
ShowArray(result);