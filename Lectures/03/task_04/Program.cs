
int[] arrayGeneretion()
{
    int[] array = new int[10];
    for (int i = 0; i < 10; i++)
    {
        array[i] = new Random().Next(0, 11);
    }
    return array;
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

int[] SortArray(int[] randomArray)
{
    int buff;
    for (int i = 0; i < randomArray.Length; i++)
    {
        for (int j = i + 1; j < randomArray.Length; j++)
        {
            if (randomArray[j] < randomArray[i])
            {
                buff = randomArray[i];
                randomArray[i] = randomArray[j];
                randomArray[j] = buff;
            }
        }
    }
    return randomArray;
}

int[] array = arrayGeneretion();
PrintArray(array);
System.Console.WriteLine();
array = SortArray(array);
PrintArray(array);
System.Console.WriteLine();