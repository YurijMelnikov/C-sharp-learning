/*
Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/

//Идея решения состоит в создании обычного одномерного массива, который будет состоять из всех значений заданного двумерного массива, но без 
//повторов. Далее просто считаем сколько раз встречается в двумерном массиве, каждое из его значений, записанные в одномерный массив без повторов. Ниже подробнее 
//опишу логику методов


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

//Простой метод преобразования двумерного массива в одномерный, для уменьшения количества вложенных циклов и упрощения кода
int[] Convert2DArrayTo1D(int[,] array2D)
{
    int[] array2DTo1D = new int[array2D.GetLength(0) * array2D.GetLength(1)];
    int k = 0;
    while (k < array2DTo1D.Length)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                array2DTo1D[k] = array2D[i, j];
                k++;
            }
        }
    }
    return array2DTo1D;
}
//Для создания одномерного массива с неповторяющимися значениями двумерного изначального, нужно вычислить его длину, то есть количество уникальных значений двумерного изначального массива
//вычисление вывел в отдельный метод. Метод основан на поэтапной замене значений на 0, которые в дальнейшем не будут обрабатываться в проходах,
// но перед этим считается количество нулей в преобразованном в одномерный массив для упрощения организации циклов
int ArrayWithoutRepeatsLength(int[,] array2D)
{
    int counter = 0; //счётчик, считающий количество повторяющихся элементов в двумерном массиве
    int arrayValue; //дополнительная переменная, в которую циклически записывается значение массива, для вычисления количества повторений этого значения
    int arrayWithoutRepeatsLength = array2D.GetLength(0) * array2D.GetLength(1); //Начальное значение длины одномерного массива, равное количеству элементов изначального двумерного
    int[] array2DTo1D = Convert2DArrayTo1D(array2D); //создаём одномерный массив на основе двумерного, для промежуточных вычислений
    for (int i = 0; i < array2DTo1D.Length; i++)
    {
        if (array2DTo1D[i] == 0) counter++; //Считаем нули        
    }
    if (counter != 0) arrayWithoutRepeatsLength = arrayWithoutRepeatsLength - counter + 1; //если нули есть, вычитаем их количество + 1
    //Система циклов, где вычисляется количество повторяющихся элементов приходится дважды проходить по массиву
    for (int i = 0; i < array2DTo1D.Length; i++)
    {
        counter = 0;
        arrayValue = array2DTo1D[i];
        for (int j = 0; j < array2DTo1D.Length; j++)
        {
            if (arrayValue == array2DTo1D[j] && arrayValue != 0) //т.к. мы постепенно заполняем значения массива нулями, а они уже посчитаны в предыдущей группе циклов, это позволяет не обрабатывать повторяющиеся элементы
            {
                counter++; //считаем сколько раз встречается значение в массиве
                array2DTo1D[j] = 0; //и записываем в него ноль, для корректной работы условия
            }
        }
        if (counter != 0) arrayWithoutRepeatsLength = arrayWithoutRepeatsLength - counter + 1; //продолжаем вычислять длину одномерного массива
    }
    return arrayWithoutRepeatsLength;
}
//метод заполнения одномерного массива, уникальными значениями двумерного, с рассчитанной в предыдущем методе длиной
int[] ArrayWithoutRepeats(int[,] array2D, int arrayWithoutRepeatsLength)
{
    int[] arrayWithoutRepeats = new int[arrayWithoutRepeatsLength]; //инициализация массива, который будем заполнять не повторяющимися значениями изначального двумерного массива
    int counter = 0; //счётчик повторяющихся значений
    int arrayValue; //дополнительная переменная, в которую циклически записывается значение массива, для вычисления количества повторений этого значения
    int n; //индексатор одномерного массива int[] arrayWithoutRepeats
    int[] array2DTo1D = Convert2DArrayTo1D(array2D); //создаём одномерный массив на основе двумерного, для промежуточных вычислений 
    //Считаем нули в изначальном массиве, если они есть, то первое значение одномерного массива записываем 0, и присваиваем индексатору значение 1, если нет, то индексатору присватается значение 0.
    for (int i = 0; i < array2DTo1D.Length; i++)
    {
        if (array2DTo1D[i] == 0) counter++; //Считаем нули        
    }
    if (counter != 0)
    {
        arrayWithoutRepeats[0] = 0;
        n = 1;
    }
    else n = 0;

    //Система вложенных циклов для записи в одномерный массив всех уникальных значений изначального двумерного массива.
    //Принцип такой же, как и при вычислении длины одномерного массива - перезапись нулями повторяющихся значений, которые не обрабатываются в дальнейших проходах из-за заданного условия
    while (n < arrayWithoutRepeats.Length)
    {
        for (int i = 0; i < array2DTo1D.Length; i++)
        {
            if (array2DTo1D[i] != 0)
            {
                arrayWithoutRepeats[n] = array2DTo1D[i]; //записываем значение двумерного массива, если оно не равно нулю в одномерный и увеличиваем индексатор одномерного массива на единицу
                n++;
            }
            arrayValue = array2DTo1D[i];
            for (int j = 0; j < array2DTo1D.Length; j++)
            {
                if (arrayValue == array2DTo1D[j] && arrayValue != 0) array2DTo1D[j] = 0; //заполняем в одномерный массив, созданный из изначального двумерного массива, нулями, для их исключения из обработки               
            }
        }
    }
    Array.Sort(arrayWithoutRepeats); //сортируем одномерный массив, не стал расписывать сортировку отдельным методом, воспользовавшись встроенным методом 
    return arrayWithoutRepeats;
}

//Далее всё проще, проходим по массиву и считаем сколько раз встречается каждое из значений, записывая их в новый одномерный массив. 
int[] FrequencyDictionary(int[] arrayWithoutRepeats, int[,] array2D)
{
    int counter; //счётчик повторений значения
    int[] frequencyArray = new int[arrayWithoutRepeats.Length]; //массив, куда будет записываться количество повторений
    //первый цикл - запись в массив повторений, k - индексатор массива повторений значений
    for (int k = 0; k < frequencyArray.Length; k++) 
    {
        counter = 0;
        for (int i = 0; i < array2D.GetLength(0); i++) //проходим по изначальному двумерному массиву
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (arrayWithoutRepeats[k] == array2D[i, j]) counter++;
            }
        }
        frequencyArray[k] = counter;
    }
    return frequencyArray;
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
int[] arrayWithoutRepeats = ArrayWithoutRepeats(array2D, ArrayWithoutRepeatsLength(array2D));
int[] frequencyArray = FrequencyDictionary(arrayWithoutRepeats, array2D);
//Получив два одномерных массива, первый - уникальные значения изначального двумерного массива, второй количество повторений этих значений соответственно. Выводим частотный словарь.
for (int i = 0; i < arrayWithoutRepeats.Length; i++)
{
    System.Console.WriteLine($"Значение массива {arrayWithoutRepeats[i]} встречается {frequencyArray[i]} раз(а)");
}

/*Из-за преобразования двумерного массива в одномерный, организовать циклы стало проще и нагляднее, чем в предыдущем варианте решения задачи*/