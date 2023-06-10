/*Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2" */


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int counter = -number;
System.Console.Write("[");
while (counter <= number)
{
    System.Console.Write($"{counter}, ");
    counter++;
}
System.Console.WriteLine($"{number}]");