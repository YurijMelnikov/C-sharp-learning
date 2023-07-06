/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*Основная идея, заполнить периметр двумерного массива и далее опираться на него в логике, у пустого массива все значения нули*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//метод спирального заполнения массива
int[,] SprialFilling2DArray(int rowCount, int colCount)
{
    int[,] array2D = new int[rowCount, colCount];
    int value = 1; //начальное значение массива
    //система циклов для заполнения периметра массива, нужно для работы дальнейшей логики
    int j, i;
    for (j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[0, j] = value;
        value++;
    }
    for (i = 1; i < array2D.GetLength(0); i++)
    {
        array2D[i, array2D.GetLength(1) - 1] = value;
        value++;
    }
    for (j = array2D.GetLength(1) - 1 - 1; j >= 0; j--)
    {
        array2D[array2D.GetLength(0) - 1, j] = value;
        value++;
    }
    for (i = array2D.GetLength(0) - 1 - 1; i > 0; i--)
    {
        array2D[i, 0] = value;
        value++;
    }
    i = 1;
    j = 1; //начальное значение индексов для заполнения внутренних прямоугольников
    //основной цикл спирального заполнения  массива, работает пока значение меньше максимально возможного значения массива
    while (value < array2D.GetLength(0) * array2D.GetLength(1))
    {
        while (array2D[i, j + 1] == 0) //заполнение слева направо и остановка, когда следующее значение будет не равно нулю - для этого и заполняли периметр массива
        {
            array2D[i, j] = value;
            value++;
            j++;
        }
        while (array2D[i + 1, j] == 0) //заполнение сверху вниз 
        {
            array2D[i, j] = value;
            value++;
            i++;
        }
        while (array2D[i, j - 1] == 0) //заполнение справа налево
        {
            array2D[i, j] = value;
            value++;
            j--;
        }
        while (array2D[i - 1, j] == 0) //заполнение снизу вверх
        {
            array2D[i, j] = value;
            value++;
            i--;
        }
        //после отработки всех вложенных циклов, индексы будут i = 2, j = 2, то есть происходит переход к следующему прямоугольнику и так далее,
        //пока не останется последний не заполненный элемент массива, то есть ноль. Из-за условия он не заполняется

    }
    //ищем последний не заполненный элемент массива: 0 и заполняем
    for (i = 0; i < array2D.GetLength(0); i++)
    {
        for (j = 0; j < array2D.GetLength(1); j++)
        {
            if (array2D[i, j] == 0) array2D[i, j] = value;
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



int row = VariableCreationInt("Введите количество строк двумерного массива: ");
int col = VariableCreationInt("Введите количество столбцов двумерного массива: ");
print2dArray(SprialFilling2DArray(row, col), "Вывод спирально заполненного массива");