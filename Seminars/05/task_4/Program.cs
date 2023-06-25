
/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 5);

    }
    return arr;
}

int[] MultArray(int[] array)
{
    int count;
    if (array.Length % 2 == 0)
    {
        count = array.Length / 2;
    }
    else
    {
        count = array.Length / 2 + 1;
    }
    int[] multArray = new int[count];
    if (array.Length % 2 == 0)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            multArray[i] = array[i] * array[array.Length - 1 - i];
        }
        return multArray;
    }
    else
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            multArray[i] = array[i] * array[array.Length - 1 - i];
        }
        multArray[count - 1] = array[array.Length / 2];
        return multArray;
    }

}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
int[] multArray = MultArray(array);
System.Console.WriteLine(string.Join("; ", multArray));