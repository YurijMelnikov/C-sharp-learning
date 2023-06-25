/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

double[] fillingArray(int arrayLength, double minimalArrayValue, double maximalArrayValue)
{
    double[] array = new double[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        //формула нахождения случайного вещественного числа в заданном диапазоне, честно подсмотрел в интернете её :) можно было сделать и через rnd.Next() + rnd.NextDouble(), но без точного указания минимального и максимального значения
        array[i] = Math.Round(rnd.NextDouble() * (maximalArrayValue - minimalArrayValue) + minimalArrayValue, 2);
    }
    return array;
}

double DifferenceBetweenMinimumAndMaximum(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return max - min;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите минимальное значение массива: ");
double min = Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("Введите максимальное значение массива: ");
double max = Convert.ToDouble(System.Console.ReadLine());
if (min > max)
{

    System.Console.WriteLine("Минимальное значение не может быть больше максимального");
    return;
}
double[] array = fillingArray(length, min, max);
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine($"Разница между максимальным значением массива {array.Max()} и минимальным значением массива {array.Min()}: {Math.Round(DifferenceBetweenMinimumAndMaximum(array), 2)}");
//можно было сделать проще, через метод array.Max() - array.Min(), но я учусь, лучше логику методов расписывать подробно, для тренировки