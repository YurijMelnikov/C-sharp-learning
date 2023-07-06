/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//метод спирального заполнения массива
int[,] SpiralFilling2DArray(int rowCount, int colCount)
{
    /*Для спирального заполнения массива будем заполнять поочерёдно каждый прямоугольник из элементов двигаясь к центру массива
    Введём дополнительную переменную для обозначения номера прямоугольника в массиве */

    int rectangleNumber = 0; //номер условного прямоугольника из элементов массива, увеличение в условии на единицу, позволяет заполнять следующий прямоугольник

    int i = 0; //инициализация первого индекса двумерного массива 
    int j = 0; //инициализация второго индекса двумерного массива
    int counter = 1; // Счётчик цикла
    int value = 1; //начальное значение для спирального заполнения
    int[,] array2D = new int[rowCount, colCount]; //Инициализация пустого массива, который будет спирально заполняться
    while (counter <= array2D.GetLength(0) * array2D.GetLength(1)) //Цикл заполнения массива, переменная counter - счётчик цикла, выход из цикла все заполненные ячейки
    {
        array2D[i, j] = value; //начинаем заполнять, входя в разные условия при которых меняется один из индексаторов
        //Заполнение верхней строчки прямоугольника, заполняем слева направо. Пока условие выполняется, увеличивается индексатор j.
        // Когда условие перестаёт выполняться, 
        //идёт переход к следующей стороне условного прямоугольника
        if (i == rectangleNumber && j < array2D.GetLength(1) - rectangleNumber - 1) 
        {
            j++;
        }
        //Вход условие для увеличения индексатора i, для заполнения правой строчки прямоугольника сверху вниз
        else if (j == array2D.GetLength(1) - rectangleNumber - 1 && i < array2D.GetLength(0) - rectangleNumber - 1) 
        {
            i++;
        }
        //Вход условие для уменьшения индексатора j, для заполнения нижней строчки прямоугольника справа налево
        else if (i == array2D.GetLength(0) - rectangleNumber - 1 && j > rectangleNumber) 
        {
            j--;
        }
        //Вход в условие для уменьшения индексатора i, для заполнения левой строчки прямоугольника снизу вверх
        else if (j == rectangleNumber && i > rectangleNumber) 
        {
            i--;
        }
        /*Условие, при котором заполнен первый прямоугольник и идёт переход ко второму. 
        Переменная номера прямоугольника rectangleNumber увеличивается на единицу
        Третий операнд в условии нужен для конечного заполнения массива, когда заполняется не прямоугольник, а линия.*/
        if ((i == rectangleNumber + 1) && (j == rectangleNumber) && (rectangleNumber != array2D.GetLength(1) - rectangleNumber - 1)) 
        {
            rectangleNumber++;
        }
        value++;
        counter++;  //увеличиваем счётчик цикла на единицу, необходимо для условия выхода из цикла
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
print2dArray(SpiralFilling2DArray(row, col), "Вывод спирально заполненного массива");