// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// метод подсчитывает сумму чисел от 1 до А (простой подсчет)
long SumSimple(int numA)
{
  long sum = 0;
  for (int i = 1; i <= numA; i++)
  {
    sum += i;
  }
  return sum;
}

// метод подсчитывает сумму чисел от 1 до А (метод Гаусса)
long SumGauss(int numA)
{
  return ((1 + (long)numA) * (long)numA) / 2;
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int numberA = ReadData("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGauss(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintData("Сумма чисел от 1 до А равна: " + res1);
PrintData("Сумма чисел от 1 до А равна: " + res2);