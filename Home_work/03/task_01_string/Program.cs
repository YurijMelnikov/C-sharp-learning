using System.Text.RegularExpressions; //без этой строки регулярные выражения не работают

bool NumberCheck(string numberString) //метод проверки строки, является ли она целым числом (отрицательным или положительным). Знаю о методе Int32.TryParse, но интересно было поработать с регулярными выражениями и самому описать как он работает
{
    string pattern = @"^-?\d+$";  //регулярное выражения для любого целого числа со знаком и без
    bool check = Regex.IsMatch(numberString, pattern);
    return check;
}

string ZeroAndMinusDeletions(string numberString) //метод удаления из числа '-' и любого количества нулей в начале строки, можно было воспользоваться .Replace методом, но интересно было поработать с регулярными выражениям
{
    string pattern = @"^-?0*"; //регулярное выражения для поиска '-' и  любого количества нулей в начале строки
    string target = "";
    numberString = Regex.Replace(numberString, pattern, target); //удаление из начала строки '-' и нулей
    return numberString;
}

bool PalindromeCheck(string numberString)
{
    char[] numberStringArray = numberString.ToCharArray(); //преобразование строки в массив из символов
    for (int i = 0; i < numberStringArray.Length / 2; i++) // цикл по перевороту массива из символов
    {
        char buff = numberStringArray[i];
        numberStringArray[i] = numberStringArray[numberStringArray.Length - i - 1];
        numberStringArray[numberStringArray.Length - i - 1] = buff;
    }
    string palindrome = new string(numberStringArray); //создание строки из перевёрнутого массива символов
    if (numberString == palindrome)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Введите целое число: ");
string number = Console.ReadLine();

if (NumberCheck(number))
{
    if (PalindromeCheck(ZeroAndMinusDeletions(number)))
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Ввод не является целым числом");
}