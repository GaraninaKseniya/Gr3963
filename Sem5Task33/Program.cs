// Задача №33
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод генерирует одномерный массив
int[] Gen1DArr(int len, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(min, max + 1);
  }
  return arr;
}

// метод печатает одномерный массив
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[arr.Length - 1]);
  Console.WriteLine("]");
}

// метод нахождения заданного элемента в массиве
int SearchElem(int[] arr, int elem)
{
  int res = -1;
  // если цикл завершился и вышла "-1", значит такого элемента в массиве нет
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == elem)
    {
      res = i; break;
    }
  }
  return res;
}

int[] testArr = Gen1DArr(30, 1, 25);
Print1DArr(testArr);
int element = ReadData("Введите элемент, который необходимо найти: ");
int indElem = SearchElem (testArr, element);
if (indElem == -1)
{
  Console.WriteLine($"Элемент {element} не найден");
}
else
Console.WriteLine($"Элемент {element} находится в массиве с индексом {indElem}"); 
