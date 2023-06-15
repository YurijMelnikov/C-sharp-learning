/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int ThirdDigit(int randomNumber)
{
    while (Math.Abs(randomNumber) > 999)
    {
        randomNumber = randomNumber / 10;
    }
    int thirdDigit = Math.Abs(randomNumber % 10);
    return thirdDigit;
}


System.Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) < 100)
{
    System.Console.WriteLine("В числе третьей цифры нет");
}
else
{
    int thirdDigit = ThirdDigit(number);
    System.Console.WriteLine($"Третья цифра: {thirdDigit}");
}