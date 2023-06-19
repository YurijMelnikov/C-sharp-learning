/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/
string[] text = {"x > 0; y > 0",
                "x < 0; y > 0",
                "x < 0; y < 0",
                "x > 0 y < 0"};
System.Console.WriteLine("Введите номер четверти координатной плоскости");
int num = Convert.ToInt32(Console.ReadLine());
if ( num >= 1 && num <=4)
{
System.Console.WriteLine(text[num-1]);
}
else
{
    System.Console.WriteLine("Ввод четверти не корректен");
}