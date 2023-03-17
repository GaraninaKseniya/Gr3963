// Задача №66 
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод выводит сумму натуральных элементов в промежутке с помощью рекурсии
int RecSumElem(int m, int n)
{
  if (m >= n) return n;
  else return m + RecSumElem(m + 1, n);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberM = ReadData("Введите число M:");
int numberN = ReadData("Введите число N:");
int result = numberM < numberN ? RecSumElem(numberM, numberN) : RecSumElem(numberN, numberM);
PrintData($"Сумма натуральных элементов в промежутке = {result}");