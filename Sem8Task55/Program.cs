// Задача №55 
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя. 

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

// метод, заменяющий строки на столбцы
void TranspArray(int[,] arr)
{
  if (arr.GetLength(0) == arr.GetLength(1))
  {
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = i + 1; j < arr.GetLength(1); j++)
      {
        temp = arr[i, j];
        arr[i, j] = arr[j, i];
        arr[j, i] = temp;
      }
    }
  }
  else
  {
    Console.WriteLine("Невозможно провести замену");
  }
}

int m = ReadData("Введите количество строк М: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] testArr = new int[m, n];
Gen2DArr(testArr, 1, 100);
Print2DArr(testArr);
Console.WriteLine();
TranspArray(testArr);
Print2DArr(testArr);
