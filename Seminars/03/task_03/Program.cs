/*// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Возведение в степень
double number = 9;
System.Console.WriteLine(Math.Pow(number, 2));

// Извлечение квадратного корня
System.Console.WriteLine(Math.Sqrt(number));

// Округление дробного числа
double num = 1.123213213213;
System.Console.WriteLine(Math.Round(num, 2));

// Комбинация
System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));*/

//d = √((хА – хВ)2 + (уА – уВ)2)


System.Console.Write("Введите координату Х точки А: ");
double aX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки А: ");
double aY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X точки B: ");
double bX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
double bY = Convert.ToInt32(Console.ReadLine());
double distance = Math.Round((Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2))), 2);
System.Console.WriteLine($"Расстояние между точками А и B: {distance}");
