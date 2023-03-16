// Задача №68 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// вычисление функции Аккермана с помощью рекурсии
int Ackermann(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  if (numM > 0 && numN == 0) return Ackermann(numM - 1, 1);
  else return Ackermann(numM - 1, Ackermann(numM, numN - 1));
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberM = ReadData("Введите число M:");
int numberN = ReadData("Введите число N:");
PrintData($"A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");