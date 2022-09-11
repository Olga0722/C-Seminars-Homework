// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //метод который генерит массив из случайных чисел

{
    int[] newArray = new int[size]; //обязательная строчка при создании любого массива!!!

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void ShowArray(int[] array) // метод, который показывает массив
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();    
}

int SumOfPositive(int[] array)
{
    int sum = 0;

    for(int i = 0; i<array.Length; i++)
       if(array[i]>0) sum += array[i];

       return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine("Sum of positive elements is " + SumOfPositive(array));
*/

// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
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
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();    
}

int[] InvertArray (int[] array)
{
    for (int i=0; i<array.Length; i++) 
    array[i] *= (-1);
    return array;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

array = InvertArray(array);
ShowArray(array);
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*
bool SearchInArray(int num, int[] array)
{
    for(int i=0; i < array.Length; i++)
    if (array[i] ==num) return true;
    return false;
}

int[] CreateRandomArray(int size, int minValue, int maxValue) //метод который генерит массив из случайных чисел

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
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();    
}

int[] newarray = CreateRandomArray(10, 0, 10);
ShowArray(newarray);
Console.Write("Введите число для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(SearchInArray(num, newarray));
*/

//Задайте одномерный массив из 12 случайных чисел. 
//Найдите количество элементов массива, значения к-х лежат в отрезке [10,99].

/*
int[] CreateRandomArray(int size, int minValue, int maxValue) //метод который генерит массив из случайных чисел

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

Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите мин возможное значение элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите максимально возможное значение элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

