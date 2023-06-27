/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/

System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(System.Console.ReadLine());
int buff = number;
int counter = 0;
while (buff != 0)
{
    buff = buff / 2;
    counter++;
}
int[] array = new int[counter];

int i = 0;
while (number != 0)
{
    array[i] = number % 2;
    number = number / 2;
    i++;
}

Array.Reverse(array);
System.Console.WriteLine(String.Join("", array));
