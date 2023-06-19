/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

System.Console.Write("Введите координату Х точки А: ");
double aX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки А: ");
double aY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки А: ");
double aZ = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X точки B: ");
double bX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
double bY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки B: ");
double bZ = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round((Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2))), 2);
System.Console.WriteLine($"Расстояние между точкой А({aX};{aY};{aZ}) и B({bX};{bY};{bZ}) -> {distance}");