int number = new Random().Next(10,100);
System.Console.WriteLine(number);
int NumberFirst = number / 10;
int NumberSecond = number % 10;
if (NumberFirst < NumberSecond)
{
    System.Console.WriteLine(NumberSecond);
}
else if (NumberFirst > NumberSecond)
{
    System.Console.WriteLine(NumberFirst);    
}
else
{
    System.Console.WriteLine("Обе цифры в числе рваны");
}