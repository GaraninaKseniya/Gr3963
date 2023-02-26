// Задача №29 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// * Ввести с клавиатуры длину массива и диапазон значений элементов. 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод генерирует одномерный массив
int[] Gen1DArr(int len, int min, int max)
{
  int[] arr = new int[len];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(min, max+1);
  }
  return arr;
}

// метод печатает одномерный массив
void Print1DArr(int[]arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i]+", ");
  }
  Console.Write(arr[arr.Length-1]);
  Console.WriteLine("]");
}

int lenNum = ReadData("Введите длину массива: ");
int minNum = ReadData("Введите min значение для заполнения массива: ");
int maxNum = ReadData("Введите max значение для заполнения массива: ");
int[] res = Gen1DArr(lenNum, minNum, maxNum);
Print1DArr(res);