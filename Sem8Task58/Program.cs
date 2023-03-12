// Задача №58 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using System;

// метод генерирует двумерный массив
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
  // блок корректировки входных значений
  if (min > max)
  {
    int buf = min;
    min = max;
    max = buf;
  }
  int[,] arr = new int[countRow, countColumn];
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = new Random().Next(min, max + 1);
    }
  }
  return arr;
}

// метод печатает двумерный массив
void Print2DArr(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
  }
}

// метод для нахождения произведения двух матриц
static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
  if (matrixA.ColumnsCount() != matrixB.RowsCount())
  {
    throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
  }
  var matrixC = new int[matrixA.RowsCount(), matrixB.ColumnsCount()];
  for (var i = 0; i < matrixA.RowsCount(); i++)
  {
    for (var j = 0; j < matrixB.ColumnsCount(); j++)
    {
      matrixC[i, j] = 0;
      for (var k = 0; k < matrixA.ColumnsCount(); k++)
      {
        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
      }
    }
  }
  return matrixC;
}

int[,] testArrA = Gen2DArr(3, 3, 1, 10);
Console.WriteLine("Матрица А:");
Print2DArr(testArrA);
int[,] testArrB = Gen2DArr(3, 3, 1, 10);
Console.WriteLine("Матрица В:");
Print2DArr(testArrB);
var testArrC = MatrixMultiplication(testArrA, testArrB);
Console.WriteLine("Произведение матриц:");
Print2DArr(testArrC);

// класс с методами расширения
static class MatrixExt
{
  // метод расширения для получения количества строк матрицы
  public static int RowsCount(this int[,] matrix)
  {
    return matrix.GetUpperBound(0) + 1;
  }
  // метод расширения для получения количества столбцов матрицы
  public static int ColumnsCount(this int[,] matrix)
  {
    return matrix.GetUpperBound(1) + 1;
  }
}