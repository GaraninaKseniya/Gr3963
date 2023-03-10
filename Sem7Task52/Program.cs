// Задача №52 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

// метод генерирует двумерный массив
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  int[,] arr = new int[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = new Random().Next(min, max + 1);
    }
  }
  return arr;
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

// метод находит среднее арифметическое элементов в столбце
double[] ColumnMean(int[,] arr)
{
  double[] resArr = new double[arr.GetLength(1)];
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      resArr[j] += arr[i, j];
    }
    resArr[j] = resArr[j] / arr.GetLength(0);
    resArr[j] =Math.Round(resArr[j],1);
  }
  return resArr;
}

// метод печатает одномерный массив
void Print1DArr(double[] resArr)
{
  for (int i = 0; i < resArr.Length; i++)
  {
    Console.Write(resArr[i] + "\t");
  }
}

int[,] testArr = Gen2DArr(5, 5, 1, 10);
Print2DArr(testArr);
Console.WriteLine();
Print1DArr(ColumnMean(testArr));