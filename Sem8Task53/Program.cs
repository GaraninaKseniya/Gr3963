// Задача №53 
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива. 

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

// метод печатает цветной двумерный массив
void Print2DArr(int[,] arr)
{
  ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow}; // цветная печать
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0, 16)]; // цветная печать
      Console.Write($"{arr[i, j]}\t");
      Console.ResetColor(); // цветная печать
    }
    Console.WriteLine();
  }
}

// метод, меняющий местами первую и последнюю строку массива
void Change2DArray(int[,] arr)
{
  int temp = 0;
  for (int i = 0; i < arr.GetLength(1); i++)
  {
    // (arr[0,i],arr[arr.GetLength(0)-1,i])=(arr[arr.GetLength(0)-1,i],arr[0,i]);
    temp = arr[0, i];
    arr[0, i] = arr[arr.GetLength(0) - 1, i];
    arr[arr.GetLength(0) - 1, i] = temp;
  }
}

int m = ReadData("Введите количество строк М: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] testArr = new int[m, n];
Gen2DArr(testArr, 1, 100);
Print2DArr(testArr);
Console.WriteLine();
Change2DArray(testArr);
Print2DArr(testArr);