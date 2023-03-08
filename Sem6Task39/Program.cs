// Задача №39
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

// метод переворота одномерного массива
void SwapArray(int[] arr)
{
  int bufElem = 0;
  for (int i = 0; i < arr.Length / 2; i++)
  {
    bufElem = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = bufElem;
  }
}

// метод переворота одномерного массива с помощью создания нового массива
int[] SwapNewArray(int[] arr)
{
  int[] outArr = new int[arr.Length];
  for (int i = 0; i < outArr.Length; i++)
  {
    outArr[i] = arr[arr.Length - 1 - i];
  }
  return outArr;
}

int[] testArr = Gen1DArr(30, 1, 50);
Print1DArr(testArr);
int[] newArray = SwapNewArray(testArr);
Print1DArr(newArray);
SwapArray(testArr);
Print1DArr(testArr);