// Задача 25: Напишите цикл, к-й принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//Решение:

/*
int number (string num)
{
 Console.Write($"Введите значение числа {num}: ");
 return Convert.ToInt32(Console.ReadLine());
}

int A=number("A");
int B=number("B");

int pow =1;
for(int i=1; i<=B; i++)
{
    pow=pow*A;
}
Console.Write($"{A}^{B}={pow}");
*/
  

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Решение:

/*
Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(number>0)
{
    int num = number % 10;
    number = number / 10;
    sum = sum+num;
}
Console.Write($"Сумма цифр в числе = {sum}");
*/

// Задача 29: Напишите программу, к-я задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i<size; i++)
       newArray[i] = 

}