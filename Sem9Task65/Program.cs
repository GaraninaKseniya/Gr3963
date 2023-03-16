// Задача №65
// Задайте значения M и N. Напишите программу, которая найдет все натуральные элементы
// в промежутке от M до N.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод выводит все натуральные числа в промежутке с помощью рекурсии
string RecMN(int m, int n)
{
  string res = string.Empty;
  if (m >= n)
  {
    res = n.ToString();
  }
  else
  {
    res = res + m + " " + RecMN(m + 1, n);
  }
  return res;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberM = ReadData("Введите число M:");
int numberN = ReadData("Введите число N:");
string resultLine = RecMN(numberM, numberN);
PrintData(resultLine);
