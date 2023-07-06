/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

// Метод изменения цвета консоли и возврат цвета к дефолтному
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

//создание одномерного массива с суммами значений в строках
int[] SumOfRowElements(int[,] array2D)
{
    int sum;
    int[] sumOfRowElementsArray = new int[array2D.GetLength(0)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sum += array2D[i, j];
        }
        sumOfRowElementsArray[i] = sum;
    }
    return sumOfRowElementsArray;
}
/*ищем минимальное значение массива сумм в каждой строке двумерного массива, соответственно индекс минимального значения + 1 и будет номер строки с наименьшей суммой
Немного усложнил задачу, если минимальное значение повторяется, программа выдаст номер нескольких строк.
Для поиска минимального значения не стал расписывать подробно, воспользовавшись внутренним свойством Array.Min()*/
int[] RowWithMinimum(int[] sumOfRowElementsArray)
{
    int counter = 0; //Переменная, для расчёта длины массива с номерами строк
    for (int i = 0; i < sumOfRowElementsArray.Length; i++)
    {
        if (sumOfRowElementsArray[i] == sumOfRowElementsArray.Min()) counter++;
    }
    int[] rowWithMinimum = new int[counter];
    int k = 0;
    while (k < rowWithMinimum.Length)
    {
        for (int i = 0; i < sumOfRowElementsArray.Length; i++)
        {
            if (sumOfRowElementsArray[i] == sumOfRowElementsArray.Min())
            {
                rowWithMinimum[k] = i + 1;
                k++;
            }
        }
    }
    return rowWithMinimum;
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
print2dArray(array2D, "Вывод сгенерированного массива");
System.Console.WriteLine();
int[] rowWithMinimum = RowWithMinimum(SumOfRowElements(array2D));
System.Console.WriteLine($"{String.Join(",",rowWithMinimum)} строка(и) с минимальной суммой элементов в строках двумерного массива");