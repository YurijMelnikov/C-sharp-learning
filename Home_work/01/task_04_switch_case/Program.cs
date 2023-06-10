System.Console.WriteLine("Вывести все чётные числа от 1 до числа N");
System.Console.Write("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int counter;
switch (numberN)
{
    case 1:
        System.Console.WriteLine("Чётных чисел в заданном диапазоне нет");
        break;
    case > 1:
        counter = 1;
        while (counter <= numberN)
        {
            if (counter % 2 == 0)
            {
                System.Console.Write($"{counter}  ");
            }
            counter++;
        }
        System.Console.WriteLine();
        break;
    case < 1:
        counter = 0;
        while (counter <= Math.Abs(numberN))
        {
            if (counter % 2 == 0)
            {
                System.Console.Write($"{-counter}  ");
            }
            counter++;
        }
        System.Console.WriteLine();
        break;
}

