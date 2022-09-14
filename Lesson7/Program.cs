// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
*/

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];
    for(int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            newArray[i,j] = i+j;
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
*/

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i=0; i<rows; i++)
    {
        for (int j=0; j<columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
int[,] Zamena(int [,] array)
{
    for(int i=0; i<array.GetLength(0); i+=2)
    {
        for (int j=0; j<array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j]*array[i,j];
        }
    }
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
int [,] zamena = Zamena(array);
Show2dArray(zamena);
*/

//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int GetSummaofDiagonal(int [,] array)
{
    int sum=0;
    for (int i=0; i<array.GetLength(0) && i<array.GetLength(1); i++)
         sum += array[i,i];
    return sum; 
}
int [,] array = CreateRandom2dArray(5, 5, 0, 9);
Show2dArray(array);
int sum = GetSummaofDiagonal(array);
Console.Write(sum);
