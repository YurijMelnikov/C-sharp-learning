/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (Math.Abs(number % 2))
{
    case 0:
        System.Console.WriteLine($"Число {number} является чётным");
        break;
    case 1:
        System.Console.WriteLine($"Число {number} является нечётным");
        break;
}
