double a = 1, b = -26, c = 120;
var d = b*b - 4*a*c;
double x1 = (-b + Math.Sqrt(d)) / 2* a;
double x2 = (-b - Math.Sqrt(d)) / 2* a;
System.Console.WriteLine($"X1 = {x1}; X2 = {x2}");