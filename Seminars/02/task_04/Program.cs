/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да*/

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");
}