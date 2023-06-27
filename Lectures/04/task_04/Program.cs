int[] Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());
int[] fibonacciArray = new int[n];

Fibonacci(fibonacciArray);

System.Console.WriteLine($"{string.Join("; ", fibonacciArray)}");