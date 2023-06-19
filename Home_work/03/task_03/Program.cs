/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

double[] СubeTable(int randomNumber)
{
    double[] cubeTableArray = new double[randomNumber];
    for (int i = 0; i < cubeTableArray.Length; i++)
    {
        cubeTableArray[i] = Math.Pow(i + 1, 3);
    }
    return cubeTableArray;
}

void PrintArray(double[] randomArray)
{
    System.Console.Write("[");
    for (int i = 0; i < randomArray.Length - 1; i++)
    {
        System.Console.Write($"{randomArray[i]}, ");
    }
    System.Console.Write($"{randomArray[randomArray.Length - 1]}]");
}

System.Console.Write("Введите целое число N >= 1: ");
int number = Convert.ToInt32(System.Console.ReadLine());

if (number >= 1)
{
    System.Console.Write($"Таблица кубов от 1 до {number}: ");
    PrintArray(СubeTable(number));
    System.Console.WriteLine();
}
else
{
    System.Console.WriteLine("Ошибка ввода, число должно быть N >= 1");
}