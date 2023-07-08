/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//Несколько строчек кода, но как они работают в голове совсем не укладывается.
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    else if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    else return -1; //если условия не выполнены, следовательно значение функции Аккермена не определено, т.к. значение может быть только положительным: вернём -1.
}


int m = VariableCreationInt("Введите первый аргумент функции Аккермана: ");
int n = VariableCreationInt("Введите второй аргумент функции Аккермана: ");
int result = AckermannFunction(m, n);
if (result != -1) System.Console.WriteLine($"Значение функции Аккермена A({m}, {n}) = {result}");
else System.Console.WriteLine("Для данных аргументов значение функции Аккермана не определено");