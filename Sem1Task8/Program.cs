// Задача 8.
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string? numLine = Console.ReadLine();
if (numLine != null)
{
  double num = int.Parse(numLine);
  string res = string.Empty;
  double quotNum = num / num;
  while (quotNum <= num)
  {
    double result = num / 2;
    if (result % 2 == 0)
    {
    res = res + quotNum + "\t";
    }
    quotNum++;
  }
  Console.WriteLine(res);
}

