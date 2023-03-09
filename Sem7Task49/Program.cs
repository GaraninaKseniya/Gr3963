// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

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

// метод заменяет элементы с четными индексами на их квадраты
void Update2DArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i = i + 2)
  {
    for (int j = 0; j < arr.GetLength(1); j = j + 2)
    {
      arr[i, j] *= arr[i, j];
    }
  }
}

int[,] testArr = Gen2DArr(5, 5, 1, 10);
Print2DArr(testArr);
Console.WriteLine();
Update2DArr(testArr);
Print2DArr(testArr);