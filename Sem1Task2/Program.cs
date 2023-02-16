// Задача №2 
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите число1: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите число2: ");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  int max = num1;
  if (num2 > max)
  {
    Console.WriteLine("max = "+num2);
    Console.WriteLine("min = "+num1);
  }
  else
  {
    Console.WriteLine("max = "+num1);
    Console.WriteLine("min = "+num2);
  }
}  