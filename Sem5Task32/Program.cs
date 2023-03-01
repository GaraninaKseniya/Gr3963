// Задача №32
// Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.

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

// метод инверсии массива
void InversArr(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = arr[i]*(-1);
  }
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
InversArr(testArr);
Print1DArr(testArr);