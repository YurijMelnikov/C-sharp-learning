using System.Text.RegularExpressions;
System.Console.Write("Введите целое число: ");
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

bool check = NumberCheck(number);
if (check)
{
    number = ZeroAndMinusDeletions(number);
    if (number.Length >= 3)
    {
        System.Console.WriteLine($"Третья цифра: {number[2]}");
    }
    else
    {
        System.Console.WriteLine("В числе третьей цифры нет");
    }
}
else
{
    System.Console.WriteLine("Ввод не является числом");
}