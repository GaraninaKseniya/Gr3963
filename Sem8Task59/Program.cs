// Задача №59 
// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод генерирует двумерный массив
void Gen2DArr(int[,] arr, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(min, max + 1);
    }
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

// метод нахождения наименьшего элемента массива
(int x, int y) minElem2DArr(int[,] arr)
{
  int row = 0;
  int column = 0;
  int min = int.MaxValue;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] < min)
      {
        min = arr[i, j];
        row = i;
        column = j;
      }
    }
  }
  return (row, column);
}

// метод удалит строку и столбец, на пересечении которых расположен наименьший элемент массива
int[,] Update2DArr(int[,] arr, int x, int y)
{
  int[,] resArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
  int k = 0;
  int m = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    m = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i != x && j != y)
      {
        resArr[k, m] = arr[i, j];
      }
      if (j != y) m++;
    }
    if (i != x) k++;
  }
  return resArr;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] testArr = new int[row, column];
Gen2DArr(testArr, 1, 50);
Print2DArr(testArr);
Console.WriteLine();
(int x, int y) minElem = minElem2DArr(testArr);
int[,] testNewArr = Update2DArr(testArr, minElem.x, minElem.y);
Print2DArr(testNewArr);