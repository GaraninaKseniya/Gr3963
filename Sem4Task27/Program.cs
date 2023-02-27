// Задача №27 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 

// метод читает данные от пользователя
long ReadData(string msg)
{
  Console.WriteLine(msg);
  return long.Parse(Console.ReadLine() ?? "0");
}

// метод подсчитывает сумму цифр в числе
long SumDigits(long num)
{
  long sum = 0;
  while (num > 0)
  {
    sum += num % 10;
    num = num / 10;
  }
  return sum;
}

// метод подсчитывает сумму цифр в числе через перевод в строку
long SumDigitsStr(long num)
{
  char[] array = num.ToString().ToCharArray();
  long sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    sum = sum + (array[i]-48);
  }
  return sum;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

long number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
long res1 = SumDigits(number);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumDigitsStr(number);
Console.WriteLine(DateTime.Now - d2);

PrintData($"Сумма цифр в числе {number} равна: {res1}");
PrintData($"Сумма цифр в числе {number} равна: {res2}");