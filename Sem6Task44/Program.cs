// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод вычисления чисел Фибоначчи без применения рекурсии
string FibNum(int num)
{
  string res = "0 1";
  int first = 0;
  int last = 1;
  for (int i = 2; i < num; i++)
  {
    res = res + " " + (first + last).ToString();
    (first, last) = (last, first + last);
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int number = ReadData("Введите количество чисел N: ");
PrintData($"Первые {number} чисел Фибоначчи: {FibNum(number)}");