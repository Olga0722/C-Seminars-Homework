// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)

{
    int[] newArray = new int[size]; //обязательная строчка при создании любого массива!!!
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 998 +1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();    
}

int EvenNumbers (int [] array, int min, int max)
{
    int count=0;
   for (int i=0; i<array.Length; i++)
   {
      if (i % 2 == 0) count++;
   }
    return count;
}

int []array = EvenNumbers(int [] array);
ShowArray(array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)

{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return newArray;
}

int SumOfOddNum(int[] array)
{
    int sum = 0;

    for(int i = 0; i<array.Length; i+1)
       if(array[i] % 2==0) sum += array[i];

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

Console.WriteLine("Сумма элементов нечетных " + SumOfPositive(array));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minValue, int maxValue)

{
    int[] newArray = new int[size]; //обязательная строчка при создании любого массива!!!
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 998 +1);
    }
    return newArray;
}
