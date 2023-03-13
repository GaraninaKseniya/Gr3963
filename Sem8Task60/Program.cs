// Задача №60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2.

using System;

// метод генерирует трехмерный массив
void Gen3DArr(int[,,] arr, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        arr[i, j, k] = new Random().Next(min, max + 1);
      }
    }
  }
}

// метод печатает трехмерный массив
void Print3DArr(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]}, ({i}, {j}, {k})\t");
      }
    }
    Console.WriteLine();
  }
}

// // метод, который будет находить строку в двумерном массиве с наименьшей суммой элементов
// int minRowCount(int[,] arr)
// {
//   int index = -1;
//   int min = int.MaxValue;
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     int sum = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//       sum = sum + arr[i, j];
//     }
//     if (sum < min)
//     {
//       min = sum;
//       index = i;
//     }
//   }
//   return index;
// }

// // метод выводит ответ пользователю
// void PrintData(string msg)
// {
//   Console.WriteLine(msg);
// }

int[,,] testArr = new int[2, 2, 2];
Gen3DArr(testArr, 10, 100);
Print3DArr(testArr);

namespace генераторНеПовторяющихсяЦелыхЧисел
{
  class Program
  {
    static int GenSetN(int Nq, int Nm, int[] qN)
    {
      int p;
      if (Nq > Nm)
      {
        p = Nm;
        Nm = Nq;
        Nq = p;
      }
      Random r = new Random();
      int k = 0;
      while (k < Nq)
      {
        p = r.Next(Nm); // новое число
        bool b = true;
        // Проверка, имеется ли уже такое число в массиве
        for (int i = 0; i < k; i++)
          if (p == qN[i])
          {
            b = false;
            break; // досрочный выход из цикла for, если такое число уже имеется в массиве
          }
        if (b)
        {
          qN[k] = p;
          k++;
        }
      }  // конец цикла while
      return Nq;  // возврат Nq - фактическая длина массива
    }
  }
}
