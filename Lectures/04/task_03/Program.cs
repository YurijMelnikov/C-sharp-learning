System.Console.Write("Введите число: ");
int n = Convert.ToInt32(System.Console.ReadLine());
double Factorial(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 0; i <= n; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}