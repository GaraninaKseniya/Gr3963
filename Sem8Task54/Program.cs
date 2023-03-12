// Задача №54
// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

// метод сортировки массива "пузырьком"
static int[] BubbleSort(int[] row)
{
  int temp;
  for (int i = 0; i < row.Length; i++)
  {
    for (int j = i + 1; j < row.Length; j++)
    {
      if (row[i] > row[j])
      {
        temp = row[i];
        row[i] = row[j];
        row[j] = temp;
      }
    }
  }
  return row;
}

// метод сортировки по убыванию элементов каждой строки двумерного массива
void Sort2DArr(int[,] arr)
{
  int[] row = new int[arr.GetLength(1)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < row.Length; j++)
    {
      row[j] = arr[i, j];
    }
    BubbleSort(row);
    for (int j = 0; j < row.Length; j++)
    {
      arr[i, j] = row[j];
    }
  }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] testArr = new int[row, column];
Gen2DArr(testArr, 1, 50);
Print2DArr(testArr);
Console.WriteLine();
Sort2DArr(testArr);
Print2DArr(testArr);