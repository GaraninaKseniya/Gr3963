// Задача 13: 
// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
  while (num > 999)
  {
    num/=10;
  }
  Console.WriteLine(num%10);
}
else 
{
  Console.WriteLine("Третьей цифры нет.");
}

Console.Write("Введите число: ");
char[] array = (Console.ReadLine() ??"0").ToString().ToCharArray();
if (array.Length > 2)
{
  Console.WriteLine($"Третья цифра введенного числа: {int.Parse((array[2]).ToString())}");
}
else 
{
  Console.WriteLine("Третьей цифры нет.");
}