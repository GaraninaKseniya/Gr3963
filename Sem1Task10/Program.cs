// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
  // вариант 1
  int num2 = num / 10 % 10;
  Console.WriteLine($"Вторая цифра введенного числа: {num2}");
  // вариант 2
  char[] digits = num.ToString().ToCharArray();
  Console.WriteLine($"Вторая цифра введенного числа: {int.Parse((digits[1]).ToString())}");
}
else
{
  Console.WriteLine("Введено не трехзначное число, повторите ввод.");
}