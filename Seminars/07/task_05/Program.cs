/*Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/
/*int [,] DeleteMinColRow (int [,] matrix)
{
  int [,] newMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
  int min = matrix [0,0];
  int minCol = 0;
  int minRow = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] < min)
      {
        min= matrix [i,j];
        minRow=i;
        minCol=j;

      }
    }
  }

  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      if (i<minRow&&j<minCol)
      {
      newMatrix[i,j]=matrix [i,j];
      }
      else if (i<minRow && j>=minCol)
      {
        newMatrix[i,j]=matrix [i,j+1];
      }
      else
      {
        newMatrix[i,j]=matrix [i+1,j+1];
      }

   
    }
    */
void Filling2DArray(int[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0, 11);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

int[,] MinusColAndRow(int[,] array2D)
{
    int[,] newArray2D = new int[array2D.GetLength(0) - 1, array2D.GetLength(1) - 1];
    int min = array2D[0, 0];
    int rowMin = 0;
    int colMin = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (min > array2D[i, j])
            {
                min = array2D[i, j];
                rowMin = i;
                colMin = j;
            }
        }
    }
    for (int i = 0; i < newArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < newArray2D.GetLength(1); j++)
        {
            if (i < rowMin && j < colMin) newArray2D[i, j] = array2D[i, j];
            else if (i < rowMin && j >= colMin) newArray2D[i, j] = array2D[i, j + 1];
            else if (i >= rowMin && j < colMin) newArray2D[i, j] = array2D[i + 1, j];
            else if (i >= rowMin && j >= colMin) newArray2D[i, j] = array2D[i + 1, j + 1];
        }
    }
    return newArray2D;
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
Filling2DArray(matrix);
Print2DArray(matrix);
System.Console.WriteLine();
int [,] newMatrix = MinusColAndRow(matrix);
Print2DArray(newMatrix);