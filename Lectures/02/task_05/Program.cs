System.Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

void FillArray(int[] RandomArray)
{
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(-10, 11);
    }
}

void PrintArray(int[] randomArray)
{
    System.Console.Write("[");
    for (int i = 0; i < randomArray.Length - 1; i++)
    {
        System.Console.Write($"{randomArray[i]}, ");
    }
    System.Console.Write($"{randomArray[randomArray.Length - 1]}]");
}
int IndexOff(int[] randomArray, int find)
{
    int position = -1;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == find)
        {
            position = i;
            break;
        }

    }
    return position;
}

FillArray(array);
PrintArray(array);
System.Console.WriteLine("\nВведите значение массива, индекс которого нужно найти");
int findNumber = Convert.ToInt32(Console.ReadLine());
int position = IndexOff(array, findNumber);
if (position != -1)
{
    System.Console.WriteLine($"Индекс первого значения массива {findNumber} равен {position}");
}
else
{
    System.Console.WriteLine($"Значение {findNumber} в массиве отсутствует");
}