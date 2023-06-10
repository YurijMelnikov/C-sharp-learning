/* Составить программу для нахождения частного двух чисел */
Console.WriteLine ("Введите первое число");
double number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
double number2 = Convert.ToInt32(Console.ReadLine());
double div = number1 / number2;
Console.WriteLine ($"Частное введённых двух целых чисел равна {div}");