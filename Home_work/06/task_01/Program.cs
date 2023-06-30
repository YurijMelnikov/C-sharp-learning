/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

double[] FilingArray(int arrayLength)
{
    double[] array = new double[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

int PositiveCount(double[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

System.Console.Write("Сколько чисел будет введено? ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FilingArray(length);
System.Console.WriteLine($"Количество введённых чисел больше нуля: {PositiveCount(array)}");