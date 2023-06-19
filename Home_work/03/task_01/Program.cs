/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

bool DigitСapacityCheck(int randomNumber) // проверка на пятизначность числа
{
    int digitСapacity = 0; // счётчик цикла и разрядность числа в последней итерации цикла, возможно есть отдельный метод в C# для вычисления разрядности числа
    int buff = 0;
    for (int i = 1; buff != randomNumber; i *= 10)
    {
        buff = buff + i * ((randomNumber / i) % 10);
        digitСapacity++;
    }
    if (digitСapacity == 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool PalindromeCheck(int randomNumber) // проверка, является ли число палиндромом, алгоритм выдумывал сам, возможно есть более изящные способы решения, пытался придумать способ без ввода дополнительной переменной j - не получилось.
{
    double palindrom = 0; //метод Math.Pow не возвращает целые значения, только double
    int j = 1; //дополнительная переменная для последовательного деления числа на 1\10\100 ит.д.
    for (int i = 5; i > 0; i--) //i = 5, 5 - разрядность числа, в данной задаче она по умолчанию 5, в более общем случае нужно отдельно её посчитать с помощью метода выше
    {
        palindrom = palindrom + Math.Pow(10, i - 1) * ((randomNumber / j) % 10);
        j *= 10;
    }
    if (randomNumber == palindrom)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (DigitСapacityCheck(Math.Abs(number)))
{
    if (PalindromeCheck(Math.Abs(number)))
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
    System.Console.WriteLine("Введённое число не является пятизначным");
}
