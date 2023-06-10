Console.Clear();
// Console.SetCursorPosition (10, 20);
// Console.WriteLine ("@");

int x1 = 85, y1 = 1,
    x2 = 10, y2 = 50,
    x3 = 150, y3 = 50;

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int x = x1;
int y = y1;
int count = 0;
while (count < 10001)
{
    int random = new Random().Next(0, 3);
    if (random == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    if (random == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    if (random == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}