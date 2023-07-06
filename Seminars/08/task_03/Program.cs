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

//Простой метод поэлементного копирования двумерного массива, внутренний метод Array.Copy работает только для одномерных массивов
int[,] Copy2DArray(int[,] array2D)
{
    int[,] array2DCopy = new int[array2D.GetLength(0), array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2DCopy[i, j] = array2D[i, j];
        }
    }
    return array2DCopy;
}

//Для создания одномерного массива с неповторяющимися значениями двумерного нужно вычислить его длину, то есть количество уникальных значений двумерного массива
//вычисление вывел в отдельный метод. Метод основан на поэтапной замене значений на 0, но перед этим считается количество нулей в копии изначального массива
int arrayWithoutRepeatsLength(int[,] array2D)
{
    int counter = 0; //счётчик, считающий количество повторяющихся элементов в двумерном массиве
    int arrayValue; //дополнительная переменная, в которую циклически записывается значение массива, для вычисления количества повторений этого значения
    int arrayWithoutRepeatsLength = array2D.GetLength(0) * array2D.GetLength(1); //Начальное значение длины одномерного массива, равное количеству элементов изначального
    int[,] buffArray = Copy2DArray(array2D); //создаём копию изначального массива, для промежуточных вычислений

    for (int i = 0; i < buffArray.GetLength(0); i++)
    {
        for (int j = 0; j < buffArray.GetLength(1); j++)
        {
            if (buffArray[i, j] == 0) counter++; //Считаем нули
        }
    }
    if (counter != 0) arrayWithoutRepeatsLength = arrayWithoutRepeatsLength - counter + 1; //если нули есть, вычитаем их количество +1
    //Сложная структура из вложенных циклов, где вычисляется количество повторяющихся элементов приходится дважды проходить по массиву
    for (int i = 0; i < buffArray.GetLength(0); i++)
    {
        for (int j = 0; j < buffArray.GetLength(1); j++)
        {
            counter = 0;
            arrayValue = buffArray[i, j];
            for (int n = 0; n < buffArray.GetLength(0); n++)
            {
                for (int m = 0; m < buffArray.GetLength(1); m++)
                {
                    if (arrayValue == buffArray[n, m] && arrayValue != 0) //т.к. мы постепенно заполняем значения массива нулями, а они уже посчитаны в предыдущей группе циклов, это позволяет не обрабатывать повторяющиеся элементы
                    {
                        counter++; //считаем количество повторяющегося элемента
                        buffArray[n, m] = 0; //и записываем в него ноль, для корректной работы условия
                    }
                }
            }
            if (counter != 0) arrayWithoutRepeatsLength = arrayWithoutRepeatsLength - counter + 1; //продолжаем вычислять длину одномерного массива
        }
    }
    return arrayWithoutRepeatsLength;
}


//метод заполнения одномерного массива, с рассчитанной в предыдущем методе длиной
int[] ArrayWithoutRepeats(int[,] array2D, int arrayWithoutRepeatsLength)
{
    int[] arrayWithoutRepeats = new int[arrayWithoutRepeatsLength]; //инициализация массива, который будем заполнять не повторяющимися значениями изначального двумерного массива
    int counter = 0; //счётчик повторяющихся значений
    int arrayValue; //дополнительная переменная, в которую циклически записывается значение массива, для вычисления количества повторений этого значения
    int n; //индексатор одномерного массива int[] arrayWithoutRepeats
    int[,] buffArray = Copy2DArray(array2D); //создание буферной копии изначального массива для вычислений    
//Считаем нули в изначальном массиве, если они есть, то первое значение одномерного массива записываем 0, и присваиваем индексатору значение 1, если нет, то индексатору присватается значение 0.
    for (int i = 0; i < buffArray.GetLength(0); i++)
    {
        for (int j = 0; j < buffArray.GetLength(0); j++)
        {
            if (buffArray[i, j] == 0) counter++;
        }
    }
    if (counter != 0)
    {
        arrayWithoutRepeats[0] = 0;
        n = 1;
    }
    else n = 0;

//Очень сложная система вложенных циклов записи в одномерный массив всех уникальных значений изначального двумерного массива.
//Принцип такой же, как и при вычислении длины одномерного массива - перезапись нулями повторяющихся значений, которые не обрабатываются
    while (n < arrayWithoutRepeats.Length)
    {
        for (int i = 0; i < buffArray.GetLength(0); i++)
        {
            for (int j = 0; j < buffArray.GetLength(0); j++)
            {
                if (buffArray[i, j] != 0)
                {
                    arrayWithoutRepeats[n] = buffArray[i, j]; //записываем значение двумерного массива, если оно не равно нулю в одномерный и увеличиваем индексатор одномерного массива на единицу
                    n++;
                }
                arrayValue = buffArray[i, j];
                for (int k = 0; k < buffArray.GetLength(0); k++)
                {
                    for (int m = 0; m < buffArray.GetLength(1); m++)
                    {
                        if (arrayValue == buffArray[k, m] && arrayValue != 0) buffArray[k, m] = 0; //заполняем копию изначального массива нулями, для их исключения из обработки
                    }
                }
            }
        }
    }
    Array.Sort(arrayWithoutRepeats); //сортируем одномерный массив, не стал расписывать сортировку отдельным методом, воспользовавшись встроенным методом 
    return arrayWithoutRepeats;
}
//Получив одномерный массив, заполненный уникальными значениями изначального двумерного массива, можно посчитать сколько раз встречается каждое значение.
//записываем количество повторений значений в новый одномерный массив
int[] FrequencyDictionary(int[] arrayWithoutRepeats, int[,] array2D)
{
    int counter; //счётчик повторений значения
    int[] frequencyArray = new int[arrayWithoutRepeats.Length]; //массив, куда будет записываться количество повторений
    //первый цикл - запись в массив повторений, k - индексатор массива повторений значений
    for (int k = 0; k < frequencyArray.Length; k++) 
    {
        counter = 0;
        for (int i = 0; i < array2D.GetLength(0); i++) //проходим по изначальному массиву
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
int[] arrayWithoutRepeats = ArrayWithoutRepeats(array2D, arrayWithoutRepeatsLength(array2D));
int[] frequencyArray = FrequencyDictionary(arrayWithoutRepeats, array2D);

//Получив два одномерных массива, первый - уникальные значения изначального двумерного массива, второй количество повторений этих значений соответственно. Выводим частотный словарь.
for (int i = 0; i < arrayWithoutRepeats.Length; i++)
{
    System.Console.WriteLine($"Значение массива {arrayWithoutRepeats[i]} встречается {frequencyArray[i]} раз(а)");
}

/*Код вышел очень громоздкий, с большим количеством вложенных циклов, но работает. Так же подобный принцип создания частотного словаря будет работать с любыми массивами,
 если в коде изменить типизацию. Задача показалась интересной*/