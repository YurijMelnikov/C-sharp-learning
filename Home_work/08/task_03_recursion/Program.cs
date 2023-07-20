/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void print3DArray(int[,,] array, string text)
{
    System.Console.WriteLine();
    printColor(text, ConsoleColor.Green);
    System.Console.WriteLine();
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                printColor($"{array[i, j, k]}", ConsoleColor.Green);
                System.Console.Write(" (");
                printColor($"{i},{j},{k}", ConsoleColor.DarkYellow);
                System.Console.Write(") ");
            }
        }
    }
    System.Console.WriteLine();
}

// Метод изменения цвета консоли и возврат цвета к дефолтному
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}
/*Рекурсивный метод по заполнению одномерного массива не повторяющимися случайными двузначными числами,
к сожалению зависает при приближении к максимально возможной длине массива, но логика любопытная*/
void NonRepeatingValues(int i, int[] array)
{
    if (i != array.Length)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(-99, 100);
        if (array[i] > -10 && array[i] < 10)
        {
            NonRepeatingValues(i, array);
        }
        else
        {
            for (int k = 0; k < i; k++)
            {
                if (array[i] == array[k])
                {
                    NonRepeatingValues(i, array);
                }
            }
            NonRepeatingValues(i + 1, array);
        }
    }
    else
    {
        return;
    }
}

int[,,] FillingArrayRandomTwoDigitNumbers(int rowCount,
                                          int colCount,
                                          int pageCount,
                                          int[] arrayDoubleDigits) //массив, заполненный случайными не повторяющимися двузначными числами                                          
{
    int[,,] array3D = new int[rowCount, colCount, pageCount];
    int n = 0;
    while (n < array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2))
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    array3D[i, j, k] = arrayDoubleDigits[n];
                    n++;
                }
            }
        }
    }
    return array3D;
}

int row = VariableCreationInt("Введите количество строк трёхмерного массива: ");
int col = VariableCreationInt("Введите количество столбцов трёхмерного массива: ");
int page = VariableCreationInt("Введите количество страниц трёхмерного массива: ");
if (row * col * page > 180)
{
    printColor("Трёхмерный массив не возможно заполнить не повторяющимися двухзначными числами, т.к. длина массива превышает возможное количество этих чисел\n", ConsoleColor.Red);
    return;
}
int[] arrayDoubleDigits = new int[row * col * page]; //создание одномерного массива с такой же длиной, как и у трёхмерного
NonRepeatingValues(0, arrayDoubleDigits); //заполнение массива случайными двузначными числами, очень нагружает систему, но сама логика любопытная
int[,,] array3DDoubleDigits = FillingArrayRandomTwoDigitNumbers(
                                                                rowCount: row,
                                                                colCount: col,
                                                                pageCount: page,
                                                                arrayDoubleDigits: arrayDoubleDigits);
print3DArray(array3DDoubleDigits, "Вывод трёхмерного массива");