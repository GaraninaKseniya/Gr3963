// Задача №67 
// Напишите программу, которая принимает на вход число и возвращает сумму 
// цифр этого числа. С помощью рекурсии.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод возвращает сумму цифр числа
int RecSumDig(int num)
{
  if (num == 0) return 0;
  else return num % 10 + RecSumDig(num / 10);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int number = ReadData("Введите число: ");
PrintData($"Сумма цифр числа {number} = {RecSumDig(number)}");