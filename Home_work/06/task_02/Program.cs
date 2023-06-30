/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double VariableCreation(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double IntersectionPPoint(double k1, double b1, double k2, double b2)
{
    double intersectionPPointX = (b2 - b1) / (k1 - k2);
    return intersectionPPointX;
}
System.Console.WriteLine("Заданы две прямых y = k1 * x + b1 и y = k2 * x + b2: найдите точку пересечения этих прямых");
double k1 = VariableCreation("Введите k1: ");
double b1 = VariableCreation("Введите b1: ");
double k2 = VariableCreation("Введите k2: ");
double b2 = VariableCreation("Введите b2: ");
if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямые идентичны");
else if (k1 == k2 && b1 != b2) System.Console.WriteLine("Прямые параллельны");
else System.Console.WriteLine($"Точка пересечения двух прямых: y = {k1} * x + {b1} и y = {k2} * x + {b2}: -> ({Math.Round(IntersectionPPoint(k1, b1, k2, b2), 2)}; {Math.Round(k1 * IntersectionPPoint(k1, b1, k2, b2) + b1, 2)})");