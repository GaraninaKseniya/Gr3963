// Задача №28 
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 

using System.Numerics;

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод подсчитывает произведение чисел от 1 до N
BigInteger FactorCalc(int num)
{
  BigInteger factor = 1;
  for (int i = 1; i <= num; i++)
  {
    factor = factor * i;
  }
  return factor;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int number = ReadData("Введите число N: ");
BigInteger res = FactorCalc(number);
PrintData($"Произведение чисел от 1 до N равно {res}");