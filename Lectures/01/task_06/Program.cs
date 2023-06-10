int a = 10;
int b = 9;
int c = -5;
int f = 0;
int e = 15;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (f > max) max = f;
if (e > max) max = e;

Console.WriteLine (max);