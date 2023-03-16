// Задача №63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод выводит все натуральные числа в промежутке с помощью рекурсии
void LineGenRec(int num)
{
  Console.Write(num + " ");
  if (num == 1)
  {

  }
  else
  {
  LineGenRec(num-1);
  }
}

int number = ReadData("Введите число N:");
LineGenRec(number);
