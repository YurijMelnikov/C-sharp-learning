/* Написать программу для сложения двух чисел */
// Console.WriteLine("Введите первое число");
int number1 = new Random().Next(-100, 101);
// Console.WriteLine("Введите второе число");
int number2 = new Random().Next(-100, 101);
int sum = number1 + number2;
Console.WriteLine((number1) + " " + "+" + " " + (number2) + " " + "=" + " " + sum);
Console.WriteLine($"{number1} + {number2} = {sum}");