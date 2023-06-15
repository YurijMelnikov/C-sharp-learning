/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 5 && day > 0)
{
    System.Console.WriteLine("Данный день недели является рабочим");
}
else if (day >= 6 && day <= 7)
{
    System.Console.WriteLine("Данный день недели является выходным");
}
else
{
    System.Console.WriteLine("Дня недели с таким номером не существует");
}