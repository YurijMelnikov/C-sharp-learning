string[,] table = new string[2, 5];
table[1, 2] = "date";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }
}

int[,] FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-10, 11);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            System.Console.Write($"{array[rows, columns]} ");
            // System.Console.Write($"{string.Join(" ;", matrix[rows, columns])}");       
        }
        System.Console.WriteLine();
    }    
}
int[,] matrix = new int[3, 4];
FillArray(matrix);
Print2DArray(matrix);