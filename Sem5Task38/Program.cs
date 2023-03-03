// Задача №38 
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива. 

// метод генерирует и печатает одномерный массив вещественных чисел
double[] Gen1DArr(int len)
{
  double[] arr = new double[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().NextDouble() * 100;
    Console.Write("{0,7:F1}", arr[i]);
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
  return (max-min);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

double[] testArr = Gen1DArr(10);
Console.WriteLine();
double result = MaxMinDiff(testArr);
PrintData($"Разница между максимальным и минимальным элементом массива равна:{result}");
