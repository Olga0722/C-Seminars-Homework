// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

/*
int NumOfDigits(int num)
{
    int count=0;

    while(num>0)
    {
        num=num/10;
        count++;
    }
    return count;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int numOfDigits = NumOfDigits(number);

Console.WriteLine($"Number of digits of {number} is {numOfDigits}");
*/

// Напишите программу, к-я принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int SumDigits(int A)
{
    int count=1;
    int result=0;

    while( count<=A && A>0)
    {
        result=result+count;
        count++;
    }
    return result;
}

Console.Write("Input digit A: ");
int A = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(A);

Console.WriteLine($"Summa of digits of {A} is {sumDigits}");
*/

//Напишите программу, к-я принимает на вход число N и выдаёт произведение чисел от 1 до N, кратных трем.

/*
int ProductOfNumbers(int N)
{
    int count=1;
    int result=1;

    while( count<=N && N>0 )
    {
        if (count % 3 ==0)
        result=result * count;
        count++;
    }
    return result;
}

Console.Write("Input digit N: ");
int N = Convert.ToInt32(Console.ReadLine());

int productOfNumbers = ProductOfNumbers(N);

Console.WriteLine($"Product of numbers of {N} is {productOfNumbers}");
*/

//Напишите программу, к-я выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

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

int[] binaryArray = CreateRandomArray(8, 0, 1);
ShowArray(binaryArray);
