/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

using System.Text.RegularExpressions;
System.Console.Write("Введите трёхзначное число: ");
string number = Console.ReadLine();

bool NumberCheck(string numberString) //метод проверки строки, является ли она числом (отрицательным или положительным)
{
    string pattern = @"^-?\d+$";  //регулярное выражения для любого числа со знаком и без
    bool check = Regex.IsMatch(numberString, pattern);
    return check;
}

string ZeroAndMinusDeletions(string numberString) //метод удаления из числа '-' и любого количества нулей в начале строки
{
    string pattern = @"^-?0*"; //регулярное выражения для поиска '-' и  любого количества нулей в начале строки
    string target = "";
    numberString = Regex.Replace(numberString, pattern, target); //удаление из начала строки '-' и нулей
    return numberString;
}

void SecondDigit(string numberString) //метод вывода второй цифры, с учётом удаления '-' и нулей в начале
{
    if (numberString.Length == 3)
    {
        System.Console.WriteLine($"Вторая цифра числа: {numberString[1]}");
    }
    else
    {
        System.Console.WriteLine("Введённое число не является трёхзначным");
    }
}

bool check = NumberCheck(number);
if (check)
{
    number = ZeroAndMinusDeletions(number);
    SecondDigit(number);
}
else
{
    System.Console.WriteLine("Ввод не является числом");
}