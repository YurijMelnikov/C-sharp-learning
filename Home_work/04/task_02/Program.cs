/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int СonvertToInteger(double num) // метод преобразования вещественного числа в целое   % 1 будет само число и 0, когда в цикле число станет целым
{
    while (num % 1 != 0) // то есть, при последовательном умножении числа на 10, когда число станет целым остаток от деления на 1 будет 0 - цикл завершится
    {
        num *= 10;
    }
    return Convert.ToInt32(num);
}

int DigitSum(int num)
{
    int digit; //переменная цифры числа
    int sum = 0; //переменная накопления суммы цифр
    int digitCount = 0; //переменная для нахождения количества цифр в числе

    for (int i = 1; Math.Abs(num) / i > 0; i *= 10) //цикл нахождения количества цифр в числе
    {
        digitCount++;
    }
    if (num > 0)
    {
        for (int i = 1; i < Math.Pow(10, digitCount); i *= 10) //цикл нахождения суммы цифр числа, если оно больше 0
        {
            digit = (num / i) % 10;
            sum = sum + digit;
        }
        return sum;
    }
    else if (num < 0)
    {

        digit = (Math.Abs(num) / Convert.ToInt32(Math.Pow(10, digitCount - 1))) % 10; //Нахождение первой цифры числа, если оно отрицательное. Convert.ToInt32 используется из-за того, что метод Math.Pow возвращает тип double
        sum = sum - digit; //т.к.  число отрицательное, первую цифру отнимаем из суммы
        for (int i = 1; i < Math.Pow(10, digitCount - 1); i *= 10) //цикл нахождения суммы цифр отрицательное числа, но без первой цифры, которую учли выше
        {
            digit = ((Math.Abs(num) / i) % 10);
            sum = sum + digit;
        }
        return sum;
    }
    else //если число 0, вернётся 0 из начала метода
    {
        return sum;
    }
}

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа {number} равна {DigitSum(СonvertToInteger(number))}\n(в том числе, если первая цифра имеет знак '-')");