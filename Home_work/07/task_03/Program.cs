/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
void print2dArray(int[,] array, string text)
{
    System.Console.WriteLine();
    printColor(text, ConsoleColor.Green);
    System.Console.WriteLine();
    System.Console.WriteLine();
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Метод печати строки с изменением цвета консоли и возврат цвета к дефолтному
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

int[,] filling2DArray(int rowCount, int colCount, int minimalArrayValue, int maximalArrayValue)
{
    int[,] array2D = new int[rowCount, colCount];
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(minimalArrayValue, maximalArrayValue + 1);
        }
    }
    return array2D;
}



double[] MeanOf2DArrayCol(int[,] array2D)
{
    double[] meanArray = new double[array2D.GetLength(1)];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            sum += array2D[i, j];
        }
        meanArray[j] = sum / array2D.GetLength(0);
    }
    return meanArray;
}



int row = VariableCreationInt("Введите количество строк двумерного массива: ");
int col = VariableCreationInt("Введите количество столбцов двумерного массива: ");
int min = VariableCreationInt("Введите минимальное значение двумерного массива(целые числа): ");
int max = VariableCreationInt("Введите максимальное значение двумерного массива(целые числа): ");
if (min > max)
{
    printColor("Минимальное значение массива не может быть больше максимального\n", ConsoleColor.Red);
    return;
}
int[,] array2D = filling2DArray(row, col, min, max);
print2dArray(array2D, "Вывод двумерного массива, заполненного случайными целыми числами в заданном диапазоне");
System.Console.WriteLine();
double[] meanArray = MeanOf2DArrayCol(array2D);
for (int i = 0; i < meanArray.Length; i++)
{
    System.Console.Write($"Среднее арифметическое {i + 1} колонки сгенерированного двумерного массива: ");
    printColor($"{meanArray[i]}\n", ConsoleColor.Green);
}