/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

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

int[] CopyArray(int[] array)
{
    int[] NewArray = new int[array.Length];
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = array[i];
    }
    return NewArray;
}

System.Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(System.Console.ReadLine());
int[] array = fillingArray(length);

int [] newArray = CopyArray(array);
array [0] = 0;
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine($"[{string.Join("; ", newArray)}]");