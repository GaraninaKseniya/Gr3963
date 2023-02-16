// Задача №6 
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string? numLine = Console.ReadLine();
if (numLine != null)
{
  double num = int.Parse(numLine);
  double result = num / 2;
  if (result % 2 == 0)
  {
    Console.WriteLine("число четное");
  }
  else
  {
    Console.WriteLine("число нечетное");
  }
}