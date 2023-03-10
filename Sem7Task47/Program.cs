// Задача №47 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

// метод генерирует двумерный массив вещественных чисел
double[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  double[,] arr = new double[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = new Random().Next(min, max + 1)+(new Random().NextDouble());
      arr[i, j] =Math.Round(arr[i,j],2);
    }
  }
  return arr;
}

// метод печатает цветной двумерный массив
void Print2DArr(double[,] arr)
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
      Console.ForegroundColor = col[new Random().Next(0,16)]; // цветная печать
      Console.Write($"{arr[i, j]}\t");
      Console.ResetColor(); // цветная печать
    }
    Console.WriteLine();
  }
}

double[,] testArr = Gen2DArr(3, 4, -10, 10);
Print2DArr(testArr);