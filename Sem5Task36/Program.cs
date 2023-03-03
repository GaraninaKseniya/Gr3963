// Задача №36 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// * Найдите все пары в массиве и выведите пользователю 

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

// метод нахождения суммы элементов, стоящих на нечётных позициях
int sumOddPosition(int[] arr)
{
  int sum = 0;
  for (int i = 1; i < arr.Length; i = i + 2)
  {
    sum += arr[i];
  }
  return sum;
}

// метод выводит ответ пользователю
void PrintData(string msg, int value)
{
  Console.WriteLine(msg + value);
}

// метод нахождения всех пар в массиве и выведение их пользователю 
void PairElem(int[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
  {
    for (int j = i + 1; j < arr.Length - 2; j++)
    {
      if (arr[i] == arr[j])
      {
        Console.WriteLine($"Элементы: {arr[i]} = {arr[j]}, индексы элементов {i}, {j}");
        break;
      }
    }
  }
}

int[] testArr = Gen1DArr(15, -10, 10);
Print1DArr(testArr);
int result = sumOddPosition(testArr);
PrintData("Сумма элементов, стоящих на нечётных позициях, равна: ", result);
PairElem(testArr);