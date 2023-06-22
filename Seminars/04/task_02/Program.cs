/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/



System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitCapacity(int num)
{
    int digitCapacity = 0;
    int buff = 0;
    if (num == 0)
    {
        digitCapacity = 1;
        return digitCapacity;
    }
    else
    {
        for (int i = 1; buff != num; i *= 10)
        {
            buff = buff + i * ((num / i) % 10);
            digitCapacity++;
        }
        return digitCapacity;
    }
}
System.Console.WriteLine($"Количество разрядов числа {number} - {DigitCapacity(number)}");