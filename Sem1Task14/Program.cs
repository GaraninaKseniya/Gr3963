// Задача №14
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23. 

Console.Write("Введите число: ");
int div = int.Parse(Console.ReadLine() ?? "0");
// вариант 1
int num1 = 7;
int num2 = 23;
int rem1 = div % num1;
int rem2 = div % num2;
if (rem1 == 0 && rem2 == 0)
{
  Console.WriteLine($"Число {div} кратно {num1} и {num2}");
}
else
{
  Console.WriteLine($"Нет, число {div} не кратно одновременно {num1} и {num2}");
}
// вариант 2
if (div % 7 == 0 && div % 23 == 0)
{
  Console.WriteLine($"Число {div} кратно 7 и 23");
}
else
{
  Console.WriteLine($"Нет, число {div} не кратно одновременно 7 и 23");
}
// вариант 3
bool oper = (div % 7 == 0 && div % 23 == 0);
if (oper)
{
  Console.WriteLine($"Число {div} кратно 7 и 23");
}
else
{
  Console.WriteLine($"Нет, число {div} не кратно одновременно 7 и 23");
}