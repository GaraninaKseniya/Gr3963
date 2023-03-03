﻿// Задача №34 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. 
// * Отсортировать массив методом пузырька 

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

// метод нахождения количества чётных чисел в массиве
int CountEvenNum(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
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

// метод сортировки массива "пузырьком"
static int[] BubbleSort(int[] mas)
{
  int temp;
  for (int i = 0; i < mas.Length; i++)
  {
    for (int j = i + 1; j < mas.Length; j++)
    {
      if (mas[i] > mas[j])
      {
        temp = mas[i];
        mas[i] = mas[j];
        mas[j] = temp;
      }
    }
  }
  return mas;
}

int[] testArr = Gen1DArr(20, 100, 999);
Print1DArr(testArr);
Print1DArr(BubbleSort(testArr));
PrintData("Количество чётных чисел в массиве: ", CountEvenNum(testArr));