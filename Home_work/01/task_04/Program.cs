/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.WriteLine("Вывести все чётные числа от 1 до числа N");
System.Console.Write("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int counter;
if (numberN == 1)
{
    System.Console.WriteLine("Чётных чисел в заданном диапазоне нет");
}
else if (numberN > 1)
{
    counter = 1;
    while (counter <= numberN)
    {
        if (counter % 2 == 0)
        {
            System.Console.Write($"{counter}  ");
        }
        counter++;
    }
    System.Console.WriteLine();
}
else if (numberN < 1)
{
    counter = 0;
    while (counter <= Math.Abs(numberN))
    {
        if (counter % 2 == 0)
        {
            System.Console.Write($"{-counter}  ");
        }
        counter++;
    }
    System.Console.WriteLine();
}