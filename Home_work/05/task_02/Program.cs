/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

long[] fillingArray(int arrayLength)
{
    long[] array = new long[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(Int32.MinValue, Int32.MaxValue);
    }
    return array;
}

long SumOfOddPositions(long[] array)
{
    long sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());
long[] array = fillingArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine($"Сумма элементов массива с стоящих на нечётных позициях: {SumOfOddPositions(array)}");