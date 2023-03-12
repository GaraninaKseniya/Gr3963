// Задача №56 
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

// метод, который будет находить строку в двумерном массиве с наименьшей суммой элементов
int minRowCount(int[,] arr)
{
  int index = -1;
  int min = int.MaxValue;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum = sum + arr[i, j];
    }
    if (sum < min)
    {
      min = sum;
      index = i;
    }
  }
  return index;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] testArr = new int[row, column];
Gen2DArr(testArr, 1, 50);
Print2DArr(testArr);
PrintData($"Строка с наименьшей суммой элементов: {minRowCount(testArr)}");