// Задача 13: 
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
char[] array = num.ToString().ToCharArray();
if (num > 99)
{
  Console.WriteLine($"Третья цифра введенного числа: {int.Parse((array[2]).ToString())}");
}
else 
{
  Console.WriteLine("Третьей цифры нет.");
}
