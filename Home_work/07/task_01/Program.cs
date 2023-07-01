/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// Метод присвоения значений double переменным и печати приглашения ввода
double VariableCreationDouble(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

// Метод присвоения значений int переменным и печати приглашения ввода
int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Немного улучшенный метод печати двумерного массива, с цветными индексами
void print2dArray(double[,] array2D, string text)
{
    System.Console.WriteLine();
    printColor(text, ConsoleColor.Green);
    System.Console.WriteLine();
    System.Console.WriteLine();
    Console.Write("\t");
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Метод изменения цвета консоли и возврат цвета к дефолтному
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

double[,] filling2DArray(int rowCount, int colCount, double minimalArrayValue, double maximalArrayValue)
{
    double[,] array2D = new double[rowCount, colCount];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            //формула нахождения случайного вещественного числа в заданном диапазоне
            array2D[i, j] = Math.Round(rnd.NextDouble() * (maximalArrayValue - minimalArrayValue) + minimalArrayValue, 1);
        }
    }
    return array2D;
}

int row = VariableCreationInt("Введите количество строк двумерного массива: ");
int col = VariableCreationInt("Введите количество столбцов двумерного массива: ");
double min = VariableCreationDouble("Введите минимальное значение двумерного массива (вещественные числа): ");
double max = VariableCreationDouble("Введите максимальное значение двумерного массива (вещественные числа): ");
if (min > max)
{
    printColor("Минимальное значение массива не может быть больше максимального\n", ConsoleColor.Red);
    return;
}
double[,] array2D = filling2DArray(row, col, min, max);
print2dArray(array2D, "Вывод двумерного массива, заполненного случайными вещественными числами в заданном диапазоне");