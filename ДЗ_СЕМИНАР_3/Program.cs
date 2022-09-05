//ЗАДАЧА 19.
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {Console.WriteLine($"Ваше число: {number} - палиндром.");}
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
if (number.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/

//ЗАДАЧА 21
//Напишите программу, к-я принимает на вход коорд двух точек и находит расст между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Решение:

/*
double Distanse(double xa, double ya, double za, double xb, double yb, double zb)
{
  double distanse = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
  return distanse;
}

Console.Write("Введите значение координаты X точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки A: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты X точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double distanse = Distanse(xa,ya,za,xb,yb,zb);
Console.Write($"Расстояние между точками А и В в 3D пр-ве равно {distanse}");
*/

//ЗАДАЧА 23
//Напишите программу, к-я принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//Решение:


void Numbers(double num)
{
  int current = 1;
  while (current <= num)
  {
    Console.Write(current*current*current+ " ");
    current++;
  }
}
double check;
Console.Write("Введите целое положительное число: ");
check=Convert.ToDouble(Console.ReadLine());
if (check<0) check = check*(-1);
Numbers(check);