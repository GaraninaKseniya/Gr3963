// Задача №50 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 

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

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод нахождения элемента в массиве по заданной позиции
int SearchElem(int[,] arr, int indI, int indJ)
{
  int res = -1;
  // если цикл завершился и вышла "-1", значит такого элемента в массиве нет
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (i == indI && j == indJ)
      {
        res = arr[i, j]; break;
      }
    }
  }
  return res;
}

int[,] testArr = Gen2DArr(7, 10, 1, 100);
Print2DArr(testArr);
int indI = ReadData("Введите номер строки для поиска элемента: ");
int indJ = ReadData("Введите номер столбца для поиска элемента: ");
int result = SearchElem(testArr, indI, indJ);
if (result == -1)
{
  Console.WriteLine($"Элемент отсутствует");
}
else
  Console.WriteLine($"Значение искомого элемента: {result}");
