// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

// метод находит сумму элементов главной диагонали
int SumElemMainDiag(int[,] arr)
{
  int res = 0;
  int min = arr.GetLength(0) > arr.GetLength(1) ? arr.GetLength(1) : arr.GetLength(0);
  for (int j = 0; j < arr.GetLength(1); j++)
  {
    res = res + arr[j, j];
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int[,] testArr = Gen2DArr(5, 5, 1, 100);
Print2DArr(testArr);
PrintData($"Сумма элементов главной диагонали: {SumElemMainDiag(testArr)}");