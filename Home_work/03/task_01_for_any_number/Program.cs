/*Задача 19
Напишите программу, которая принимает на вход целое число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int DigitСapacity(int randomNumber) // метод расчёта разрядности числа, возможно есть отдельный метод в C# для вычисления разрядности числа
{
    int digitСapacity = 0; // счётчик цикла и разрядность числа в последней итерации цикла
    int buff = 0;
    for (int i = 1; buff != randomNumber; i *= 10)
    {
        buff = buff + i * ((randomNumber / i) % 10);
        digitСapacity++;
    }
    return digitСapacity;
}

bool PalindromeCheck(int randomNumber, int digitСapacity) // проверка, является ли число палиндромом, алгоритм выдумывал сам, возможно есть более изящные способы решения, пытался придумать способ без ввода дополнительной переменной j - не получилось.
{
    double palindrom = 0; //метод Math.Pow не возвращает целые значения, только double
    int j = 1; //дополнительная переменная для последовательного деления числа в цикле на 1\10\100 ит.д.
    for (int i = digitСapacity; i > 0; i--) //i = 5, 5 - разрядность числа, в данной задаче она по умолчанию 5, в более общем случае нужно отдельно её посчитать с помощью метода выше
    {
        palindrom = palindrom + Math.Pow(10, i - 1) * ((randomNumber / j) % 10);
        j *= 10;
    }
    if (randomNumber == palindrom) //не нашёл уточнения, являются ли числа с одной цифрой палиндромами, но по определению должны являться
    {
        return true;
    }
    else
    {
        return false;
    }

}

System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if (PalindromeCheck(Math.Abs(number), DigitСapacity(Math.Abs(number)))) // возможно не стоит вызывать один метод в другом, а ввести дополнительную переменную, но код работает
{
    System.Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    System.Console.WriteLine($"Число {number} не является палиндромом");
}