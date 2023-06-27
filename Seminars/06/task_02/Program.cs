/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

bool TriangleCheck(double side1, double side2, double side3)
{
    if ((side1 + side2 > side3) && side2 + side3 > side1 && (side1 + side3 > side2)) return true;
    return false;
}

System.Console.WriteLine("Введите первую сторону треугольника");
double a = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите вторую сторону треугольника");
double b = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите тертью сторону треугольника");
double c = Convert.ToDouble(System.Console.ReadLine());

if (TriangleCheck(a, b, c))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Треугольник не существует");
}