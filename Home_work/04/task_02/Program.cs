/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int DigitSum(int num)
{
    int digit = 0;
    int buff;
    int sum = 0;
    int digitCount = 0;
    int pow = 1;
    for (int i = 1; Math.Abs(num) / i > 0; i *= 10)
    {
        buff = Math.Abs(num) / i;
        digitCount++;
    }
    System.Console.WriteLine(digitCount);
    if (num > 0)
    {
        for (int i = 1; i < Math.Pow(10, digitCount); i *= 10)
        {
            digit = ((num / i) % 10);
            sum = sum + digit;
        }
        return sum;
    }
    else if (num < 0)
    {
        for (int i = 1; i < Math.Pow(10, digitCount); i *= 10)
        {
            pow = i;
        }

        digit = (Math.Abs(num) / pow) % 10;
        sum = sum - digit;
        for (int i = 1; i < Math.Pow(10, digitCount - 1); i *= 10)
        {
            digit = ((Math.Abs(num) / i) % 10);
            sum = sum + digit;
        }
        return sum;
    }
    else
    {
        return sum;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Сумма цифр числа {number} равна {DigitSum(number)}\n(с учётом, если первая цифра имеет знак '-')");