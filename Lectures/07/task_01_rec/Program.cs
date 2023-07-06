int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string NumbersToString(int valueA, int valueB)
{
    if (valueA < valueB)
    {
        return NumbersToString(valueA + 1, valueB) + " " + valueA;
    }
    else return string.Empty + valueB;
}


int a = VariableCreationInt("Введите число а: ");
int b = VariableCreationInt("Введите число b: ");
string text = NumbersToString(a, b);
System.Console.WriteLine(text);