/*Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/


void PrintQuater(int x, int y)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Точка располагается во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Точка располагается в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("Точка располагается в четвертой четверти");
    }
    else
    {
        System.Console.WriteLine("Точка располагается на оси координат");
    }
}

System.Console.Write("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

PrintQuater(x, y);