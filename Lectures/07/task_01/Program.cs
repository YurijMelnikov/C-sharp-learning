int VariableCreationInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string NumbersToString(int valueA, int valueB)
{
    string text = string.Empty;
    for (int i = valueA; i <= valueB; i++)
    {
        text = text  + i + ';';
    }
    return text;
}




int a = VariableCreationInt("Введите число а: ");
int b = VariableCreationInt("Введите число b: ");
string text = NumbersToString(a, b);
System.Console.WriteLine(text);