/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


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

// Проверка, есть ли искомое значение в массиве
bool FindingValueInArray(int[,] array2D, int findValue)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] == findValue) return true;
        }
    }
    return false;
}

// Метод поиска и записи в одномерный новый массив индексов искомого значения в двумерном сгенерированном входящем массиве.
// Каждая пара значений нового одномерного массива - индексы искомого значения сгенерированного двумерного массива
int[] FindingIndexOfArrayValue(int[,] array2D, int findValue)
{
    int counter = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] == findValue) counter += 2;
        }
    }
    int[] indexArray = new int[counter];
    int n = 0; //дополнительная переменная для индексации созданного indexArray массива
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] == findValue)
            {
                indexArray[n] = i;
                indexArray[n + 1] = j;
                n += 2;
            }
        }
    }
    return indexArray;
}



int row = VariableCreationInt("Введите количество строк двумерного массива: ");
int col = VariableCreationInt("Введите количество столбцов двумерного массива: ");
int min = VariableCreationInt("Введите минимальное значение двумерного массива (целые числа): ");
int max = VariableCreationInt("Введите максимальное значение двумерного массива (целые числа): ");
if (min > max)
{
    printColor("Минимальное значение массива не может быть больше максимального\n", ConsoleColor.Red);
    return;
}
int[,] array2D = filling2DArray(row, col, min, max);
print2dArray(array2D, "Вывод двумерного массива, заполненного случайными целыми числами в заданном диапазоне");
System.Console.WriteLine();
int findingValue = VariableCreationInt("Введите значение для поиска его в массиве: ");
if (FindingValueInArray(array2D, findingValue))
{
    int[] indexValueArray = FindingIndexOfArrayValue(array2D, findingValue);
    System.Console.Write($"Индексы всех значений {findingValue} в сгенерированном двумерном массиве: ");
    for (int i = 0; i < indexValueArray.Length; i += 2)
    {
        printColor($"({indexValueArray[i]}; {indexValueArray[i + 1]}) ", ConsoleColor.Green); //вывод по порядку индексов искомого значения парами
    }
    System.Console.WriteLine();
}
else
{
    printColor($"Элемент со значением {findingValue} в двумерном массиве отсутствует\n", ConsoleColor.Red);
}