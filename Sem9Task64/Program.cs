// Задача №64 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. Выполнить с помощью рекурсии.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод выводит все натуральные числа в промежутке с помощью рекурсии
void LineGenRec(int num, int maxNum)
{
  Console.Write(num + " ");
  if (num < maxNum)
  {
    LineGenRec(num + 1, maxNum);
  }
}

int number = ReadData("Введите число N:");
LineGenRec(1, number);