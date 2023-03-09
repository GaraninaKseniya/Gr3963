// Задача №45
// Напишите программу, которая будет создавать копию заданного 
// одномерного массива с помощью поэлементного копирования.

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

// метод поэлементного копирования массива 
int[] CopyArrayStandartTools(int[] inputArr)
{
  int[] outArr = new int[inputArr.Length];
  inputArr.CopyTo(outArr,0);
  return outArr;
}

int[] testArr = Gen1DArr(40, 1, 50);
Print1DArr(testArr);
int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArr(testArrNew);
