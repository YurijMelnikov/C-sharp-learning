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
int[] FillingArrayDoubleDigits()
{
    int[] arrayDoubleDigits = new int[180]; //создаём одномерный массив для заполнения его двузначными числами, с длиной 180, столько существует двузначных чисел
    for (int i = 0; i < arrayDoubleDigits.Length - 90; i++) //заполняем отрицательными значениями [-99; -10]
    {
        arrayDoubleDigits[i] = i - 99;
    }
    for (int i = arrayDoubleDigits.Length - 90; i < arrayDoubleDigits.Length; i++) //заполняем положительными значениями [10; 99]
    {
        arrayDoubleDigits[i] = i - 80;
    }
    Random rnd = new Random();
    int FirstIndex;
    int SecondIndex;
    int buff;
    for (int n = 0; n <= 1000; n++) //перемешиваем случайным образом значения массива
    {
        FirstIndex = rnd.Next(0, 180);
        SecondIndex = rnd.Next(0, 180);
        buff = arrayDoubleDigits[FirstIndex];
        arrayDoubleDigits[FirstIndex] = arrayDoubleDigits[SecondIndex];
        arrayDoubleDigits[SecondIndex] = buff;
    }
    return arrayDoubleDigits;
}

int[,,] FillingArrayRandomTwoDigitNumbers(int rowCount,
                                          int colCount,
                                          int pageCount,
                                          int[] arrayDoubleDigits) //массив, заполненный случайными не повторяющимися двузначными числами                                          
{
    int[,,] array3D = new int[rowCount, colCount, pageCount];
    int n = 0;
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
int[,,] array3DDoubleDigits = FillingArrayRandomTwoDigitNumbers(
                                                                rowCount: row,
                                                                colCount: col,
                                                                pageCount: page,
                                                                arrayDoubleDigits: FillingArrayDoubleDigits());
print3DArray(array3DDoubleDigits,"Вывод трёхмерного массива");