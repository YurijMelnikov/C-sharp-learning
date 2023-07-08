/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
int SumNaturalElements(int M, int N)
{

    if (M == N && M >= 1 && N >= 1) return sum += M;
    else if (M <= N && M >= 1 && N >= 1) return sum = sum + M + SumNaturalElements(M + 1, N);
    else if (M >= N && M >= 1 && N >= 1) return sum = sum + N + SumNaturalElements(M, N + 1);
    else if (M < 1 && N >= 1) return SumNaturalElements(1, N);
    else if (M >= 1 && N < 1) return SumNaturalElements(M, 1);
    else return -1; //т.к. сумма натуральных элементов всегда положительна, вернём -1, если ни одно условие не подошло => натуральных элементов нет
}

int number1 = VariableCreationInt("Введите первое число: ");
int number2 = VariableCreationInt("Введите второе число: ");
sum = SumNaturalElements(number1, number2);
if (sum == -1)
{
    System.Console.WriteLine($"На отрезке [{number1}; {number2}] натуральных элементов нет");
    return;
}
else
{
    System.Console.WriteLine($"Сумма натуральных элементов на отрезке [{number1}; {number2}] равна: {sum}");
}