/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
//Немного усложнил условие задачи, взяв для вывода не только натуральные числе, но и целые отрицательные, чисто для интереса

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Рассчитываем длину массива для заполнения натуральными числами в заданном диапазоне и инициализируем его
int[] ArrayWithNaturalNumbers(int value)
{
    if (value >= 1)
    {
        int[] array = new int[value];
        return array;
    }
    else
    {
        int[] array = new int[Math.Abs(value) + 2];
        return array;
    }
}

//Заполняем рекурсивно пустой массив, созданный предыдущим методом, попробовал описать логику и для отрицательных чисел
int[] FilingArrayWithNaturalNumbersInRange(int value, int[] emptyArray)
{
    switch (value)
    {
        case 1:
            emptyArray[emptyArray.Length - 1] = 1;
            return emptyArray;

        case 0:
            FilingArrayWithNaturalNumbersInRange(value + 1, emptyArray);
            emptyArray[emptyArray.Length - 1 - 1] = 0;
            return emptyArray;

        case > 1:
            FilingArrayWithNaturalNumbersInRange(value - 1, emptyArray);
            emptyArray[emptyArray.Length - value] = value;
            return emptyArray;

        case < 0:
            FilingArrayWithNaturalNumbersInRange(value + 1, emptyArray);
            emptyArray[emptyArray.Length - (Math.Abs(value) + 2)] = value;
            return emptyArray;

    }
}


int number = VariableCreationInt("Введите число: ");
int[] arrayWithNaturalNumbersInRange = ArrayWithNaturalNumbers(number);
FilingArrayWithNaturalNumbersInRange(number, arrayWithNaturalNumbersInRange);
System.Console.WriteLine($"{String.Join(", ", arrayWithNaturalNumbersInRange)}");