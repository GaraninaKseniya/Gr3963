// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите день недели: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num > 0 && num < 8)
{
  if (num > 0 && num < 6)
  {
    Console.WriteLine("Это рабочий день.");
  }
  else
  {
    Console.WriteLine("Ура, выходной!");
  }
}
else
{
  Console.WriteLine("Это не день недели.");
}