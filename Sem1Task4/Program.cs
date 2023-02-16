// Задача №4 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введите число1: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите число2: ");
string? numLine2 = Console.ReadLine();
Console.Write("Введите число3: ");
string? numLine3 = Console.ReadLine();
if (numLine1 != null && numLine2 != null && numLine3 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  int num3 = int.Parse(numLine3);
  int max = num1;
  if (num2 > max)
  {
    max = num2;
  }
  if (num3 > max)
  {
    max = num3;
  }
  Console.WriteLine("max= " + max);
}