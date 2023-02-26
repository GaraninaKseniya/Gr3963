// Задача №26 
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 

// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}

// 1 метод подсчета цифр в числе
// int DigitSum(int num)
// {
//   int res = 0;
//   while (num > 0)
//   {
//     res += 1;
//     num = num / 10;
//   }
//   return res;
// }

// 2 метод подсчета цифр в числе через логарифм
// int DigitSum(int num)
// {
//   return (int)(Math.Log10(num)) + 1;
// }

// 3 метод подсчета цифр в числе через перевод в строку
int DigitSum(int num)
{
  return (int) (num.ToString().Length);
}

// метод выводит ответ пользователю
void PrintData(string msg)
{
  Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int result = DigitSum(num);
PrintData("Количество цифр в числе: " + result);