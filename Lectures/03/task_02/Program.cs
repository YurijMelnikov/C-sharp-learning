/*Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.*/
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            +"ежели бы вас послали вместо нашего милого "
            +"Винценгероде, вы бы взяли приступом согласие "
            +"прусского короля. Вы так красноречивы. Вы "
            +"дадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenth = text.Length;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(Replace (Replace(text, 'с', 'С'), 'к', 'К'), ' ', '_');
System.Console.WriteLine(newText);