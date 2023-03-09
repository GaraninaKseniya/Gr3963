// Задача №48
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// метод генерирует модифицированный двумерный массив
int[,] Gen2DArrMod(int countRow, int countColumn)
{
  int[,] arr = new int[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = i + j;
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

int[,] testArr = Gen2DArrMod(7, 10);
Print2DArr(testArr);
