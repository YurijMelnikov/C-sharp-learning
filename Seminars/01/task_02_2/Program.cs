/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine ("Дня недели с таким номером не существует");
    return;
}
if (day == 1) Console.WriteLine ("Понедельник");
if (day == 2) Console.WriteLine ("Вторник");
if (day == 3) Console.WriteLine ("Среда");
if (day == 4) Console.WriteLine ("Четверг");
if (day == 5) Console.WriteLine ("Пятница");
if (day == 6) Console.WriteLine ("Суббота");
if (day == 7) Console.WriteLine ("Воскресенье");