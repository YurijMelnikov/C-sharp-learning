/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// if ((number < 100 || number > 999) && (number < -999 || number > -100)) //проверка на трёхзначность числа в том числе, если оно отрицательное
if (Math.Abs(number) < 100 || Math.Abs(number) > 999) // более лаконичная проверка через модуль числа
{
    System.Console.WriteLine("Введённое число не является трёхзначным");
    return;
}
int secondDigit = Math.Abs(number / 10 % 10);
System.Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");