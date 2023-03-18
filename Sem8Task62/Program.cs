// Задача №62 
// Напишите программу, которая заполнит спирально массив 4 на 4.

// метод генерирует двумерный массив
void GenSpiral2DArr(int[,] arr)
{
  int temp = 1;
  int i = 0; int j = 0;
  while (temp <= arr.GetLength(0) * arr.GetLength(1))
  {
    arr[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < arr.GetLength(1) - 1) j++;
    else if (i < j && i + j >= arr.GetLength(0) - 1) i++;
    else if (i >= j && i + j > arr.GetLength(1) - 1) j--;
    else i--;
  }
}

// метод печатает двумерный массив
void Print2DArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
  }
}

int[,] testArr = new int[4, 4];
GenSpiral2DArr(testArr);
Print2DArr(testArr);

// Рекурсивный метод!
// создание массива
int[,] GenArry(int RowCount, int ColCount)
{
    int[,] binarray = new int[RowCount, ColCount];
    int buf = 0;
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < RowCount; i++)
    {
        for (int j = 0; j < ColCount; j++)
        {
            buf = SpiralFilling(RowCount, ColCount, j, i);
                binarray[i, j] = (buf);
        }
    }
    return binarray;
}

//Метод заполнения массива по спирали
int SpiralFilling(int w, int h, int x, int y)
{
    if (y != 0)
    {
        return w + SpiralFilling(h - 1, w, y - 1, w - x - 1);
    }
    else return x + 1;
}

int[,] FillSpiral(int[,] matrix, int startNumber = 1, int count = 1)
{
    for (int j = -1 + count; j < matrix.GetLength(1) + 1 - count; j++)
    {
        matrix[-1 + count, j] = startNumber++;
    }
    for (int i = count; i < matrix.GetLength(0) + 1 - count; i++)
    {
        matrix[i, matrix.GetLength(1) - count] = startNumber++;
    }
    for (int j = matrix.GetLength(1) - 1 - count; j > -1 + count; j--)
    {
        matrix[matrix.GetLength(0) - count, j] = startNumber++;
    }
    for (int i = matrix.GetLength(0) - count; i > -1 + count; i--)
    {
        matrix[i, -1 + count] = startNumber++;
    }
    if (startNumber <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        FillSpiral(matrix, startNumber, ++count);
    }
    return matrix;
}

Console.WriteLine();
int[,] arr2 = GenArry(4,4);
Print2DArr(arr2);
