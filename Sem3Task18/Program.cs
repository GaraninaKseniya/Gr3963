// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод проверяет вводные данные и определяет диапазон возможных координат по четверти
void PrintAnswer(int num)
{
  if (num > 0 && num < 5)
  {
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    if (num == 2) Console.WriteLine("x > 0, y < 0");
    if (num == 3) Console.WriteLine("x < 0, y < 0");
    if (num == 4) Console.WriteLine("x < 0, y > 0");
  }
  else
  {
    Console.WriteLine("Не верная четверть");
  }
}

int num = ReadData("Введите четверть: ");
PrintAnswer(num);