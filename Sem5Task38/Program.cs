// Задача №38 
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива. 

// метод генерирует (и печатает) одномерный массив вещественных чисел
double[] Gen1DArr(int len, int minElem, int maxElem)
{
  double[] arr = new double[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(minElem, maxElem + 1) + (new Random().NextDouble());
    //Console.Write("{0,7:F1}", arr[i]);
    arr[i] = Math.Round(arr[i], 2);
  }
  return arr;
}

// метод подсчитывает разницу между максимальным и минимальным элементом массива
double MaxMinDiff(double[] arr)
{
  double min = double.MaxValue;
  double max = double.MinValue;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
  }
  return (max - min);
}

// метод печатает одномерный массив
void Print1DArr(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ", ");
  }
  Console.Write(arr[arr.Length - 1]);
  Console.WriteLine("]");
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

double[] testArr = Gen1DArr(100, 0, 50);
Print1DArr(testArr);
double result = MaxMinDiff(testArr);
PrintData($"Разница между максимальным и минимальным элементом массива равна:{result}");
