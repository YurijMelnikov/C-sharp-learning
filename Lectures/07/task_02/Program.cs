int Degree(int number, int degree)
{
    if (degree == 0) return 1;
    else
    {
        return number * Degree(number, degree - 1);
    }
}

int n = 10, m = 5;
System.Console.WriteLine(Degree(n, m));