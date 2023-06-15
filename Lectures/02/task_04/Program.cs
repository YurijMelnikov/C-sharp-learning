int Find(int[] Array, int arg1)
{
    int counter = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] == arg1) counter++;
    }
    return counter;
}

int[] array = new int[] { 5, 2, 4, 5, 6, 7, 8, 9, 4, 1, 2, 3, 4, 6 };
System.Console.Write("Сколько раз в массиве повторяется заданное число?");
int findOfNumber = Convert.ToInt32 (Console.ReadLine());
int result = Find (array, findOfNumber);
System.Console.WriteLine($"Число {findOfNumber} встречается в массиве {result} раз");