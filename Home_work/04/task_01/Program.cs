/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int Degree(int number, int degree)
{
    int result = 1;
    for (int counter = 1; counter <= degree; counter++)
    {
        result = result * number;
    }
    return result;
}

System.Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(System.Console.ReadLine());

if (a == 0 && b == 0)
{
    System.Console.WriteLine("0 в степени 0 не определён");
}
else if (b < 0)
{
    System.Console.WriteLine("Возведение в натуральную степень не возможно, введите показатель степени  >= 0");
}
else if (b >= 0)
{
    System.Console.WriteLine($"{a} в натуральной степени {b} будет {a}^{b} = {Degree(a, b)}");
}