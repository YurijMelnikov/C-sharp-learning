/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int sum;
    int[,] matrixMult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixMult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMult.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            matrixMult[i, j] = sum;
        }
    }
    return matrixMult;
}

int row1 = VariableCreationInt("Введите количество строк первой матрицы: ");
int col1 = VariableCreationInt("Введите количество столбцов первой матрицы: ");
int min1 = VariableCreationInt("Введите минимальное значение первой матрицы (целые числа): ");
int max1 = VariableCreationInt("Введите максимальное значение первой матрицы (целые числа): ");
if (min1 > max1)
{
    printColor("Минимальное значение матрицы не может быть больше максимального\n", ConsoleColor.Red);
    return;
}
int row2 = VariableCreationInt("Введите количество строк второй матрицы: ");
int col2 = VariableCreationInt("Введите количество столбцов второй матрицы: ");
int min2 = VariableCreationInt("Введите минимальное значение второй матрицы (целые числа): ");
int max2 = VariableCreationInt("Введите максимальное значение второй матрицы (целые числа): ");
if (col1 != row2)
{
    printColor("Произведение матриц не возможно, матрицы не согласованы. \nЧисло столбцов первой матрицы, должно быть равно числу строк второй матрицы\n", ConsoleColor.Red);
    return;
}
int[,] matrix1 = filling2DArray(row1, col1, min1, max1);
int[,] matrix2 = filling2DArray(row2, col2, min2, max2);
print2dArray(matrix1, "Первая сгенерированная из целых чисел матрица");
print2dArray(matrix2, "Вторая сгенерированная из целых чисел матрица");
int[,] matrix1MultMatrix2 = MatrixMultiplication(matrix1, matrix2);
print2dArray(matrix1MultMatrix2, "Произведение матриц");