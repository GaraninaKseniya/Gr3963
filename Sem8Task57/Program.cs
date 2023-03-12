// Задача №57 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 

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

// метод составления частотного словаря элементов двумерного массива
int[] FregDicBuild(int[,] arr, int len)
{
  int[] dic = new int[len];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      dic[arr[i, j]]++;
    }
  }
  return dic;
}

// метод печатает одномерный массив
void Print1DArr(int[] dic)
{
  for (int i = 0; i < dic.Length; i++)
  {
    Console.Write(dic[i] + "\t");
  }
}

int m = ReadData("Введите количество строк М: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] testArr = new int[m, n];
Gen2DArr(testArr, 0, 9);
Print2DArr(testArr);
Console.WriteLine();
Print1DArr(FregDicBuild(testArr, 10));
