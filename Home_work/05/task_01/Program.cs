/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] fillingArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int CountEvenNumber(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());
int[] array = fillingArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine($"Количество чётных чисел в массиве {CountEvenNumber(array)}");