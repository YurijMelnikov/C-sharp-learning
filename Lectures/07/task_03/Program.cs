int Factrorial(int n)
{
    if (n == 0 || n == 1) return 1;
    else return n * Factrorial(n - 1);
}
int n = 10;
System.Console.WriteLine(Factrorial(n));