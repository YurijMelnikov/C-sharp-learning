System.Console.Write("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"{Fibonacci(i)}");
}