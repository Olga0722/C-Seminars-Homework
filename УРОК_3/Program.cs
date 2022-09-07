// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void ShowDiapason(int quart)
{
    if (quart>=1 && quart<=4)
    {
    if(quart==1) Console.WriteLine("x>0, y>0");
    if(quart==2) Console.WriteLine("x<0, y>0");
    if(quart==3) Console.WriteLine("x<0, y<0");
    if(quart==4) Console.WriteLine("x>0, y<0");
    }
    else Console.WriteLine("некорректный ввод!");

}

Console.WriteLine("введите номер четверти");
int NumQuart = Convert.ToInt32(Console.ReadLine());

ShowDiapason(NumQuart);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int NumQuart(int x, int y)
{
    int result=0;
    {
    if(x>0 && y>0) result=1;
    if(x<0 && y>0) result=2;
    if(x<0 && y<0) result=3;
    if(x>0 && y<0) result=4;

    return result;
    }
}
Console.WriteLine("введите значение координаты x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты y");
int y = Convert.ToInt32(Console.ReadLine());
int number;
if (x !=0 && y !=0)
{
  number = NumQuart(x, y);
  Console.Write($"Точка находится в {number} четверти");
}
else Console.WriteLine("Точка находится на оси координат");
*/

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

/*
double Lenth(double xa, double ya, double xb, double yb)
{
    double lenth = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya));
    return lenth;
}

Console.Write("Введите значение координаты X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());

double lenth = Lenth(xa, ya, xb, yb);
Console.Write($"Расстояние между точками A и B равно {lenth}");
*/

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт последовательность квадратов чисел от 1 до N.

/*
void NumberSquare(double num)
{
    int current = 1;
    while (current<=num)
    {
        Console.Write(current*current + " ");
        current++;
    }
}

double check;
Console.Write("введите число: ");
check = Convert.ToDouble(Console.ReadLine());
if (check < 0) check = check*(-1);
NumberSquare(check); 
*/

int A = 5;
int D = -5;

Console.WriteLine($"{A} .. {D}");