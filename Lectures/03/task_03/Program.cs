
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
    // int [] sortedArray = new int[randomArray.Length];
    for (int i = 0; i < randomArray.Length - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < randomArray.Length; j++)
        {
            if (randomArray[j] < randomArray[minIndex])
            {
                minIndex = j;
            }
        }
        int buff = randomArray[i];
        randomArray[i] = randomArray[minIndex];
        randomArray[minIndex] = buff;
    }
    return randomArray;
}

int[] array = arrayGeneretion();
PrintArray(array);
System.Console.WriteLine();
array = SortArray(array);
PrintArray(array);
System.Console.WriteLine();