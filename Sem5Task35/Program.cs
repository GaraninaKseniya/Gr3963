// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

// метод нахождения количества элементов массива, значения которых лежат в заданном отрезке
int NumElemInRange(int[] arr, int min, int max)
{
  int count = 0;
  // если цикл завершился и вышла "-1", значит такого элемента в массиве нет
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > min && arr[i] < max)
    {
      count++;
    }
  }
  return count;
}

// метод выводит ответ пользователю
void PrintData(string msg, int value)
{
  Console.WriteLine(msg + value);
}

int[] testArr = Gen1DArr(123, -100, 100);
Print1DArr(testArr);
PrintData("Количество элементов массива, значения которых лежат в заданном отрезке: ", NumElemInRange(testArr, 10, 99));