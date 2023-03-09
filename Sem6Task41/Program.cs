// Задача №41 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод подсчета вводимых с клавиатуры чисел (> 0)
int countNum(int numM)
{
  int res = 0;
  for (int i = 0; i < numM; i++)
  {
    if (ReadData("") > 0)
    {
      res++;
    }
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberM = ReadData("Введите количество чисел: ");
PrintData($"Введено {countNum(numberM)} чисел больше 0.");