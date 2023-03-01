// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

// метод подсчитывает сумму положительных и отрицательных чисел
(int posit, int negot) NegPosSum(int[] arr)
{
  int posSum = 0;
  int negSum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > 0)
    {
      posSum += i;
    }
    else
    {
      negSum += i;
    }
  }
  return (posSum, negSum);
}

// метод выводит ответ пользователю
void PrintData(string msg, int value)
{
  Console.WriteLine(msg + value);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(Gen1DArr(12, -9, 9));
(int posit, int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных чисел равна: ", results.posit);
PrintData("Сумма отрицательных чисел равна: ", results.negot);