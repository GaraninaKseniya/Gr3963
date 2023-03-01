// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

// метод нахождения произведения пар чисел в одномерном массиве
int[] ConvertArray(int[] arr)
{
  int len = arr.Length / 2;
  if (arr.Length % 2 == 1)
  {
    len = len + 1;
  }
  int[] bufArr = new int[len];
  for (int i = 0; i < len; i++)
  {
    bufArr[i] = arr[i] * arr[arr.Length - 1 - i];
  }
  return bufArr;
}

int[] testArr = Gen1DArr(11, 1, 10);
Print1DArr(testArr);
Print1DArr(ConvertArray(testArr));