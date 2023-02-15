// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.Write("Введите число1: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите число2: ");
string? numLine2 = Console.ReadLine();
if (numLine1 != null && numLine2 != null)
{
  int num1 = int.Parse(numLine1);
  int num2 = int.Parse(numLine2);
  if (num2 * num2 == num1)
  {
    Console.WriteLine("Да");
  }
  else
  {
    Console.WriteLine("Нет");
  }
}