/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA * numberA == numberB || numberB * numberB == numberA)
{
    if (numberA < numberB)
    {
        System.Console.WriteLine($"Число {numberB} является квадратом {numberA}");
    }
    else
    {
        System.Console.WriteLine($"Число {numberA} является квадратом {numberB}");
    }
}
else
{
    System.Console.WriteLine($"Число {numberB} не является квадратом {numberA}");
}