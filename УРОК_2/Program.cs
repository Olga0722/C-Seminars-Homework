// Напишите программу, к-я выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int FindByggerDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (ed>dec) return ed;
    else return dec;
}

int number = new Random().Next(10, 100);
int digit = FindByggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {digit}");
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

/*
bool IsKratno(int n1, int n2)
{
    if(n1 % n2 ==0) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool kratno = IsKratno(num1, num2);

Console.WriteLine(kratno);
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int DelSecondNum (int num)
{
    int num1=num / 100;
    int num3=num % 10;
    return num1 * 10 + num3;
}

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int result = DelSecondNum(number);
Console.WriteLine(result);
*/

//Напишите программу, к-я принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
/*
bool Kratno(int n)
{
    if(n % 7 == 0 && n % 23 == 0) return true;
    else return false;
}

Console.Write("Input number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
bool result1 = Kratno(number1);

Console.WriteLine(result1);
*/

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Square(int num1, int num2)
{
    if(num1==num2*num2 || num2==num1*num1) return true;
    else return false;
}

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Square(num1, num2);

Console.WriteLine(result);