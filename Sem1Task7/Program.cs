// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
string? lineNum = Console.ReadLine();
if (lineNum != null)
{
  int num = int.Parse(lineNum);
  if (num > 99 && num < 1000)
  {
    int res = num % 10;
    Console.WriteLine("Последняя цифра числа: " + res);
  }
  else
  {
    Console.WriteLine("Введено не то число.");
  }
}