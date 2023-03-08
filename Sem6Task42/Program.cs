// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод преобразовывает десятичное число в двоичное
string DecToBin(int num)
{
  string res = string.Empty;
  while (num > 0)
  {
    res = num % 2 + res;
    num = num / 2;
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int number = ReadData("Введите десятичное число: ");
PrintData($"Преобразование в двоичное число : {DecToBin(number)}");