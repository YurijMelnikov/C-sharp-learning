/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

void PrintArray(int[] randomArray)
{
    System.Console.Write("[");
    for (int i = 0; i < randomArray.Length - 1; i++)
    {
        System.Console.Write($"{randomArray[i]}, ");
    }
    System.Console.Write($"{randomArray[randomArray.Length - 1]}]\n");
}

Random rnd = new Random();
int [] array = new int [8];
System.Console.WriteLine($"[{string.Join("; ", array)}]");
for (int i =0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,2);
}

System.Console.WriteLine($"[{string.Join("; ", array)}]");